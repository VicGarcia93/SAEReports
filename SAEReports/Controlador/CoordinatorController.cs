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
        VistaPrincipal vistaPrincipal;
        ResumeView resumeView;
        VentasView ventasView;
        BussinesLogicModel bussinesLogicModel;
        FilterResumeVentasView filterResumeVentas;
        FilterFacturasDetallado filterFacturasDetallado;
        InventariosView inventariosView;

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
        public void SetFilterFacturasDetallado(FilterFacturasDetallado filterFacturasDetallado)
        {
            this.filterFacturasDetallado = filterFacturasDetallado;
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
        public void ShowFilterFacturasDetallado()
        {
            filterFacturasDetallado.Show();
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
        public void ShowFacturasReport()
        {
            filterFacturasDetallado.Show();
        }
        public void GetFacturasDetalladoReport(DetalladoFacturasVO detalladadoFacturasVo)
        {
            int result = bussinesLogicModel.DetalladoFacturas(detalladadoFacturasVo);

            if (result == 1)
            {
                HideFilterResumeVentas();
                ShowFilterFacturasDetallado();
                filterFacturasDetallado.SetDataArray(bussinesLogicModel.GetResumenFacturas());
                filterFacturasDetallado.ShowData();
            }
            else if (result == 2)
            {
                filterResumeVentas.ShowNotification("Ingresa la clave final de los documentos a consultar");
                
            }
            else if (result == 0)
            {
                filterResumeVentas.ShowNotification("Error.");
            }
                
        }
    
    }
}
