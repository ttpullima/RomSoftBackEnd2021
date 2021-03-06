using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using Romsoft.GESTIONCLINICA.Entidades.FAC_DOCUMENTO_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAC_DOCUMENTO_PAGOBL
{
    public interface IFAC_DOCUMENTO_PAGOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

        IList<FAC_DOCUMENTO_PAGO> GetAllFacDocumentoPagoFilters(string c_dato);

        System.Tuple<int, string> Add2(FAC_COMPROBANTEReq entity);

    }
}
