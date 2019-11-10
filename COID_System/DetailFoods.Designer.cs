namespace COID_System
{
    partial class DetailFoods
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.Lable3 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listBoxFood = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonFood = new System.Windows.Forms.RadioButton();
            this.radioButtonCombo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(94, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(94, 83);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(136, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(311, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 167);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.Location = new System.Drawing.Point(311, 288);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(186, 49);
            this.buttonChangeImage.TabIndex = 6;
            this.buttonChangeImage.Text = "Change Image";
            this.buttonChangeImage.UseVisualStyleBackColor = true;
            // 
            // Lable3
            // 
            this.Lable3.AutoSize = true;
            this.Lable3.Location = new System.Drawing.Point(23, 126);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(65, 17);
            this.Lable3.TabIndex = 7;
            this.Lable3.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(94, 126);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(194, 24);
            this.comboBoxCategory.TabIndex = 8;
            // 
            // listBoxFood
            // 
            this.listBoxFood.FormattingEnabled = true;
            this.listBoxFood.ItemHeight = 16;
            this.listBoxFood.Location = new System.Drawing.Point(39, 43);
            this.listBoxFood.Name = "listBoxFood";
            this.listBoxFood.Size = new System.Drawing.Size(304, 436);
            this.listBoxFood.TabIndex = 9;
            this.listBoxFood.SelectedIndexChanged += new System.EventHandler(this.listBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(230, 503);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 38);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add new";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxDescription);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.Lable3);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonChangeImage);
            this.panel1.Location = new System.Drawing.Point(376, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 498);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(94, 188);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(194, 231);
            this.textBoxDescription.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(254, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(381, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonFood
            // 
            this.radioButtonFood.AutoSize = true;
            this.radioButtonFood.Checked = true;
            this.radioButtonFood.Location = new System.Drawing.Point(582, 16);
            this.radioButtonFood.Name = "radioButtonFood";
            this.radioButtonFood.Size = new System.Drawing.Size(68, 21);
            this.radioButtonFood.TabIndex = 12;
            this.radioButtonFood.TabStop = true;
            this.radioButtonFood.Text = "Foods";
            this.radioButtonFood.UseVisualStyleBackColor = true;
            // 
            // radioButtonCombo
            // 
            this.radioButtonCombo.AutoSize = true;
            this.radioButtonCombo.Location = new System.Drawing.Point(739, 16);
            this.radioButtonCombo.Name = "radioButtonCombo";
            this.radioButtonCombo.Size = new System.Drawing.Size(80, 21);
            this.radioButtonCombo.TabIndex = 13;
            this.radioButtonCombo.Text = "Combos";
            this.radioButtonCombo.UseVisualStyleBackColor = true;
            // 
            // DetailFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonCombo);
            this.Controls.Add(this.radioButtonFood);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxFood);
            this.Controls.Add(this.panel1);
            this.Name = "DetailFoods";
            this.Size = new System.Drawing.Size(945, 571);
            this.Load += new System.EventHandler(this.DetailFoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.Label Lable3;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ListBox listBoxFood;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonFood;
        private System.Windows.Forms.RadioButton radioButtonCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
