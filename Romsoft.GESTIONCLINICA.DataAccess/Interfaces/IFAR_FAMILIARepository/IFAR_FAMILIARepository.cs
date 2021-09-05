using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_FAMILIARepository
{
    public interface IFAR_FAMILIARepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
