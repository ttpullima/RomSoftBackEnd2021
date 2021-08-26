using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAC_DOCUMENTO_PAGOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.FAC_DOCUMENTO_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class FAC_DOCUMENTO_PAGOBL : Singleton<FAC_DOCUMENTO_PAGOBL>, IFAC_DOCUMENTO_PAGOBL<FAC_DOCUMENTO_PAGOReq>
    {
        public int Add(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Add2(FAC_COMPROBANTEReq entity)
        {
            return FAC_DOCUMENTO_PAGORepository.Instancia.Add2(entity);
        }

        public int Delete(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGO> GetAllFacDocumentoPagoFilters(string c_dato)
        {
            return FAC_DOCUMENTO_PAGORepository.Instancia.GetAllFacDocumentoPagoFilters(c_dato);
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllFilters(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }
    }
}
