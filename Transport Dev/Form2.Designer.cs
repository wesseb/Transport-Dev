namespace Transport_Dev
{
    partial class Form2
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
            this.testSQLConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dbBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.savePasswordCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            this.SuspendLayout();
            // 
            // testSQLConnect
            // 
            this.testSQLConnect.Location = new System.Drawing.Point(149, 184);
            this.testSQLConnect.Name = "testSQLConnect";
            this.testSQLConnect.Size = new System.Drawing.Size(79, 50);
            this.testSQLConnect.TabIndex = 0;
            this.testSQLConnect.Text = "Przetestuj połączenie";
            this.testSQLConnect.UseVisualStyleBackColor = true;
            this.testSQLConnect.Click += new System.EventHandler(this.testSQLConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host:";
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(53, 14);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(175, 23);
            this.hostBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(53, 43);
            this.portBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(55, 23);
            this.portBox.TabIndex = 4;
            this.portBox.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(53, 72);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(175, 23);
            this.loginBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasło:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(53, 101);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(175, 23);
            this.passBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DB:";
            // 
            // dbBox
            // 
            this.dbBox.Location = new System.Drawing.Point(53, 155);
            this.dbBox.Name = "dbBox";
            this.dbBox.Size = new System.Drawing.Size(175, 23);
            this.dbBox.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 184);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 50);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Zapisz Dane";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // savePasswordCheckBox
            // 
            this.savePasswordCheckBox.AutoSize = true;
            this.savePasswordCheckBox.Location = new System.Drawing.Point(53, 130);
            this.savePasswordCheckBox.Name = "savePasswordCheckBox";
            this.savePasswordCheckBox.Size = new System.Drawing.Size(116, 19);
            this.savePasswordCheckBox.TabIndex = 12;
            this.savePasswordCheckBox.Text = "Zapamiętaj hasło";
            this.savePasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 242);
            this.Controls.Add(this.savePasswordCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dbBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testSQLConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Połączenie bazy danych";
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button testSQLConnect;
        private Label label1;
        private TextBox hostBox;
        private Label label2;
        private NumericUpDown portBox;
        private Label label3;
        private TextBox loginBox;
        private Label label4;
        private TextBox passBox;
        private Label label5;
        private TextBox dbBox;
        private Button saveButton;
        private CheckBox savePasswordCheckBox;
    }
}