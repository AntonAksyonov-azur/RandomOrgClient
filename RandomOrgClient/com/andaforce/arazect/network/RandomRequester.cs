using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using RandomOrgClient.com.andaforce.arazect.configuration;
using RandomOrgClient.com.andaforce.arazect.format;

namespace RandomOrgClient.com.andaforce.arazect.network
{
    public class RandomRequester
    {
        private const String IntegersAddress = "http://www.random.org/integers";
        private const String QuotaAddress = "http://www.random.org/quota/?format=plain";
        // http://www.random.org/integers/?num=10&min=1&max=6&col=1&base=10&format=plain&rnd=new
        private Dictionary<String, List<int>> _cache = new Dictionary<string, List<int>>();
        private MD5 _md5Hash;

        public RandomRequester()
        {
            _md5Hash = MD5.Create();
        }

        public int[] GetRequest(int min, int max, int count)
        {
            var elementsToReceive = Math.Max(ProgrammConfigInstance.Get().ProgrammSettings.CacheSequenceLenght, count);
            byte[] md5 = _md5Hash.ComputeHash(Encoding.Default.GetBytes(String.Format("From {0} to {1}", min, max)));
            String md5String = BitConverter.ToString(md5);
            
            if (!_cache.ContainsKey(md5String) || _cache[md5String].Count < count)
            {
                var requestString =
                    String.Format("{0}?num={1}&min={2}&max={3}&base={4}&rnd={5}&format=plain&col=1",
                        IntegersAddress,
                        elementsToReceive,
                        min,
                        max,
                        (int) ProgrammConfigInstance.Get().ProgrammSettings.CountSystem,
                        ProgrammConfigInstance.Get().ProgrammSettings.RandomNumberType.GetStringRepresentation());
                var webRequest = WebRequest.Create(requestString);
                var response = (HttpWebResponse) webRequest.GetResponse();
                var dataStream = response.GetResponseStream();
                if (dataStream != null)
                {
                    var reader = new StreamReader(dataStream);
                    string content = reader.ReadToEnd();
                    var integers = content.Split(new[]{'\n'}, StringSplitOptions.RemoveEmptyEntries).Select(a=>int.Parse(a)).ToList();

                    if (_cache.ContainsKey(md5String))
                    {
                        _cache[md5String] = integers;
                    }
                    else
                    {
                        _cache.Add(md5String, integers);
                    }
                }
            }

            var result = _cache[md5String].Take(count).ToArray();
            _cache[md5String].RemoveRange(0, count);

            return result;
        }

        public int RequestQuota()
        {
            var webRequest = WebRequest.Create(QuotaAddress);
            var response = (HttpWebResponse)webRequest.GetResponse();
            var dataStream = response.GetResponseStream();
            if (dataStream != null)
            {
                var reader = new StreamReader(dataStream);
                string content = reader.ReadToEnd();
                return int.Parse(content);
            }

            return -1;
        }
    }
}