using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESPECIALIDAD;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ESPECIALIDADRepository
{

    public interface IADM_ESPECIALIDADRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        
    }
}
