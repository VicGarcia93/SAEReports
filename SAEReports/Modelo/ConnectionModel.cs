using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;

namespace SAEReports.Modelo
{
    class ConnectionModel
    {
        FbConnection fbConnection;
        public void ConnectionFB()
        {
            FbConnectionStringBuilder conStrBuil = new FbConnectionStringBuilder();
            conStrBuil.ServerType = FbServerType.Default;
            conStrBuil.Database = "C:\\Users\\Usuario 232\\SAE70EMPRE03.FDB";
            conStrBuil.UserID = "SYSDBA";
            conStrBuil.Password = "masterkey";
            fbConnection = new FbConnection(conStrBuil.ToString());
            try
            {
                if (fbConnection != null)
                    fbConnection.Close();
                fbConnection.Open();
                Console.WriteLine("Conectado!");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar" + ex.Message);
            };
        }
        public FbConnection GetConnection()
        {
            return fbConnection;
        }

        public void Disconnect()
        {
            fbConnection = null;
        }
    }
}
