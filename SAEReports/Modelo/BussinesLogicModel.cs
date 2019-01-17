using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAEReports.Modelo
{
    public class BussinesLogicModel
    {
        DetalladoFacturasDAO detalladoFacturasDao;
        VentasDAO ventasDao;
        private List<DetalladoFacturasVO> resumenFacturas;
        public BussinesLogicModel()
        {

        }
        public List<DetalladoFacturasVO> GetResumenFacturas()
        {
            return resumenFacturas;
        }

        public int DetalladoFacturas(DetalladoFacturasVO detalladoFacturas)
        {
            detalladoFacturasDao = new DetalladoFacturasDAO();
            ventasDao = new VentasDAO();
            String sqlFacturasDetalle = @"select fdet.cant,fdet.cve_art,fdet.num_par,fdet.cost,fdet.prec,fdet.impu4, 
                                        (fdet.cant * fdet.cost),(fdet.cant * fdet.prec)
                                        from par_factf03 fdet";
            String sqlFacturasResumen = @"SELECT fac.cve_doc,fac.cve_clpv,fac.status,fac.fecha_doc,fac.cve_vend,fac.doc_ant,fac.num_alma,fac.importe,fac.can_tot,fac.imp_tot4 
                                        FROM factf03 fac ";
            List<String> filtros = new List<string>(); //Lista que contiene los filtros seleccionados en FilterResumeVentasView
            int codError = 1; //1.Correcto 2.Error

            //*******Evaluación de filtro de clave de documento*******
            
            if (!String.IsNullOrEmpty(detalladoFacturas.GetCveDocInicial())) //Clave inicial no vacia
            { 
                if (!String.IsNullOrEmpty(detalladoFacturas.GetCveDocFinal())) //Clave final no vacia
                {
                    if (ventasDao.validaCveDoc(detalladoFacturas.GetCveDocInicial()))
                    {
                        if (ventasDao.validaCveDoc(detalladoFacturas.GetCveDocFinal()))
                        {
                            filtros.Add("fac.cve_doc BETWEEN '" + detalladoFacturas.GetCveDocInicial()
                                           + "' AND '" + detalladoFacturas.GetCveDocFinal() + "'");
                        }
                        else
                        {
                            codError = 3; //La clave final no existe
                        }
                    }
                    else
                        codError = 2; //La clave inicial no existe
                    
                }
                else //Clave final vacia
                {
                    if (ventasDao.validaCveDoc(detalladoFacturas.GetCveDocInicial()))
                    {
                        filtros.Add("fac03.cve_doc BETWEEN '" + detalladoFacturas.GetCveDocInicial() + @"' AND  
                                            (SELECT factf03.cve_doc FROM factf03 ORDER BY factf03.cve_doc desc ROWS 1)");
                    }
                    else
                        codError = 2; //La clave inicial no existe;
                    
                }
                
            }
            else //Clave inicial vacia
            {
                if(!String.IsNullOrEmpty(detalladoFacturas.GetCveDocFinal()))
                {
                    if (ventasDao.validaCveDoc(detalladoFacturas.GetCveDocFinal()))
                    {
                        filtros.Add("fac.cve_doc BETWEEN (SELECT factf03.cve_doc FROM factf03 ORDER BY factf03.cve_doc asc ROWS 1)" + @" AND  
                                             '" + detalladoFacturas.GetCveDocFinal() + "'");
                    }
                    else
                        codError = 3; // La clave final no existe
                    
                }
            }
            //*******Evaluación de filtro de clave de cliente*******

            if (!String.IsNullOrEmpty(detalladoFacturas.GetClienteInicial())) //Clave inicial vacia?
            {
               if (!String.IsNullOrEmpty(detalladoFacturas.GetClienteFinal())) //Clave final vacia?
                {
                    if (ventasDao.validaCveCliente(detalladoFacturas.GetClienteInicial())) 
                    {
                        if (ventasDao.validaCveCliente(detalladoFacturas.GetClienteFinal()))
                        {
                            filtros.Add("fac.cve_clpv BETWEEN '" + detalladoFacturas.GetClienteInicial()
                                           + "' AND '" + detalladoFacturas.GetClienteFinal() + "'");
                        }
                        else
                        {
                            codError = 5; //La clave final del cliente no existe
                        }
                    }
                    else
                        codError = 4;//La clave inicial del cliente no existe
                    
                }
                else //Clave final vacia
                {
                    if (ventasDao.validaCveCliente(detalladoFacturas.GetClienteInicial()))
                    {
                        filtros.Add("fac.cve_clpv BETWEEN '" + detalladoFacturas.GetClienteInicial() + @"' AND  
                                            (SELECT factf03.cve_clpv FROM factf03 ORDER BY factf03.cve_clpv desc ROWS 1)");
                    }
                    else
                        codError = 4;//La clave inicial del cliente no existe
                   
                }
            }
            else //Clave inicial vacia
            {
                if (!String.IsNullOrEmpty(detalladoFacturas.GetClienteFinal()))
                {
                    if (ventasDao.validaCveCliente(detalladoFacturas.GetClienteFinal()))
                    {
                        filtros.Add("fac.cve_clpv BETWEEN (SELECT factf03.cve_clpv FROM factf03 ORDER BY factf03.cve_clpv asc ROWS 1)" + @" AND  
                                             '" + detalladoFacturas.GetClienteFinal() + "'");
                    }
                    else
                        codError = 5;//La clave final del cliente no existe
                   
                }
            }
            //*******Evaluación de filtro de vendedor*******
            if (!String.IsNullOrEmpty(detalladoFacturas.GetCveVendedorInicial())) //Clave inicial no vacia
            {
                if (!String.IsNullOrEmpty(detalladoFacturas.GetCveVendedorFinal())) //Clave final no vacia
                {
                    if (ventasDao.validaCveVendedor(detalladoFacturas.GetCveVendedorInicial()))
                    {
                        if (ventasDao.validaCveVendedor(detalladoFacturas.GetCveVendedorFinal()))
                        {
                            filtros.Add("fac.cve_vend BETWEEN '    " + detalladoFacturas.GetCveVendedorInicial()
                                          + "' AND '    " + detalladoFacturas.GetCveVendedorFinal() + "'");
                        }
                        else
                            codError = 7; //La clave final del vendedor no existe

                    }
                    else
                        codError = 6; //La clave inicial del vendedor no existe
                    
                }
                else //Clave final vacia
                {
                    if (ventasDao.validaCveVendedor(detalladoFacturas.GetCveVendedorInicial()))
                    {
                        filtros.Add("fac.cve_vend BETWEEN '    " + detalladoFacturas.GetCveVendedorInicial() + @"' AND  
                                            (SELECT factf03.cve_vend FROM factf03 ORDER BY factf03.cve_vend desc ROWS 1)");
                    }
                    else
                        codError = 6; //La clave inicial del vendedor no existe
                    
                }
            }
            else //Clave inicial vacia
            {
                if (!String.IsNullOrEmpty(detalladoFacturas.GetCveVendedorFinal()))
                {
                    if (ventasDao.validaCveVendedor(detalladoFacturas.GetCveVendedorFinal()))
                    {
                        filtros.Add("fac.cve_vend BETWEEN (SELECT factf03.cve_vend FROM factf03 ORDER BY factf03.cve_vend asc ROWS 1)" + @" AND  
                                             '    " + detalladoFacturas.GetCveVendedorFinal() + "'");
                    }
                    else
                        codError = 7; //La clave final del vendedor no existe
                    
                }
            }
            //*******Evaluación de filtro de almacén*******

            if (detalladoFacturas.GetAlmacen() > 0)
            {
                if (ventasDao.ValidaAlmacen(detalladoFacturas.GetAlmacen()) || detalladoFacturas.GetAlmacen() == 1)
                {
                    filtros.Add("Cve_alm = " + detalladoFacturas.GetAlmacen());
                }
                else
                    codError = 8;
                
            }
            else if(detalladoFacturas.GetAlmacen() == -1)
                codError = 8;

            if (codError == 1)
            {
                if (filtros.Count > 0)
                {
                    sqlFacturasResumen += " WHERE ";
                    for (int i = 0; i < filtros.Count; i++)
                    {
                        if (i > 0)
                            sqlFacturasResumen += " AND ";

                        sqlFacturasResumen += filtros[i];
                        
                    }
                }
                resumenFacturas = ventasDao.BuscarFacturas(sqlFacturasResumen);
                Console.WriteLine("Elementos: {0}",resumenFacturas.Count());
                if (resumenFacturas.Count() < 1)
                {
                    codError = 9;
                }
                
            }
            Console.WriteLine("Cadena SQL: {0}", sqlFacturasResumen);
            Console.WriteLine("Código: {0}", codError);
            return codError;
        }
    }
}
