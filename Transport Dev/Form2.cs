using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace Transport_Dev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            AesEncrypter.GenerateKey();
        }

        private void testSQLConnect_Click(object sender, EventArgs e)
        {
            string Host = hostBox.Text;
            string Port = portBox.Text;
            string DBname = dbBox.Text;
            string User = loginBox.Text;
            string Password = passBox.Text;

            string connectionString = String.Format("Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                Host,
                User,
                DBname,
                Port,
                Password);

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT version()", conn))
                    {
                        cmd.ExecuteNonQuery();

                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(0), "OK!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (savePasswordCheckBox.Checked)
            {
                XMLConfig.saveXMLConfigFile(hostBox.Text, portBox.Text, dbBox.Text, loginBox.Text, passBox.Text);
            }
            else
            {
                XMLConfig.saveXMLConfigFile(hostBox.Text, portBox.Text, dbBox.Text, loginBox.Text);
            }
        }
    }
}
