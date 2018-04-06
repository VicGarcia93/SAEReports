using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAEReports.Controlador;

namespace SAEReports.Vista
{
    public partial class VentasView : Form
    {
        CoordinatorController coordinatorController;
        public VentasView()
        {
            InitializeComponent();
        }
        public void setController(CoordinatorController coordinatorController)
        {
            this.coordinatorController = coordinatorController;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            coordinatorController.ShowFilterResumeVentas();
        }
    }
}
