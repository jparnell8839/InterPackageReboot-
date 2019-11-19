namespace InterpackageReboot__
{
    partial class formShowInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formShowInterface));
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMinutes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioRemind = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioNow = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioDateTimePicker = new System.Windows.Forms.RadioButton();
            this.dtpickerDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // comboHours
            // 
            this.comboHours.FormattingEnabled = true;
            this.comboHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboHours.Location = new System.Drawing.Point(114, 68);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(36, 21);
            this.comboHours.TabIndex = 1;
            this.comboHours.Click += new System.EventHandler(this.comboHours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "hours";
            // 
            // comboMinutes
            // 
            this.comboMinutes.FormattingEnabled = true;
            this.comboMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboMinutes.Location = new System.Drawing.Point(195, 68);
            this.comboMinutes.Name = "comboMinutes";
            this.comboMinutes.Size = new System.Drawing.Size(36, 21);
            this.comboMinutes.TabIndex = 3;
            this.comboMinutes.Click += new System.EventHandler(this.comboHours_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "minutes";
            // 
            // radioRemind
            // 
            this.radioRemind.AutoSize = true;
            this.radioRemind.Location = new System.Drawing.Point(12, 69);
            this.radioRemind.Name = "radioRemind";
            this.radioRemind.Size = new System.Drawing.Size(92, 17);
            this.radioRemind.TabIndex = 5;
            this.radioRemind.TabStop = true;
            this.radioRemind.Text = "Remind me in:";
            this.radioRemind.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your IT Organization has determined your computer is in need of a reboot.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please select a time to be reminded.";
            // 
            // radioNow
            // 
            this.radioNow.AutoSize = true;
            this.radioNow.Location = new System.Drawing.Point(12, 140);
            this.radioNow.Name = "radioNow";
            this.radioNow.Size = new System.Drawing.Size(85, 17);
            this.radioNow.TabIndex = 8;
            this.radioNow.TabStop = true;
            this.radioNow.Text = "Reboot Now";
            this.radioNow.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(150, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Copyright © 2019 jParnell - All Rights Reserved";
            // 
            // radioDateTimePicker
            // 
            this.radioDateTimePicker.AutoSize = true;
            this.radioDateTimePicker.Location = new System.Drawing.Point(12, 106);
            this.radioDateTimePicker.Name = "radioDateTimePicker";
            this.radioDateTimePicker.Size = new System.Drawing.Size(96, 17);
            this.radioDateTimePicker.TabIndex = 11;
            this.radioDateTimePicker.TabStop = true;
            this.radioDateTimePicker.Text = "Remind me on:";
            this.radioDateTimePicker.UseVisualStyleBackColor = true;
            // 
            // dtpickerDate
            // 
            this.dtpickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerDate.Location = new System.Drawing.Point(114, 102);
            this.dtpickerDate.Name = "dtpickerDate";
            this.dtpickerDate.Size = new System.Drawing.Size(111, 20);
            this.dtpickerDate.TabIndex = 12;
            this.dtpickerDate.ValueChanged += new System.EventHandler(this.dtpickerDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "at";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(251, 103);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(111, 20);
            this.dtpTime.TabIndex = 14;
            this.dtpTime.ValueChanged += new System.EventHandler(this.dtpickerDate_ValueChanged);
            // 
            // formShowInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 216);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpickerDate);
            this.Controls.Add(this.radioDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.radioNow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioRemind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMinutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboHours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formShowInterface";
            this.Text = "InterPackageReboot++";
            this.Load += new System.EventHandler(this.formShowInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioRemind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioNow;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioDateTimePicker;
        private System.Windows.Forms.DateTimePicker dtpickerDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}

