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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxBreakfast = new System.Windows.Forms.ComboBox();
            this.comboBoxLunch = new System.Windows.Forms.ComboBox();
            this.comboBoxDinner = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.monthCalendar1.Location = new System.Drawing.Point(74, 138);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(438, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(477, 100);
            this.listBox1.TabIndex = 10;
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
            // comboBoxLunch
            // 
            this.comboBoxLunch.FormattingEnabled = true;
            this.comboBoxLunch.Location = new System.Drawing.Point(548, 158);
            this.comboBoxLunch.Name = "comboBoxLunch";
            this.comboBoxLunch.Size = new System.Drawing.Size(271, 24);
            this.comboBoxLunch.TabIndex = 18;
            this.comboBoxLunch.SelectedIndexChanged += new System.EventHandler(this.comboBoxLunch_SelectedIndexChanged);
            // 
            // comboBoxDinner
            // 
            this.comboBoxDinner.FormattingEnabled = true;
            this.comboBoxDinner.Location = new System.Drawing.Point(548, 321);
            this.comboBoxDinner.Name = "comboBoxDinner";
            this.comboBoxDinner.Size = new System.Drawing.Size(271, 24);
            this.comboBoxDinner.TabIndex = 19;
            this.comboBoxDinner.SelectedIndexChanged += new System.EventHandler(this.comboBoxDinner_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(438, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(477, 100);
            this.listBox2.TabIndex = 20;
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
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 405);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 53);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Breakfast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lunch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dinner:";
            // 
            // MenuPlan
            // 
            this.ClientSize = new System.Drawing.Size(927, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.comboBoxDinner);
            this.Controls.Add(this.comboBoxLunch);
            this.Controls.Add(this.comboBoxBreakfast);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBoxBreakfast;
        private System.Windows.Forms.ComboBox comboBoxLunch;
        private System.Windows.Forms.ComboBox comboBoxDinner;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
