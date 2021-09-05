using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.FAR_GENERICORepository
{
    public interface IFAR_GENERICORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
