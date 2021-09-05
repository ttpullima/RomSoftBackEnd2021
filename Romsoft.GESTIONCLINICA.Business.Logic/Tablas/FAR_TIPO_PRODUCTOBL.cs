using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_TIPO_PRODUCTOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPO_PRODUCTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_TIPO_PRODUCTOBL : Singleton<FAR_TIPO_PRODUCTOBL>, IFAR_TIPO_PRODUCTOBL<FAR_TIPO_PRODUCTO>
    {
        public int Add(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllActives()
        {
            return FAR_TIPO_PRODUCTORepository.Instancia.GetAllActives();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllFilters(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public FAR_TIPO_PRODUCTO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
