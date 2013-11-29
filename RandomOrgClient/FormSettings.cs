using System;
using System.Linq;
using System.Windows.Forms;
using RandomOrgClient.com.andaforce.arazect.configuration;
using RandomOrgClient.com.andaforce.arazect.format;

namespace RandomOrgClient
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private ProgrammWorkingData _currentInstance;

        private readonly CountSystemType[] _countSystems =
        {
            CountSystemType.Binary,
            CountSystemType.Decimal,
            CountSystemType.Oct,
            CountSystemType.Hexadecimal
        };

        private readonly RandomNumberType[] _randomNumberTypes =
        {
            RandomNumberType.New,
            RandomNumberType.IdIdentifier,
            RandomNumberType.DateIsodate
        };

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // Copying old settings
            _currentInstance = ProgrammConfigInstance.GetCopy();

            // Count systems
            foreach (var t in _countSystems)
            {
                cbCountSystem.Items.Add(t);
            }
            cbCountSystem.SelectedIndex =
                _countSystems
                    .Select((value, index) => new {value, index = index + 1})
                    .Where(pair => pair.value == ProgrammConfigInstance.Get().ProgrammSettings.CountSystem)
                    .Select(pair => pair.index)
                    .FirstOrDefault() - 1;

            // Random systems
            foreach (var randomNumberType in _randomNumberTypes)
            {
                cbRandomGenerationType.Items.Add(randomNumberType);
            }
            cbRandomGenerationType.SelectedIndex =
                _randomNumberTypes
                    .Select((value, index) => new {value, index = index + 1})
                    .Where(pair => pair.value == ProgrammConfigInstance.Get().ProgrammSettings.RandomNumberType)
                    .Select(pair => pair.index)
                    .FirstOrDefault() - 1;

            // Cache
            cbCacheSequences.Checked = ProgrammConfigInstance.Get().ProgrammSettings.UseCache;
            nudSequenceLenght.Value = ProgrammConfigInstance.Get().ProgrammSettings.CacheSequenceLenght;

            // Offline
            cbOfflineMode.Checked = ProgrammConfigInstance.Get().ProgrammSettings.OfflineMode;
        }

        private void cbCountSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentInstance.ProgrammSettings.CountSystem =
                (CountSystemType) cbCountSystem.SelectedItem;
        }

        private void cbRandomGenerationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentInstance.ProgrammSettings.RandomNumberType =
                (RandomNumberType) cbRandomGenerationType.SelectedItem;
        }

        private void cbCacheSequences_CheckedChanged(object sender, EventArgs e)
        {
            _currentInstance.ProgrammSettings.UseCache = cbCacheSequences.Checked;
        }

        private void nudSequenceLenght_ValueChanged(object sender, EventArgs e)
        {
            _currentInstance.ProgrammSettings.CacheSequenceLenght = (int) nudSequenceLenght.Value;
        }

        private void cbOfflineMode_CheckedChanged(object sender, EventArgs e)
        {
            _currentInstance.ProgrammSettings.OfflineMode = cbOfflineMode.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ProgrammConfigInstance.Replace(_currentInstance);
            ProgrammConfigInstance.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}