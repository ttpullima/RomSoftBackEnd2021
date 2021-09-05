using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_CLASEBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_CLASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_CLASEBL : Singleton<FAR_CLASEBL>, IFAR_CLASEBL<FAR_CLASE>
    {
        public int Add(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAllActives()
        {
            return FAR_CLASERepository.Instancia.GetAllActives();
        }

        public IList<FAR_CLASE> GetAllFilters(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public FAR_CLASE GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }
    }
}
