using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_PRODUCTOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAR_PRODUCTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAR_PRODUCTOBL : Singleton<FAR_PRODUCTOBL>, IFAR_PRODUCTOBL<FAR_PRODUCTOReq>
    {
        public int Add(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Add2(FAR_PRODUCTOReq entity)
        {
            return FAR_PRODUCTORepository.Instancia.Add2(entity);
        }

        public int Delete(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllFilters(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOByIdRes> GetProductoById(int idproducto)
        {
            return FAR_PRODUCTORepository.Instancia.GetProductoById(idproducto);
        }

        public int Update(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Update2(FAR_PRODUCTOReq entity)
        {
            return FAR_PRODUCTORepository.Instancia.Update2(entity);
        }
    }
}
