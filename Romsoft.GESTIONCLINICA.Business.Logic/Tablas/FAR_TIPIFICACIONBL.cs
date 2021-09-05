using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_TIPIFICACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPIFICACION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_TIPIFICACIONBL : Singleton<FAR_TIPIFICACIONBL>, IFAR_TIPIFICACIONBL<FAR_TIPIFICACION>
    {
        public int Add(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAllActives()
        {
            return FAR_TIPIFICACIONRepository.Instancia.GetAllActives();
        }

        public IList<FAR_TIPIFICACION> GetAllFilters(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public FAR_TIPIFICACION GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
