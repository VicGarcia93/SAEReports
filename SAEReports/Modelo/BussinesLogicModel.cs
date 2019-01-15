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
            String sqlFacturasDetalle = @"select fdet.cant,fdet.cve_art,fdet.num_par,fdet.cost,fdet.prec,fdet.impu4, 
                                        (fdet.cant * fdet.cost),(fdet.cant * fdet.prec)
                                        from par_factf03 fdet";
            if (detalladoFacturas.GetCveDocInicial() == null)
            {
                resumenFacturas = detalladoFacturasDao.BuscarFacturas(detalladoFacturas);
                return 1;
            }
            else
            {
                if (detalladoFacturas.GetCveDocFinal() == null)
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}
