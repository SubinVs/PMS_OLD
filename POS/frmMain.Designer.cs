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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPax = new MetroFramework.Controls.MetroTextBox();
            this.cbWaiter = new MetroFramework.Controls.MetroComboBox();
            this.cbCaptain = new MetroFramework.Controls.MetroComboBox();
            this.cbTable = new MetroFramework.Controls.MetroComboBox();
            this.cbArea = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbQty = new MetroFramework.Controls.MetroTextBox();
            this.tbRate = new MetroFramework.Controls.MetroTextBox();
            this.cbItems = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dgvItems = new MetroFramework.Controls.MetroGrid();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbPax);
            this.panel1.Controls.Add(this.cbWaiter);
            this.panel1.Controls.Add(this.cbCaptain);
            this.panel1.Controls.Add(this.cbTable);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Location = new System.Drawing.Point(25, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 90);
            this.panel1.TabIndex = 0;
            // 
            // tbPax
            // 
            // 
            // 
            // 
            this.tbPax.CustomButton.Image = null;
            this.tbPax.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.tbPax.CustomButton.Name = "";
            this.tbPax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPax.CustomButton.TabIndex = 1;
            this.tbPax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPax.CustomButton.UseSelectable = true;
            this.tbPax.CustomButton.Visible = false;
            this.tbPax.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbPax.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbPax.Lines = new string[0];
            this.tbPax.Location = new System.Drawing.Point(846, 34);
            this.tbPax.MaxLength = 32767;
            this.tbPax.Name = "tbPax";
            this.tbPax.PasswordChar = '\0';
            this.tbPax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPax.SelectedText = "";
            this.tbPax.SelectionLength = 0;
            this.tbPax.SelectionStart = 0;
            this.tbPax.ShortcutsEnabled = true;
            this.tbPax.Size = new System.Drawing.Size(51, 23);
            this.tbPax.TabIndex = 4;
            this.tbPax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPax.UseSelectable = true;
            this.tbPax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbPax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPax_KeyPress);
            // 
            // cbWaiter
            // 
            this.cbWaiter.FormattingEnabled = true;
            this.cbWaiter.ItemHeight = 23;
            this.cbWaiter.Location = new System.Drawing.Point(663, 30);
            this.cbWaiter.Name = "cbWaiter";
            this.cbWaiter.Size = new System.Drawing.Size(167, 29);
            this.cbWaiter.TabIndex = 3;
            this.cbWaiter.UseSelectable = true;
            this.cbWaiter.SelectionChangeCommitted += new System.EventHandler(this.cbWaiter_SelectionChangeCommitted);
            // 
            // cbCaptain
            // 
            this.cbCaptain.FormattingEnabled = true;
            this.cbCaptain.ItemHeight = 23;
            this.cbCaptain.Location = new System.Drawing.Point(475, 30);
            this.cbCaptain.Name = "cbCaptain";
            this.cbCaptain.Size = new System.Drawing.Size(167, 29);
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
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.tbQty);
            this.metroPanel1.Controls.Add(this.tbRate);
            this.metroPanel1.Controls.Add(this.cbItems);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 164);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(922, 89);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbQty
            // 
            // 
            // 
            // 
            this.tbQty.CustomButton.Image = null;
            this.tbQty.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.tbQty.CustomButton.Name = "";
            this.tbQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbQty.CustomButton.TabIndex = 1;
            this.tbQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbQty.CustomButton.UseSelectable = true;
            this.tbQty.CustomButton.Visible = false;
            this.tbQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbQty.Lines = new string[0];
            this.tbQty.Location = new System.Drawing.Point(309, 33);
            this.tbQty.MaxLength = 32767;
            this.tbQty.Name = "tbQty";
            this.tbQty.PasswordChar = '\0';
            this.tbQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbQty.SelectedText = "";
            this.tbQty.SelectionLength = 0;
            this.tbQty.SelectionStart = 0;
            this.tbQty.ShortcutsEnabled = true;
            this.tbQty.Size = new System.Drawing.Size(54, 23);
            this.tbQty.TabIndex = 7;
            this.tbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQty.UseSelectable = true;
            this.tbQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQty_KeyDown);
            // 
            // tbRate
            // 
            // 
            // 
            // 
            this.tbRate.CustomButton.Image = null;
            this.tbRate.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.tbRate.CustomButton.Name = "";
            this.tbRate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbRate.CustomButton.TabIndex = 1;
            this.tbRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbRate.CustomButton.UseSelectable = true;
            this.tbRate.CustomButton.Visible = false;
            this.tbRate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbRate.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tbRate.Lines = new string[0];
            this.tbRate.Location = new System.Drawing.Point(249, 33);
            this.tbRate.MaxLength = 32767;
            this.tbRate.Name = "tbRate";
            this.tbRate.PasswordChar = '\0';
            this.tbRate.ReadOnly = true;
            this.tbRate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRate.SelectedText = "";
            this.tbRate.SelectionLength = 0;
            this.tbRate.SelectionStart = 0;
            this.tbRate.ShortcutsEnabled = true;
            this.tbRate.Size = new System.Drawing.Size(54, 23);
            this.tbRate.TabIndex = 6;
            this.tbRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRate.UseSelectable = true;
            this.tbRate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbRate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.ItemHeight = 23;
            this.cbItems.Location = new System.Drawing.Point(20, 29);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(200, 29);
            this.cbItems.TabIndex = 5;
            this.cbItems.UseSelectable = true;
            this.cbItems.SelectionChangeCommitted += new System.EventHandler(this.cbItems_SelectionChangeCommitted);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.dgvItems);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(25, 259);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(922, 457);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItems.EnableHeadersVisualStyles = false;
            this.dgvItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvItems.Location = new System.Drawing.Point(3, 3);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(914, 449);
            this.dgvItems.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
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
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox cbCaptain;
        private MetroFramework.Controls.MetroComboBox cbTable;
        private MetroFramework.Controls.MetroComboBox cbArea;
        private MetroFramework.Controls.MetroComboBox cbWaiter;
        private MetroFramework.Controls.MetroTextBox tbPax;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cbItems;
        private MetroFramework.Controls.MetroTextBox tbQty;
        private MetroFramework.Controls.MetroTextBox tbRate;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvItems;
    }
}