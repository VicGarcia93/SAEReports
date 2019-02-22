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
    public partial class BusquedaDocumentos : Form
    {
        CoordinatorController controller;
        private DataTable dtBuscaFacturas;
        List<DetalladoFacturasVO> dataFacturas;
        public BusquedaDocumentos()
        {
            InitializeComponent();
        }
        public void SetController(CoordinatorController controller)
        {
            this.controller = controller;
        }
        public void SetDataArray(List<DetalladoFacturasVO> data)
        {
            this.dataFacturas = data;
        }
        public void ShowData()
        {
            dtBuscaFacturas = new DataTable();
            dtBuscaFacturas.Columns.Add("Clave");
            dtBuscaFacturas.Columns.Add("Cliente");
            dtBuscaFacturas.Columns.Add("Fecha");
            dtBuscaFacturas.Columns.Add("Importe");
            dtBuscaFacturas.Columns.Add("Almacén");

            dgvBuscarDoc.AutoGenerateColumns = true;
            dgvBuscarDoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Console.WriteLine("Inicia el ciclo");
            for (int i = 0; i < dataFacturas.Count; i++)
            {
                DataRow fila = dtBuscaFacturas.NewRow();
                fila[0] = dataFacturas[i].GetCveDocInicial();
                fila[1] = dataFacturas[i].GetClienteInicial();
                fila[2] = dataFacturas[i].GetFechaElaboracionInicial();
                fila[3] = dataFacturas[i].GetImporte();            
                fila[4] = dataFacturas[i].GetAlmacen();

                dtBuscaFacturas.Rows.Add(fila);
                Console.WriteLine(fila[0]);
            }
            dgvBuscarDoc.DataSource = dtBuscaFacturas;
        }

        private void LimpiarDatos()
        {
            txtBuscarDoc.Text = "";
            dgvBuscarDoc.DataSource = new DataTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarDoc_Click(object sender, EventArgs e)
        {
            DetalladoFacturasVO facturas = new DetalladoFacturasVO();

            if (txtBuscarDoc.Visible)
            {
                if (!String.IsNullOrEmpty(txtBuscarDoc.Text))
                {

                  controller.ConsultaFacturas(cmbBuscarDoc.SelectedItem.ToString(), txtBuscarDoc.Text);
                }
            }
            else
            {
                string fecha = dtpFecha.Text;
                fecha = fecha.Substring(3, 2) + "/" + fecha.Substring(0, 2) + "/" + fecha.Substring(6, 4);
                controller.ConsultaFacturas("Fecha de elaboración", fecha);
            }
            

        }

        private void btnCerrarBusquedaDocumentos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBuscarDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarDoc.SelectedIndex == 3)
            {
                dtpFecha.Visible = true;
                txtBuscarDoc.Visible = false;
            }
            else
            {
                dtpFecha.Visible = false;
                txtBuscarDoc.Visible = true;
            }

        }

        private void dgvBuscarDoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string claveFactura = dgvBuscarDoc.Rows[e.RowIndex].Cells[0].Value.ToString();
            //controller.SetClaveDocInicial(claveFactura);
            controller.SetCveDocumento(claveFactura);
            LimpiarDatos();
            this.Close();
        }
        
       
    }
}
