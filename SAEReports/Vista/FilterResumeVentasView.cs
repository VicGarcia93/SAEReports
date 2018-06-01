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
            detalladoFacturasVo.SetAlmacen(int.Parse(txtAlmacen.Text));
            detalladoFacturasVo.SetClienteInicial(int.Parse(txtClientesIni.Text));
            detalladoFacturasVo.SetClienteFinal(int.Parse(txtCveClienteFin.Text));
            detalladoFacturasVo.SetCveDocInicial(txtCveDocInicial.Text);
            detalladoFacturasVo.SetCveDocFinal(txtCveDocFinal.Text);
            detalladoFacturasVo.SetCveProducto(txtCveProducto.Text);
            detalladoFacturasVo.SetCveVendedorInicial(int.Parse(txtVendeIni.Text));
            detalladoFacturasVo.SetCveVendedorFinal(int.Parse(txtVendeFin.Text));
            detalladoFacturasVo.SetDescripcionProducto(txtDescrProd.Text);
            detalladoFacturasVo.SetFechaElaboracionInicial(dtpInicial.Text);
            detalladoFacturasVo.SetFechaElaboracionFinal(dtpInicial.Text);
            detalladoFacturasVo.SetFiltroContabilizado(chbContabilizado.Checked);
            detalladoFacturasVo.SetFiltroContado(chbContado.Checked);
            detalladoFacturasVo.SetFiltroCostos(chbCostos.Checked);
            detalladoFacturasVo.SetFiltroDesglose(chbDesglose.Checked);
            detalladoFacturasVo.SetFiltroGrupos(chbGrupo.Checked);
            detalladoFacturasVo.SetFiltroKits(chbKits.Checked);
            detalladoFacturasVo.SetFiltroProductos(chbProductos.Checked);
            detalladoFacturasVo.SetFiltroServicios(chbServicios.Checked);
            detalladoFacturasVo.SetGrupoProducto(int.Parse(txtGrupoProd.Text));
            detalladoFacturasVo.SetLineaProducto(txtLineaProd.Text);
            detalladoFacturasVo.SetOrdenaPrimero(cmbOrdenaPrimero.Text);
            detalladoFacturasVo.SetOrdenaDespues(cmbOrdenaDespues.Text);
            //detalladoFacturasVo.SetStatus(txtStatus.Text);

            coordinatorController.GetFacturasDetalladoReport(detalladoFacturasVo);
            
        }

      
    }
}
