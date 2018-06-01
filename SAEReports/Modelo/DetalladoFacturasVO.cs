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
        private String fechaElaboracionInicial;
        private String fechaElaboracionFinal;
        private int almacen;

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
        public String GetStatus()
        {
            return status;
        }
        public void SetFechaElaboracionInicial(String fechaElaboracionInicial)
        {
            this.fechaElaboracionInicial = fechaElaboracionInicial;
        }
        public String GetFechaElaboracionInicial()
        {
            return fechaElaboracionInicial;
        }
        public void SetFechaElaboracionFinal(String fechaElaboracionFinal)
        {
            this.fechaElaboracionFinal = fechaElaboracionFinal;
        }
        public String GetFechaElaboracionFinal()
        {
            return fechaElaboracionFinal;
        }
        public void SetAlmacen(int almacen)
        {
            this.almacen = almacen;
        }
        public int GetAlmacen()
        {
            return almacen;
        }
    
    }
}
