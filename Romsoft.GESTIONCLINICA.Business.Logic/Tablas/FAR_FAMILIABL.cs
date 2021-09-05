using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_FAMILIABL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_FAMILIA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_FAMILIABL : Singleton<FAR_FAMILIABL>, IFAR_FAMILIABL<FAR_FAMILIA>
    {
        public int Add(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAllActives()
        {
            return FAR_FAMILIARepository.Instancia.GetAllActives();
        }

        public IList<FAR_FAMILIA> GetAllFilters(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public FAR_FAMILIA GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }
    }
}
