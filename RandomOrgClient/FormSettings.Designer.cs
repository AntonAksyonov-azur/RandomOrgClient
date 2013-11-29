namespace RandomOrgClient
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRandomGenerationType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountSystem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSequenceLenght = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCacheSequences = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOfflineMode = new System.Windows.Forms.CheckBox();
            this.btnQuotaCheck = new System.Windows.Forms.Button();
            this.lQuotaInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLenght)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbRandomGenerationType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbCountSystem);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры запроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип случайного числа";
            // 
            // cbRandomGenerationType
            // 
            this.cbRandomGenerationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRandomGenerationType.FormattingEnabled = true;
            this.cbRandomGenerationType.Location = new System.Drawing.Point(156, 46);
            this.cbRandomGenerationType.Name = "cbRandomGenerationType";
            this.cbRandomGenerationType.Size = new System.Drawing.Size(211, 21);
            this.cbRandomGenerationType.TabIndex = 2;
            this.cbRandomGenerationType.SelectedIndexChanged += new System.EventHandler(this.cbRandomGenerationType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Система исчисления";
            // 
            // cbCountSystem
            // 
            this.cbCountSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountSystem.FormattingEnabled = true;
            this.cbCountSystem.Location = new System.Drawing.Point(156, 19);
            this.cbCountSystem.Name = "cbCountSystem";
            this.cbCountSystem.Size = new System.Drawing.Size(211, 21);
            this.cbCountSystem.TabIndex = 0;
            this.cbCountSystem.SelectedIndexChanged += new System.EventHandler(this.cbCountSystem_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lQuotaInfo);
            this.groupBox2.Controls.Add(this.btnQuotaCheck);
            this.groupBox2.Controls.Add(this.nudSequenceLenght);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbCacheSequences);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры программы";
            // 
            // nudSequenceLenght
            // 
            this.nudSequenceLenght.Location = new System.Drawing.Point(265, 42);
            this.nudSequenceLenght.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSequenceLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSequenceLenght.Name = "nudSequenceLenght";
            this.nudSequenceLenght.Size = new System.Drawing.Size(102, 20);
            this.nudSequenceLenght.TabIndex = 2;
            this.nudSequenceLenght.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSequenceLenght.ValueChanged += new System.EventHandler(this.nudSequenceLenght_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Длина кэшированной последовательности";
            // 
            // cbCacheSequences
            // 
            this.cbCacheSequences.AutoSize = true;
            this.cbCacheSequences.Checked = true;
            this.cbCacheSequences.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCacheSequences.Location = new System.Drawing.Point(9, 19);
            this.cbCacheSequences.Name = "cbCacheSequences";
            this.cbCacheSequences.Size = new System.Drawing.Size(229, 17);
            this.cbCacheSequences.TabIndex = 0;
            this.cbCacheSequences.Text = "Кэшировать последовательности чисел";
            this.cbCacheSequences.UseVisualStyleBackColor = true;
            this.cbCacheSequences.CheckedChanged += new System.EventHandler(this.cbCacheSequences_CheckedChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(229, 262);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbOfflineMode);
            this.groupBox3.Location = new System.Drawing.Point(12, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Offline-режим";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Остальные настройки не будут использованы";
            // 
            // cbOfflineMode
            // 
            this.cbOfflineMode.AutoSize = true;
            this.cbOfflineMode.Location = new System.Drawing.Point(9, 19);
            this.cbOfflineMode.Name = "cbOfflineMode";
            this.cbOfflineMode.Size = new System.Drawing.Size(217, 17);
            this.cbOfflineMode.TabIndex = 0;
            this.cbOfflineMode.Text = "Не использовать связь с Random.org";
            this.cbOfflineMode.UseVisualStyleBackColor = true;
            this.cbOfflineMode.CheckedChanged += new System.EventHandler(this.cbOfflineMode_CheckedChanged);
            // 
            // btnQuotaCheck
            // 
            this.btnQuotaCheck.Location = new System.Drawing.Point(6, 60);
            this.btnQuotaCheck.Name = "btnQuotaCheck";
            this.btnQuotaCheck.Size = new System.Drawing.Size(115, 23);
            this.btnQuotaCheck.TabIndex = 5;
            this.btnQuotaCheck.Text = "Проверить квоту";
            this.btnQuotaCheck.UseVisualStyleBackColor = true;
            this.btnQuotaCheck.Click += new System.EventHandler(this.btnQuotaCheck_Click);
            // 
            // lQuotaInfo
            // 
            this.lQuotaInfo.AutoSize = true;
            this.lQuotaInfo.Location = new System.Drawing.Point(127, 65);
            this.lQuotaInfo.Name = "lQuotaInfo";
            this.lQuotaInfo.Size = new System.Drawing.Size(221, 13);
            this.lQuotaInfo.TabIndex = 6;
            this.lQuotaInfo.Text = "Для IP 127.0.0.1 доступно 1 000 000 чисел";
            this.lQuotaInfo.Visible = false;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 297);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLenght)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRandomGenerationType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCountSystem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudSequenceLenght;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbCacheSequences;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbOfflineMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lQuotaInfo;
        private System.Windows.Forms.Button btnQuotaCheck;
    }
}