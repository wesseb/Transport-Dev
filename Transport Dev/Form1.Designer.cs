namespace Transport_Dev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SQLCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bazaDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typBazyDanychToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zdalnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polaczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozlaczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujDanePolaczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SQLCheck});
            this.statusStrip1.Location = new System.Drawing.Point(0, 826);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1345, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Połączony:";
            // 
            // SQLCheck
            // 
            this.SQLCheck.Name = "SQLCheck";
            this.SQLCheck.Size = new System.Drawing.Size(25, 17);
            this.SQLCheck.Text = "Nie";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bazaDanychToolStripMenuItem,
            this.oAplikacjiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bazaDanychToolStripMenuItem
            // 
            this.bazaDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typBazyDanychToolStripMenuItem,
            this.toolStripSeparator1,
            this.polaczToolStripMenuItem,
            this.rozlaczToolStripMenuItem,
            this.edytujDanePolaczeniaToolStripMenuItem});
            this.bazaDanychToolStripMenuItem.Name = "bazaDanychToolStripMenuItem";
            this.bazaDanychToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.bazaDanychToolStripMenuItem.Text = "Baza Danych";
            // 
            // typBazyDanychToolStripMenuItem
            // 
            this.typBazyDanychToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalnaToolStripMenuItem,
            this.zdalnaToolStripMenuItem});
            this.typBazyDanychToolStripMenuItem.Name = "typBazyDanychToolStripMenuItem";
            this.typBazyDanychToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.typBazyDanychToolStripMenuItem.Text = "Typ bazy danych";
            // 
            // lokalnaToolStripMenuItem
            // 
            this.lokalnaToolStripMenuItem.Enabled = false;
            this.lokalnaToolStripMenuItem.Name = "lokalnaToolStripMenuItem";
            this.lokalnaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.lokalnaToolStripMenuItem.Text = "Lokalna";
            // 
            // zdalnaToolStripMenuItem
            // 
            this.zdalnaToolStripMenuItem.Checked = true;
            this.zdalnaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zdalnaToolStripMenuItem.Name = "zdalnaToolStripMenuItem";
            this.zdalnaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.zdalnaToolStripMenuItem.Text = "Zdalna";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // polaczToolStripMenuItem
            // 
            this.polaczToolStripMenuItem.Name = "polaczToolStripMenuItem";
            this.polaczToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.polaczToolStripMenuItem.Text = "Polacz";
            // 
            // rozlaczToolStripMenuItem
            // 
            this.rozlaczToolStripMenuItem.Enabled = false;
            this.rozlaczToolStripMenuItem.Name = "rozlaczToolStripMenuItem";
            this.rozlaczToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rozlaczToolStripMenuItem.Text = "Rozlacz";
            // 
            // edytujDanePolaczeniaToolStripMenuItem
            // 
            this.edytujDanePolaczeniaToolStripMenuItem.Name = "edytujDanePolaczeniaToolStripMenuItem";
            this.edytujDanePolaczeniaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.edytujDanePolaczeniaToolStripMenuItem.Text = "Edytuj dane polaczenia";
            this.edytujDanePolaczeniaToolStripMenuItem.Click += new System.EventHandler(this.edytujDanePolaczeniaToolStripMenuItem_Click);
            // 
            // oAplikacjiToolStripMenuItem
            // 
            this.oAplikacjiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjeToolStripMenuItem});
            this.oAplikacjiToolStripMenuItem.Name = "oAplikacjiToolStripMenuItem";
            this.oAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.oAplikacjiToolStripMenuItem.Text = "O aplikacji";
            // 
            // informacjeToolStripMenuItem
            // 
            this.informacjeToolStripMenuItem.Name = "informacjeToolStripMenuItem";
            this.informacjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacjeToolStripMenuItem.Text = "Informacje";
            this.informacjeToolStripMenuItem.Click += new System.EventHandler(this.informacjeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1345, 848);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Truck Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel SQLCheck;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bazaDanychToolStripMenuItem;
        private ToolStripMenuItem typBazyDanychToolStripMenuItem;
        private ToolStripMenuItem lokalnaToolStripMenuItem;
        private ToolStripMenuItem zdalnaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem polaczToolStripMenuItem;
        private ToolStripMenuItem rozlaczToolStripMenuItem;
        private ToolStripMenuItem edytujDanePolaczeniaToolStripMenuItem;
        private ToolStripMenuItem oAplikacjiToolStripMenuItem;
        private ToolStripMenuItem informacjeToolStripMenuItem;
    }
}