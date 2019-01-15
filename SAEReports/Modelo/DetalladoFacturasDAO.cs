using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;

namespace SAEReports.Modelo
{
    class DetalladoFacturasDAO
    {
        public DetalladoFacturasDAO()
        {

        }
        public List<DetalladoFacturasVO> BuscarFacturas(DetalladoFacturasVO detalladoFacturas)
        {
            String sqlFacturas = "select fac.cve_doc,fac.cve_clpv,fac.status,fac.fecha_doc,fac.cve_vend,fac.doc_ant,fac.num_alma from factf03 fac";
            ConnectionModel conexion = new ConnectionModel();
            conexion.ConnectionFB();
           
            FbCommand fbCommand = new FbCommand(sqlFacturas, conexion.GetConnection());
            
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

                
                listaFacturas.Add(nuevoDetalladoFacturas);
            }
            
            return listaFacturas;
        }
    }
}
