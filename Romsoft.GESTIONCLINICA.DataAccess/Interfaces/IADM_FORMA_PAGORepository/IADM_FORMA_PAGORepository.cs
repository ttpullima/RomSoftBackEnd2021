using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.Entidades.ADM_FORMA_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_FORMA_PAGORepository
{
    public interface IADM_FORMA_PAGORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);

    }
}
