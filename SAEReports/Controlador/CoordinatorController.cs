using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAEReports.Vista;
using SAEReports.Modelo;
using System.Windows.Forms;
using System.Collections;

namespace SAEReports.Controlador
{
    
    public class CoordinatorController
    {
        private VistaPrincipal vistaPrincipal;
        private ResumeView resumeView;
        private VentasView ventasView;
        private BussinesLogicModel bussinesLogicModel;
        private FilterResumeVentasView filterResumeVentas;
        private VentasReportView ventasReportView;
        private InventariosView inventariosView;
        private BusquedaDocumentos busquedaDocumentosView;

        private String cveDocumento;

        private String cveDocInicial;
        private String cveDocFinal;
        private String cveClienteInicial;
        private String cveClienteFinal;
        private String cveVendedorInicial;
        private String cveVendedorFinal;
        private String cveAlmacen;

        public CoordinatorController()
        {
            cveDocInicial = "";
            cveDocFinal = "";
            cveClienteInicial = "";
            cveClienteFinal = "";
            cveVendedorInicial = "";
            cveVendedorFinal = "";
            cveAlmacen = "";
            cveDocumento = "";
        }

        public void setVistaPrincipal(VistaPrincipal vistaPrincipal)
        {
            this.vistaPrincipal = vistaPrincipal;
        }
        public VistaPrincipal getVistaPrincipal()
        {
            return vistaPrincipal;
        }
        public void setResumeView(ResumeView resumeView)
        {
            this.resumeView = resumeView;
        }
        public ResumeView getResumeView()
        {
            return resumeView;
        }
        public void setVentasView(VentasView ventasView)
        {
            this.ventasView = ventasView;
        }
        public VentasView getVentasView()
        {
            return ventasView;
        }
        public void SetInventariosView(InventariosView inventariosView)
        {
            this.inventariosView = inventariosView;
        }

        public void setBussinesLogicModel(BussinesLogicModel bussinesLogicModel)
        {
            this.bussinesLogicModel = bussinesLogicModel;
        }

        public void SetFilterResumeVentas(FilterResumeVentasView filterResumeVentas)
        {
            this.filterResumeVentas = filterResumeVentas;
        }
        public void SetVentasReportView(VentasReportView ventasReportView)
        {
            this.ventasReportView = ventasReportView;
        }
        public void SetBusquedaDocumentos(BusquedaDocumentos buscaDocs)
        {
            busquedaDocumentosView = buscaDocs;
        }
        public BusquedaDocumentos GetBusquedaDocumentos()
        {
            return busquedaDocumentosView;
        }

        public void showResumeView()
        {
            Panel presentationPanel =((Panel) vistaPrincipal.Controls["presentationPanel"]);
            if (presentationPanel.Controls.Count > 0)
            {
                presentationPanel.Controls.RemoveAt(0);
            }
            resumeView.TopLevel = false;
            resumeView.FormBorderStyle = FormBorderStyle.None;
            resumeView.Dock = DockStyle.Fill;
            presentationPanel.Controls.Add(resumeView);
            presentationPanel.Tag = resumeView;
           
            resumeView.Show();    
            
            
        }
        public void showVentasView()
        {
            Panel presentationPanel = ((Panel)vistaPrincipal.Controls["presentationPanel"]);
            if (presentationPanel.Controls.Count > 0)
                presentationPanel.Controls.RemoveAt(0);
            ventasView.TopLevel = false;
            ventasView.FormBorderStyle = FormBorderStyle.None;
            ventasView.Dock = DockStyle.Fill;
            presentationPanel.Controls.Add(ventasView);
            presentationPanel.Tag = ventasView;
            ventasView.Show();
        }

        public void ShowFilterResumeVentas()
        {
            filterResumeVentas.Show();
            filterResumeVentas.SetSetup();
        }
        public void ShowVentasReport()
        {
            ventasReportView.Show();
        }
        public void HideVentasReport()
        {
            ventasReportView.Hide();
        }
        public void HideFilterResumeVentas()
        {
            filterResumeVentas.Hide();
        }

