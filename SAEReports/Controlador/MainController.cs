using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAEReports.Vista;
using SAEReports.Modelo;
using System.Windows.Forms;



namespace SAEReports.Controlador
{
    class MainController
    {
       static VistaPrincipal mainView;
       static ResumeView resumeView;
       static VentasView ventasView;
       static FilterResumeVentasView filterResumeVentas;
       static FilterFacturasDetallado filterFacturasDetallado;
       static InventariosView inventariosView;

       static BussinesLogicModel bussinesLogicModel;

       static CoordinatorController coordinatorController;

        public MainController()
        {
           // Iniciar();
        }

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainController mainController = new MainController();
            mainController.Iniciar();
        }
        public void Iniciar()
        {
            mainView = new VistaPrincipal();
            resumeView = new ResumeView();
            ventasView = new VentasView();
            filterResumeVentas = new FilterResumeVentasView();
            filterFacturasDetallado = new FilterFacturasDetallado();
            inventariosView = new InventariosView();
            

            bussinesLogicModel = new BussinesLogicModel();

            coordinatorController = new CoordinatorController();

            mainView.setController(coordinatorController);
            resumeView.setController(coordinatorController);
            ventasView.setController(coordinatorController);
            filterResumeVentas.SetController(coordinatorController);

            coordinatorController.setVistaPrincipal(mainView);
            coordinatorController.setResumeView(resumeView);
            coordinatorController.setVentasView(ventasView);
            coordinatorController.SetFilterResumeVentas(filterResumeVentas);
            coordinatorController.SetFilterFacturasDetallado(filterFacturasDetallado);
            coordinatorController.setBussinesLogicModel(bussinesLogicModel);
            coordinatorController.SetInventariosView(inventariosView);

            coordinatorController.showResumeView();
            mainView.ShowDialog();

           
            
            

        }
      
    }
}
