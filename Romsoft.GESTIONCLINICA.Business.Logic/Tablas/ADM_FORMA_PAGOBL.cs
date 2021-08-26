using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_FORMA_PAGOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_FORMA_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_FORMA_PAGOBL : Singleton<ADM_FORMA_PAGOBL>, IADM_FORMA_PAGOBL<ADM_FORMA_PAGORes>
    {
        public int Add(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_FORMA_PAGORes> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_FORMA_PAGORes> GetAllActives()
        {
            return ADM_FORMA_PAGORepository.Instancia.GetAllActives();
        }

        public IList<ADM_FORMA_PAGORes> GetAllFilters(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }


        public IList<ADM_FORMA_PAGORes> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }
    }
}
