using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;

namespace SAEReports.Modelo
{
    class VentasDAO
    {
        public VentasDAO(){

    }
        public List<DetalladoFacturasVO> BuscarFacturas(String sqlQuery)
        {
            //String sqlFacturas = "select fac.cve_doc,fac.cve_clpv,fac.status,fac.fecha_doc,fac.cve_vend,fac.doc_ant,fac.num_alma from factf03 fac";
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
           
            FbCommand fbCommand = new FbCommand(sqlQuery, conexion.GetConnection());
            
            FbDataReader reader = fbCommand.ExecuteReader();
            List<DetalladoFacturasVO>  listaFacturas = new List<DetalladoFacturasVO>();
            while (reader.Read())
            {
               
                DetalladoFacturasVO nuevoDetalladoFacturas = new DetalladoFacturasVO();
                nuevoDetalladoFacturas.SetCveDocInicial(reader.GetString(0));
                nuevoDetalladoFacturas.SetCveDocFinal(reader.GetString(0));
                nuevoDetalladoFacturas.SetClienteInicial(reader.GetString(1));
                nuevoDetalladoFacturas.SetClienteFinal(reader.GetString(1));
                nuevoDetalladoFacturas.SetStatus(reader.GetString(2));
                nuevoDetalladoFacturas.SetFechaElaboracionInicial(reader.GetString(3));
                nuevoDetalladoFacturas.SetFechaElaboracionFinal(reader.GetString(3));
                nuevoDetalladoFacturas.SetCveVendedorInicial(reader.GetString(4));
                nuevoDetalladoFacturas.SetCveVendedorFinal(reader.GetString(4));
                nuevoDetalladoFacturas.SetCveDocAnterior(reader.GetString(5));
                nuevoDetalladoFacturas.SetAlmacen(reader.GetInt16(6));
                nuevoDetalladoFacturas.SetImporte(reader.GetFloat(7));
                nuevoDetalladoFacturas.SetSubtotal(reader.GetFloat(8));
                nuevoDetalladoFacturas.SetImpuesto(reader.GetFloat(9));
                
                listaFacturas.Add(nuevoDetalladoFacturas);
            }
            
            return listaFacturas;
        }

        public bool ValidaAlmacen(int almacen)
        {
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
            string sqlQuery = "SELECT cve_alm FROM mult03 WHERE cve_alm = " + almacen; 
            FbCommand fbCommand = new FbCommand(sqlQuery, conexion.GetConnection());
            FbDataReader reader = fbCommand.ExecuteReader();

            return reader.Read() ? true : false;
        }
        public bool validaCveDoc(string clave)
        {
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
            string sqlQuery = "SELECT cve_doc FROM factf03 WHERE cve_doc = '" + clave + "'";
            FbCommand fbCommand = new FbCommand(sqlQuery, conexion.GetConnection());
            FbDataReader reader = fbCommand.ExecuteReader();
            return reader.Read() ? true : false;
        }
        public bool validaCveCliente(string clave)
        {
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
            string sqlQuery = "SELECT clave FROM clie03 WHERE clave = '" + clave + "'";
            FbCommand fbCommand = new FbCommand(sqlQuery, conexion.GetConnection());
            FbDataReader reader = fbCommand.ExecuteReader();
            return reader.Read() ? true : false;
        }
        public bool validaCveVendedor(string clave){
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
            string sqlQuery = "SELECT cve_vend FROM vend03 WHERE cve_vend ='    " + clave + "'";
            FbCommand fbCommand = new FbCommand(sqlQuery, conexion.GetConnection());
            FbDataReader reader = fbCommand.ExecuteReader();
            return reader.Read() ? true : false;
        }
        
      }
    
}
