using System;
using System.Windows.Forms;
using RandomOrgClient.com.andaforce.arazect.configuration;
using RandomOrgClient.com.andaforce.arazect.data;

namespace RandomOrgClient
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Base Programm Cycle

        private void FormMain_Load(object sender, EventArgs e)
        {
            ProgrammConfigInstance.Load();

            UpdateBinding(() => lbPresets.SelectedIndex = lbPresets.Items.Count - 1);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgrammConfigInstance.Save();
        }

        #endregion

        #region Bindings

        private void UpdateBinding(Action afterUpdate = null)
        {
            lbPresets.DataSource = null;
            lbPresets.DataSource = ProgrammConfigInstance.Get().Records;

            if (afterUpdate != null)
            {
                afterUpdate.Invoke();
            }
        }

        #endregion

        #region Data control

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0)
            {
                var record = new RandomPresetRecord
                {
                    Name = tbName.Text,
                    Count = (int) nudCount.Value,
                    Min = (int) nudMin.Value,
                    Max = (int) nudMax.Value,
                };
                ProgrammConfigInstance.Get().Records.Add(record);
                UpdateBinding(() => lbPresets.SelectedIndex = lbPresets.Items.Count - 1);
            }
            else
            {
                MessageBox.Show(
                    "Вы должны выбрать название для своих настроек, чтобы сохранить их",
                    "Поле \"Название\" пусто",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
        }

        private void btnRewrite_Click(object sender, EventArgs e)
        {
            if (lbPresets.SelectedIndex != -1)
            {
                var value = (RandomPresetRecord) lbPresets.SelectedItem;
                value.Name = tbName.Text;
                value.Count = (int) nudCount.Value;
                value.Min = (int) nudMin.Value;
                value.Max = (int) nudMax.Value;

                var prevSelectedIndex = lbPresets.SelectedIndex;
                UpdateBinding(() => lbPresets.SelectedIndex = prevSelectedIndex);
            }
            else
            {
                MessageBox.Show(
                    "Вы должны выбрать элемент, чтобы изменить его",
                    "Элемент не выбран",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPresets.SelectedIndex != -1)
            {
                if (MessageBox.Show(
                    "Вы дейстительно хотите удалить этот элемент?",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    _programmWorkingData.Records.Remove((RandomPresetRecord) lbPresets.SelectedItem);
                    UpdateBinding(() => lbPresets.SelectedIndex = lbPresets.Items.Count - 1);
                }
            }
            else
            {
                MessageBox.Show(
                    "Вы должны выбрать элемент, чтобы удалить его",
                    "Элемент не выбран",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
        }

        #endregion

        #region Data Visual

        private void lbPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (RandomPresetRecord) lbPresets.SelectedItem;
            if (selected != null)
            {
                tbName.Text = selected.Name;
                nudMin.Value = selected.Min;
                nudMax.Value = selected.Max;
                nudCount.Value = selected.Count;
            }
        }

        #endregion

        #region Main Menu

        #region File

        private void загрузитьСохраненныеЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void экспортироватьСохраненныеЗначенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Service

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new FormSettings())
            {
                settingsForm.ShowDialog();
            }
        }

        #endregion

        #region Help

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #endregion
    }
}