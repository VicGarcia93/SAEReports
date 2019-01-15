using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEReports.Controlador;
using System.Collections;
using SAEReports.Modelo;

namespace SAEReports.Vista
{
    public partial class FilterFacturasDetallado : Form
    {
        CoordinatorController coordinatorController;
        List<DetalladoFacturasVO> dataArray;
        public FilterFacturasDetallado()
        {
            InitializeComponent();
        }
        public void SetController(CoordinatorController controller)
        {
            this.coordinatorController = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void SetDataArray(List<DetalladoFacturasVO> dataArray)
        {
            this.dataArray = dataArray;
        }

        public void ShowData()
        {
            Console.WriteLine("Imprimiendo resultados...");
            Console.WriteLine(dataArray[0].GetCveDocInicial());
            Console.WriteLine(dataArray[0].GetClienteInicial());
            Console.WriteLine(dataArray[0].GetStatus());
            Console.WriteLine(dataArray[0].GetFechaElaboracionFinal());
            Console.WriteLine(dataArray[0].GetCveVendedorInicial());
            Console.WriteLine(dataArray[0].GetCveDocSiguiente());
            Console.WriteLine(dataArray[0].GetAlmacen());
            dataGridView1.AutoGenerateColumns = true;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Clave");
            dataTable.Columns.Add("Cliente");
            dataTable.Columns.Add("Estatus");
            dataTable.Columns.Add("Fecha");
            dataTable.Columns.Add("Vendedor");
            dataTable.Columns.Add("Doc. anterior");
            dataTable.Columns.Add("Almacén");

                           

            Console.WriteLine("Inicia el ciclo");
            for (int i = 0; i < dataArray.Count; i++)
            {
                DataRow fila = dataTable.NewRow();
                fila[0] = dataArray[i].GetCveDocInicial();
                fila[1] = dataArray[i].GetClienteInicial();
                fila[2] = dataArray[i].GetStatus();
                fila[3] = dataArray[i].GetFechaElaboracionInicial();
                fila[4] = dataArray[i].GetCveVendedorInicial();
                fila[5] = dataArray[i].GetCveDocSiguiente();
                fila[6] = dataArray[i].GetAlmacen();

                dataTable.Rows.Add(fila);
                Console.WriteLine(fila[0]);
            }
           
               dataGridView1.DataSource = dataTable;
              
            
        }

    }
}
