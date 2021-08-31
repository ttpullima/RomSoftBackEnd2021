using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using Romsoft.GESTIONCLINICA.Entidades.CVN_TARIFARIO_SEGUS;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_TARIFARIO_SEGUSBL
{
    public interface ICVN_TARIFARIO_SEGUSBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

        IList<CVN_TARIFARIO_SEGUS_PRICE> GetPrice(CVN_TARIFARIO_SEGUS_PRICEReq entity);

    }
}
