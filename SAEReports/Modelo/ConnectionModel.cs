using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;

namespace SAEReports.Modelo
{
    class ConnectionModel
    {
        FbConnection fbConnection;
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
