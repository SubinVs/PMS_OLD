namespace POS
{
    partial class frmMain
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
            this.cbWaiter = new MetroFramework.Controls.MetroComboBox();
            this.cbCaptain = new MetroFramework.Controls.MetroComboBox();
            this.cbTable = new MetroFramework.Controls.MetroComboBox();
            this.cbArea = new MetroFramework.Controls.MetroComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbWaiter);
            this.panel1.Controls.Add(this.cbCaptain);
            this.panel1.Controls.Add(this.cbTable);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Location = new System.Drawing.Point(25, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 90);
            this.panel1.TabIndex = 0;
            // 
            // cbWaiter
            // 
            this.cbWaiter.FormattingEnabled = true;
            this.cbWaiter.ItemHeight = 23;
            this.cbWaiter.Location = new System.Drawing.Point(702, 30);
            this.cbWaiter.Name = "cbWaiter";
            this.cbWaiter.Size = new System.Drawing.Size(200, 29);
            this.cbWaiter.TabIndex = 3;
            this.cbWaiter.UseSelectable = true;
            this.cbWaiter.SelectionChangeCommitted += new System.EventHandler(this.cbWaiter_SelectionChangeCommitted);
            // 
            // cbCaptain
            // 
            this.cbCaptain.FormattingEnabled = true;
            this.cbCaptain.ItemHeight = 23;
            this.cbCaptain.Location = new System.Drawing.Point(476, 30);
            this.cbCaptain.Name = "cbCaptain";
            this.cbCaptain.Size = new System.Drawing.Size(200, 29);
            this.cbCaptain.TabIndex = 2;
            this.cbCaptain.UseSelectable = true;
            this.cbCaptain.SelectionChangeCommitted += new System.EventHandler(this.cbCaptain_SelectionChangeCommitted);
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.ItemHeight = 23;
            this.cbTable.Location = new System.Drawing.Point(249, 30);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(200, 29);
            this.cbTable.TabIndex = 1;
            this.cbTable.UseSelectable = true;
            this.cbTable.SelectionChangeCommitted += new System.EventHandler(this.cbTable_SelectionChangeCommitted);
            // 
            // cbArea
            // 
            this.cbArea.ItemHeight = 23;
            this.cbArea.Location = new System.Drawing.Point(20, 30);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(200, 29);
            this.cbArea.TabIndex = 0;
            this.cbArea.UseSelectable = true;
            this.cbArea.SelectionChangeCommitted += new System.EventHandler(this.cbArea_SelectionChangeCommitted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmMain";
            this.Resizable = false;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cbCaptain;
        private MetroFramework.Controls.MetroComboBox cbTable;
        private MetroFramework.Controls.MetroComboBox cbArea;
        private MetroFramework.Controls.MetroComboBox cbWaiter;
    }
}