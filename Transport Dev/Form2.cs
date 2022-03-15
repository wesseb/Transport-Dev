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
        private readonly string xmlfile = @"config.xml";
        private const string tokenFile = @"key.token";

        public Form2()
        {
            InitializeComponent();

            if (!File.Exists(tokenFile))
            {
                AesEncrypter.GenerateKey();
            }
        }

        private bool enableSwitch (bool enable)
        {
            hostBox.Enabled = enable;
            portBox.Enabled = enable;
            dbBox.Enabled = enable;
            loginBox.Enabled = enable;
            passBox.Enabled = enable;

            return enable;
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
                    enableSwitch(false);

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
                enableSwitch(false);

                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                enableSwitch(true);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            byte[] key;
            byte[] iv;

            using (StreamReader sr = new StreamReader(tokenFile))
            {
                string? tokenKey = sr.ReadLine();
                string? tokenIV = sr.ReadLine();

                key = Convert.FromBase64String(tokenKey);
                iv = Convert.FromBase64String(tokenIV);
            }

            try
            {
                if (!File.Exists(xmlfile))
                {
                    XDocument xDoc = new XDocument(
                        new XElement("SQL",
                            new XElement("Host", hostBox.Text),
                            new XElement("Port", portBox.Text),
                            new XElement("DBname", dbBox.Text),
                            new XElement("User", loginBox.Text),
                            new XElement("Password", AesEncrypter.EncryptToAesAndOutput(passBox.Text, key, iv))
                        )
                    );

                    xDoc.Save(xmlfile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                enableSwitch(true);
            }
        }
    }
}
