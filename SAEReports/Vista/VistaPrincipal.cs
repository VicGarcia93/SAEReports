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
    public partial class VistaPrincipal : Form
    {
        CoordinatorController coordinatorController;
        public VistaPrincipal()
        {
            InitializeComponent();
            
        }
        public void setController(CoordinatorController coordinatorController)
        {
            this.coordinatorController = coordinatorController; 
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            coordinatorController.showResumeView();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            coordinatorController.showVentasView();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            coordinatorController.ExitApplication();
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            coordinatorController.ShowInventariosView();
        }
    }
}
