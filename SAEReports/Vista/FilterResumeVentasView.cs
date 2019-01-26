using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEReports.Controlador;
using SAEReports.Modelo;
using System.Collections;

namespace SAEReports.Vista
{
    public partial class FilterResumeVentasView : Form
    {
        CoordinatorController coordinatorController;
        public FilterResumeVentasView()
        {
            InitializeComponent();
        }
        public void SetController(CoordinatorController coordinatorController)
        {
            this.coordinatorController = coordinatorController;
        }
        public void SetClaveDocInicial(string cveFactura)
        {
            txtCveDocInicial.Text = cveFactura;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalladoFacturasVO detalladoFacturasVo = new DetalladoFacturasVO();
            int numAlmacen;
            //Datos del objeto DetalladoFacturasVO
            if (!String.IsNullOrEmpty(txtAlmacen.Text))
            {
                if(int.TryParse(txtAlmacen.Text,out numAlmacen)){
                    detalladoFacturasVo.SetAlmacen(numAlmacen);
                }else
                    detalladoFacturasVo.SetAlmacen(-1);
                
            }
            String strCveClienteIni = "";
            String strCveClienteFin = "";
            if (!String.IsNullOrEmpty(txtClientesIni.Text))
            {
                
                for (int i = 0; i < (10 - txtClientesIni.TextLength); i++)
                {
                    strCveClienteIni += " ";
                }
                strCveClienteIni += txtClientesIni.Text;

                for (int i = 0; i < (10 - txtCveClienteFin.TextLength); i++)
                {
                    strCveClienteFin += " ";
                }
                strCveClienteFin += txtCveClienteFin.Text;
            }
            

            detalladoFacturasVo.SetClienteInicial(strCveClienteIni);
           
            detalladoFacturasVo.SetClienteFinal(strCveClienteFin);
            
            detalladoFacturasVo.SetCveDocInicial(txtCveDocInicial.Text);
            
            detalladoFacturasVo.SetCveDocFinal(txtCveDocFinal.Text);
           
            detalladoFacturasVo.SetCveProducto(txtCveProducto.Text);
          
            detalladoFacturasVo.SetCveVendedorInicial(txtVendeIni.Text);
            
                detalladoFacturasVo.SetCveVendedorFinal(txtVendeFin.Text);
            if(!String.IsNullOrEmpty(txtDescrProd.Text))
                detalladoFacturasVo.SetDescripcionProducto(txtDescrProd.Text);
            if(!String.IsNullOrEmpty(dtpInicial.Text))
                detalladoFacturasVo.SetFechaElaboracionInicial(dtpInicial.Text);
            if(!String.IsNullOrEmpty(dtpFinal.Text))
                detalladoFacturasVo.SetFechaElaboracionFinal(dtpInicial.Text);
            if(chbContabilizado.Checked)
                detalladoFacturasVo.SetFiltroContabilizado(chbContabilizado.Checked);
            if(chbContado.Checked)
                detalladoFacturasVo.SetFiltroContado(chbContado.Checked);
            if(chbCostos.Checked)
                detalladoFacturasVo.SetFiltroCostos(chbCostos.Checked);
            if(chbDesglose.Checked)
                detalladoFacturasVo.SetFiltroDesglose(chbDesglose.Checked);
            if(chbGrupo.Checked)
                detalladoFacturasVo.SetFiltroGrupos(chbGrupo.Checked);
            if(chbKits.Checked)
                detalladoFacturasVo.SetFiltroKits(chbKits.Checked);
            if(chbProductos.Checked)
                detalladoFacturasVo.SetFiltroProductos(chbProductos.Checked);
            if(chbServicios.Checked)
                detalladoFacturasVo.SetFiltroServicios(chbServicios.Checked);
            if(!String.IsNullOrEmpty(txtGrupoProd.Text))
                detalladoFacturasVo.SetGrupoProducto(int.Parse(txtGrupoProd.Text));
            if(!String.IsNullOrEmpty(txtLineaProd.Text))
                detalladoFacturasVo.SetLineaProducto(txtLineaProd.Text);
            if(!String.IsNullOrEmpty(cmbOrdenaPrimero.Text))
                detalladoFacturasVo.SetOrdenaPrimero(cmbOrdenaPrimero.Text);
            if(!String.IsNullOrEmpty(cmbOrdenaDespues.Text))
            detalladoFacturasVo.SetOrdenaDespues(cmbOrdenaDespues.Text);
            //detalladoFacturasVo.SetStatus(txtStatus.Text);

            ArrayList facturas = new ArrayList();
            //coordinatorController.HideFilterResumeVentas();
            coordinatorController.GetFacturasDetalladoReport(detalladoFacturasVo);
            
            
        }

        private void FilterResumeVentasView_Load(object sender, EventArgs e)
        {

        }
        public void SetSetup()
        {
            radioButton1.Checked = true;
        }
        public void ShowNotification(String message)
        {
            MessageBox.Show(message);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnCveDocIni_Click(object sender, EventArgs e)
        {
            coordinatorController.ShowBusquedaDocumentos();
        }

      
    }
}
