using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEReports.Modelo
{
    public class DetalladoFacturasVO
    {
        private String cveDocInicial;
        private String cveDocFinal;
        private String clienteInicial;
        private String clienteFinal;
        private String nombreCliente;
        private String status;
        private String fechaElaboracionInicial;
        private String fechaElaboracionFinal;
        private String cveDocAnterior;
        private String cveDocSiguiente;
        private int almacen;
        private String cveVendeInicial;
        private String cveVendeFinal;
        private String cveProducto;
        private String descripcionProd;
        private int grupoProducto;
        private String lineaProd;
        private String ordenaPrimero;
        private String ordenaDespues;
        private float importe;
        private float subtotal;
        private float impuesto;
        private bool filtroProductos;
        private bool filtroServicios;
        private bool filtroKits;
        private bool filtroGrupos;
        private bool filtroDesglose;
        private bool filtroCostos;
        private bool filtroContabilizado;
        private bool filtroContado;

        public void SetCveDocInicial(String cveDoc)
        {
            this.cveDocInicial = cveDoc;
        }
        public String GetCveDocInicial(){
            return cveDocInicial;
        }
        public void SetCveDocFinal(String cveDoc)
        {
            this.cveDocFinal = cveDoc;
        }
        public String GetCveDocFinal()
        {
            return cveDocFinal;
        }
        public void SetClienteInicial(String cliente){
            this.clienteInicial = cliente;
        }
        public String GetClienteInicial()
        {
            return clienteInicial;
        }
        public void SetClienteFinal(String cliente)
        {
            this.clienteFinal = cliente;
        }
        public String GetClienteFinal()
        {
            return clienteFinal;
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
        public void SetCveVendedorInicial(String cveVendeInicial)
        {
            this.cveVendeInicial = cveVendeInicial;
        }
        public String GetCveVendedorInicial()
        {
            return cveVendeInicial;
        }
        public void SetCveVendedorFinal(String cveVendeFinal)
        {
            this.cveVendeFinal = cveVendeFinal;
        }
        public String GetCveVendedorFinal()
        {
            return cveVendeFinal;
        }
        public void SetCveProducto(String cveProd)
        {
            this.cveProducto = cveProd;
        }
        public String GetCveProducto()
        {
            return cveProducto;
        }
        public void SetDescripcionProducto(String descrProd)
        {
            this.descripcionProd = descrProd;
        }
        public String GetDescripcionProdcuto()
        {
            return descripcionProd;
        }
        public void SetGrupoProducto(int grupoProducto)
        {
            this.grupoProducto = grupoProducto;
        }
        public int GetGrupoProducto()
        {
            return grupoProducto;
        }
        public void SetLineaProducto(String lineaProducto)
        {
            this.lineaProd = lineaProducto;
        }
        public String GetLineaProducto()
        {
            return lineaProd;
        }
        public void SetOrdenaPrimero(String ordenaPrimero)
        {
            this.ordenaPrimero = ordenaPrimero;
        }
        public String GetOrdenaPrimero()
        {
            return ordenaPrimero;
        }
        public void SetOrdenaDespues(String ordenaDespues)
        {
            this.ordenaDespues = ordenaDespues;
        }
        public void SetFiltroProductos(bool opc)
        {
            this.filtroProductos = opc;
        }
        public bool GetFiltroProductos()
        {
            return filtroProductos;
        }
        public void SetFiltroServicios(bool opc)
        {
            this.filtroServicios = opc;
        }
        public bool GetFiltroServicios()
        {
            return filtroServicios;
        }
        public void SetFiltroKits(bool opc)
        {
            this.filtroKits = opc;
        }
        public bool GetFiltroKits()
        {
            return filtroKits;
        }
        public void SetFiltroGrupos(bool opc)
        {
            this.filtroGrupos = opc;
        }
        public bool GetFiltroGrupos()
        {
            return filtroGrupos;
        }
        public void SetFiltroCostos(bool opc)
        {
            this.filtroCostos = opc;
        }
        public bool GetFiltroCostos()
        {
            return filtroCostos;
        }
        public void SetFiltroContabilizado(bool opc)
        {
            this.filtroContabilizado = opc;
        }
        public bool GetFiltroContabilizado()
        {
            return filtroContabilizado;
        }
        public void SetFiltroContado(bool opc)
        {
            this.filtroContado = opc;
        }
        public void SetFiltroDesglose(bool opc)
        {
            this.filtroDesglose = opc;
        }
        public bool GetFiltroDesglose()
        {
            return filtroDesglose;
        }
        public void SetCveDocAnterior(String cveDocAnterior)
        {
            this.cveDocAnterior = cveDocAnterior;
        }
        public String GetCveDocAnterior()
        {
            return cveDocAnterior;
        }
        public void SetCveDocSiguiente(String cveDocSiguiente)
        {
            this.cveDocSiguiente = cveDocSiguiente;
        }
        public String GetCveDocSiguiente()
        {
            return cveDocSiguiente;
        }
        public void SetImporte(float importe)
        {
            this.importe = importe;
        }
        public float GetImporte()
        {
            return importe;
        }
        public void SetSubtotal(float subtotal)
        {
            this.subtotal = subtotal;
        }
        public float GetSubtotal()
        {
            return subtotal;
        }
        public void SetImpuesto(float impuesto)
        {
            this.impuesto = impuesto;
        }
        public float GetImpuesto()
        {
            return impuesto;
        }
    
    }
}
