namespace CustomTabs.CustomPages
{
    partial class UserControl1
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
            this.UserSettings = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.UserSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserSettings
            // 
            this.UserSettings.Controls.Add(this.propertyGrid1);
            this.UserSettings.Location = new System.Drawing.Point(4, 22);
            this.UserSettings.Name = "UserSettings";
            this.UserSettings.Padding = new System.Windows.Forms.Padding(3);
            this.UserSettings.Size = new System.Drawing.Size(611, 430);
            this.UserSettings.TabIndex = 1;
            this.UserSettings.Text = "UserSettings";
            this.UserSettings.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.UserSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 456);
            this.tabControl1.TabIndex = 1;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(605, 424);
            this.propertyGrid1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(619, 456);
            this.UserSettings.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage UserSettings;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
