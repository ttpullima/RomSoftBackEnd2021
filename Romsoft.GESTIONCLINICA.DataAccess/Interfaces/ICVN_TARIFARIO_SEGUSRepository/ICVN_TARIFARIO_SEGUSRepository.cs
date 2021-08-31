using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.Entidades.CVN_TARIFARIO_SEGUS;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_TARIFARIO_SEGUSRepository
{
    public interface ICVN_TARIFARIO_SEGUSRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);

        IList<CVN_TARIFARIO_SEGUS_PRICE> GetPrice(CVN_TARIFARIO_SEGUS_PRICEReq entity);

    }
}
