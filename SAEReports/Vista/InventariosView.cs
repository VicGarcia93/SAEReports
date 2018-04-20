using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAEReports.Vista
{
    public partial class InventariosView : Form
    {
        public InventariosView()
        {
            InitializeComponent();
        }

        private void InventariosView_Load(object sender, EventArgs e)
        {
            lblInventariosServicios.Text = Src.Strings.lblInventariosInv;
            lblMovimientosInventarios.Text = Src.Strings.lblInventariosMov;
            lblMultialmacen.Text = Src.Strings.lblInventariosMul;
        }
    }
}
