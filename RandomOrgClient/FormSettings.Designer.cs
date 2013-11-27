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
            this.cbCountSystem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRandomGenerationType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chCacheSequences = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSequenceLenght = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLenght)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(350, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры запроса";
            // 
            // cbCountSystem
            // 
            this.cbCountSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountSystem.FormattingEnabled = true;
            this.cbCountSystem.Items.AddRange(new object[] {
            "Двоичная (основание 2, bin)",
            "Восьмеричная (основание 8, oct)",
            "Десятичная (основание 10, dec)",
            "Шестнадцатиричная (основание 16, hex)"});
            this.cbCountSystem.Location = new System.Drawing.Point(130, 19);
            this.cbCountSystem.Name = "cbCountSystem";
            this.cbCountSystem.Size = new System.Drawing.Size(211, 21);
            this.cbCountSystem.TabIndex = 0;
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
            this.cbRandomGenerationType.Items.AddRange(new object[] {
            "new",
            "id.identifier",
            "date.isodate"});
            this.cbRandomGenerationType.Location = new System.Drawing.Point(130, 46);
            this.cbRandomGenerationType.Name = "cbRandomGenerationType";
            this.cbRandomGenerationType.Size = new System.Drawing.Size(211, 21);
            this.cbRandomGenerationType.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSequenceLenght);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chCacheSequences);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры программы";
            // 
            // chCacheSequences
            // 
            this.chCacheSequences.AutoSize = true;
            this.chCacheSequences.Checked = true;
            this.chCacheSequences.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chCacheSequences.Location = new System.Drawing.Point(9, 19);
            this.chCacheSequences.Name = "chCacheSequences";
            this.chCacheSequences.Size = new System.Drawing.Size(229, 17);
            this.chCacheSequences.TabIndex = 0;
            this.chCacheSequences.Text = "Кэшировать последовательности чисел";
            this.chCacheSequences.UseVisualStyleBackColor = true;
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
            // nudSequenceLenght
            // 
            this.nudSequenceLenght.Location = new System.Drawing.Point(238, 42);
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
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(206, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(287, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 207);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLenght)).EndInit();
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
        private System.Windows.Forms.CheckBox chCacheSequences;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}