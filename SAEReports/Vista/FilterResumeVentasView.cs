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

            //Datos del objeto DetalladoFacturasVO
            if(!String.IsNullOrEmpty(txtAlmacen.Text))
                detalladoFacturasVo.SetAlmacen(int.Parse(txtAlmacen.Text));
            if(!String.IsNullOrEmpty(txtClientesIni.Text))
                detalladoFacturasVo.SetClienteInicial(txtClientesIni.Text);
            if(!String.IsNullOrEmpty(txtCveClienteFin.Text))
                detalladoFacturasVo.SetClienteFinal(txtCveClienteFin.Text);
            if(!String.IsNullOrEmpty(txtCveDocInicial.Text))
                detalladoFacturasVo.SetCveDocInicial(txtCveDocInicial.Text);
            if(!String.IsNullOrEmpty(txtCveDocFinal.Text))
                detalladoFacturasVo.SetCveDocFinal(txtCveDocFinal.Text);
            if(!String.IsNullOrEmpty(txtCveProducto.Text))
                detalladoFacturasVo.SetCveProducto(txtCveProducto.Text);
            if(!String.IsNullOrEmpty(txtVendeIni.Text))
                detalladoFacturasVo.SetCveVendedorInicial(txtVendeIni.Text);
            if(!String.IsNullOrEmpty(txtVendeFin.Text))
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

      
    }
}
