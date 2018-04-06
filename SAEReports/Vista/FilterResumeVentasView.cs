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

      
    }
}
