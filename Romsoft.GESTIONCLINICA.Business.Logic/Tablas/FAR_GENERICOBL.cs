using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_GENERICOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_GENERICO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_GENERICOBL : Singleton<FAR_GENERICOBL>, IFAR_GENERICOBL<FAR_GENERICO>
    {
        public int Add(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAllActives()
        {
            return FAR_GENERICORepository.Instancia.GetAllActives();
        }

        public IList<FAR_GENERICO> GetAllFilters(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public FAR_GENERICO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }
    }
}
