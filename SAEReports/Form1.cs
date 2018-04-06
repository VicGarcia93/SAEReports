using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;


namespace SAEReports
{
    public partial class Form1 : Form
    {
        FbConnection fbConnection;
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectionFB()
        {
            FbConnectionStringBuilder conStrBuil = new FbConnectionStringBuilder();
            conStrBuil.ServerType = FbServerType.Default;
            conStrBuil.Database = "C:\\Users\\Victhor\\Documents\\Visual Studio 2013\\Projects\\SAEReport\\SAEReports\\src\\SAE70EMPRE01.FDB";
            conStrBuil.UserID = "SYSDBA";
            conStrBuil.Password = "masterkey";
            fbConnection = new FbConnection(conStrBuil.ToString());
            try
            {
                if (fbConnection != null)
                    fbConnection.Close();
                fbConnection.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex){
                Console.WriteLine("Error al conectar" + ex.Message);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionFB();
        }

        private void txtFind_Click(object sender, EventArgs e)
        {
            String idProduct = txtCve.Text;
            String sqlQuery = "SELECT INV.descr, INV.exist FROM INVE01 INV WHERE INV.CVE_ART = '" + idProduct + "'";

            try
            {
                FbCommand fbCommand = new FbCommand(sqlQuery, fbConnection);
                FbDataReader reader = fbCommand.ExecuteReader();

                while (reader.Read())
                {
                    txtDescription.Text = reader.GetString(0);
                    txtExist.Text = "" + reader.GetDouble(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la consulta " + ex.Message);
            }
            finally
            {

                if (fbConnection.State == System.Data.ConnectionState.Open)

                    fbConnection.Close();

            }
            
        }
    }
}
