using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEReports.Modelo
{
    class DetalladoFacturasVO
    {
        private String cveDoc;
        private int cliente;
        private String nombreCliente;
        private String status;
        private String fechaElaboracion;
        private String almacen;

        public void SetCveDoc(String cveDoc)
        {
            this.cveDoc = cveDoc;
        }
        public String GetCveDoc(){
            return cveDoc;
        }
        public void SetCliente(int cliente){
            this.cliente = cliente;
        }
        public int GetCliente()
        {
            return cliente;
        }
        public void SetNombreCliente(String nombreCliente)
        {
            this.nombreCliente = nombreCliente;
        }
        public String GetNombreCliente()
        {
            return nombreCliente;
        }

        public void SetStatus(String status)
        {
            this.status = status;
        }
    
    }
}
