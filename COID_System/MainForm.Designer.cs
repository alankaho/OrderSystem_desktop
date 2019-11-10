namespace COID_System
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonCustomerTab = new System.Windows.Forms.Button();
            this.buttonMenuPlanTab = new System.Windows.Forms.Button();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.detailFoods1 = new COID_System.DetailFoods();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.Controls.Add(this.buttonCustomerTab);
            this.panel1.Controls.Add(this.buttonMenuPlanTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 636);
            this.panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(12, 456);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Location = new System.Drawing.Point(12, 218);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(178, 36);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Location = new System.Drawing.Point(12, 285);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(178, 36);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Location = new System.Drawing.Point(12, 159);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(178, 36);
            this.buttonEmployee.TabIndex = 2;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonCustomerTab
            // 
            this.buttonCustomerTab.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCustomerTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomerTab.Location = new System.Drawing.Point(12, 91);
            this.buttonCustomerTab.Name = "buttonCustomerTab";
            this.buttonCustomerTab.Size = new System.Drawing.Size(178, 36);
            this.buttonCustomerTab.TabIndex = 1;
            this.buttonCustomerTab.Text = "Customers";
            this.buttonCustomerTab.UseVisualStyleBackColor = false;
            this.buttonCustomerTab.Click += new System.EventHandler(this.buttonCustomerTab_Click);
            // 
            // buttonMenuPlanTab
            // 
            this.buttonMenuPlanTab.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonMenuPlanTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuPlanTab.Location = new System.Drawing.Point(12, 35);
            this.buttonMenuPlanTab.Name = "buttonMenuPlanTab";
            this.buttonMenuPlanTab.Size = new System.Drawing.Size(178, 36);
            this.buttonMenuPlanTab.TabIndex = 0;
            this.buttonMenuPlanTab.Text = "Menu Plan";
            this.buttonMenuPlanTab.UseVisualStyleBackColor = false;
            this.buttonMenuPlanTab.Click += new System.EventHandler(this.buttonMenuPlan_Click);
            // 
            // detailFoods1
            // 
            this.detailFoods1.Location = new System.Drawing.Point(242, 21);
            this.detailFoods1.Name = "detailFoods1";
            this.detailFoods1.Size = new System.Drawing.Size(945, 571);
            this.detailFoods1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 636);
            this.Controls.Add(this.detailFoods1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonCustomerTab;
        private System.Windows.Forms.Button buttonMenuPlanTab;
        
        private System.Windows.Forms.Button buttonExit;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private DetailFoods detailFoods1;
    }
}