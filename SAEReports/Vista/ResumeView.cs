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
    public partial class ResumeView : Form
    {
        CoordinatorController coordinatorController;
        public ResumeView()
        {
            InitializeComponent();
        }
        public void setController(CoordinatorController coordinatorController)
        {
            this.coordinatorController = coordinatorController;
        }
    }
}
