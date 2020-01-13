namespace COID_System
{
    partial class MenuPlan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBoxBreakfast = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBoxLunch = new System.Windows.Forms.ComboBox();
            this.comboBoxDinner = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(59, 25);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(292, 57);
            this.buttonSchedule.TabIndex = 6;
            this.buttonSchedule.Text = "Menu list";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(69, 159);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(438, 42);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(477, 100);
            this.listBox2.TabIndex = 10;
            // 
            // comboBoxBreakfast
            // 
            this.comboBoxBreakfast.FormattingEnabled = true;
            this.comboBoxBreakfast.Location = new System.Drawing.Point(548, 12);
            this.comboBoxBreakfast.Name = "comboBoxBreakfast";
            this.comboBoxBreakfast.Size = new System.Drawing.Size(271, 24);
            this.comboBoxBreakfast.TabIndex = 14;
            this.comboBoxBreakfast.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(438, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 21);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Breakfast";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(441, 159);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 21);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Lunch";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(441, 324);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 21);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dinner";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBoxLunch
            // 
            this.comboBoxLunch.FormattingEnabled = true;
            this.comboBoxLunch.Location = new System.Drawing.Point(548, 158);
            this.comboBoxLunch.Name = "comboBoxLunch";
            this.comboBoxLunch.Size = new System.Drawing.Size(271, 24);
            this.comboBoxLunch.TabIndex = 18;
            // 
            // comboBoxDinner
            // 
            this.comboBoxDinner.FormattingEnabled = true;
            this.comboBoxDinner.Location = new System.Drawing.Point(548, 321);
            this.comboBoxDinner.Name = "comboBoxDinner";
            this.comboBoxDinner.Size = new System.Drawing.Size(271, 24);
            this.comboBoxDinner.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(438, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 100);
            this.listBox1.TabIndex = 20;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(438, 368);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(477, 132);
            this.listBox3.TabIndex = 21;
            // 
            // MenuPlan
            // 
            this.ClientSize = new System.Drawing.Size(927, 524);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxDinner);
            this.Controls.Add(this.comboBoxLunch);
            this.Controls.Add(this.comboBoxBreakfast);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonSchedule);
            this.Name = "MenuPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBoxBreakfast;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox comboBoxLunch;
        private System.Windows.Forms.ComboBox comboBoxDinner;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox3;
    }
}