        public void ExitApplication()
        {
            vistaPrincipal.Dispose();
        }

        public void ShowInventariosView()
        {
            Panel presentationPanel = ((Panel)vistaPrincipal.Controls["presentationPanel"]);
            if (presentationPanel.Controls.Count > 0)
                presentationPanel.Controls.RemoveAt(0);
            inventariosView.TopLevel = false;
            inventariosView.FormBorderStyle = FormBorderStyle.None;
            inventariosView.Dock = DockStyle.Fill;
            presentationPanel.Controls.Add(inventariosView);
            presentationPanel.Tag = inventariosView;
            inventariosView.Show();
        }

        public string ShowBusquedaDocumentos()
        {
            busquedaDocumentosView.ShowDialog();
            return cveDocumento;
        }
        public void HideBusquedaDocumentos()
        {
            busquedaDocumentosView.Hide();
        }

        
        public void GetFacturasDetalladoReport(DetalladoFacturasVO detalladadoFacturasVo)
        {
            int result = bussinesLogicModel.DetalladoFacturas(detalladadoFacturasVo);

            switch (result)
            {
                case 1:
                    HideFilterResumeVentas();
                    ShowVentasReport();
                    ventasReportView.SetDataArray(bussinesLogicModel.GetResumenFacturas());
                    ventasReportView.ShowData();
                    break;
                case 2:
                    filterResumeVentas.ShowNotification("La clave inicial del documento no existe.");
                    break;
                case 3:
                    filterResumeVentas.ShowNotification("La clave final del documento no existe.");
                    break;
                case 4:
                    filterResumeVentas.ShowNotification("La clave inicial del cliente no existe.");
                    break;
                case 5:
                    filterResumeVentas.ShowNotification("La clave final del cliente no existe.");
                    break;
                case 6:
                    filterResumeVentas.ShowNotification("La clave inicial del vendedor no existe.");
                    break;
                case 7:
                    filterResumeVentas.ShowNotification("La clave final del vendedor no existe.");
                    break;
                case 8:
                    filterResumeVentas.ShowNotification("El almacén no existe.");
                    break;
                case 9:
                    filterResumeVentas.ShowNotification("No existe información que cumpla el criterio de búsqueda.");
                    break;
            }
                
           
                
        }

        public void ConsultaFacturas(string filtro, string query)
        {
            int result = bussinesLogicModel.ConsultaFacturas(filtro, query);
            switch (result)
            {
                case 0:
                    busquedaDocumentosView.SetDataArray(bussinesLogicModel.GetConsultaFacturas());
                    busquedaDocumentosView.ShowData();
                    break;
                    
            }
          

          
        }
       
           
        //**************************Setters usados en la selección de filtros para reporte de facturas******************
        public void SetCveDocumento(String cveFactura)
        {
            this.cveDocumento = cveFactura;
        }


        public void SetClaveDocInicial(string cveDocIni)
        {
            this.cveDocInicial = cveDocIni;
            
        }
        public void SetClaveDocFinal(String cveDocFinal)
        {
            this.cveDocFinal = cveDocFinal;
        }

        public void SetClaveVendedorInicial(String cveVendedorInicial)
        {
            this.cveVendedorInicial = cveVendedorInicial;
        }
        public void SetClaveVendedorFinal(String cveVendedorFinal)
        {
            this.cveVendedorFinal = cveVendedorFinal;
        }
        public void SetClaveClienteInicial(String cveClienteInicial)
        {
            this.cveClienteInicial = cveClienteInicial;
        }
        public void SetClaveClienteFinal(String cveClienteFinal)
        {
            this.cveClienteFinal = cveClienteFinal;
        }
        public void SetClaveAlmacen(String cveAlmacen)
        {
            this.cveAlmacen = cveAlmacen;
        }
    //*****************************************************************************************************************
    }
}
