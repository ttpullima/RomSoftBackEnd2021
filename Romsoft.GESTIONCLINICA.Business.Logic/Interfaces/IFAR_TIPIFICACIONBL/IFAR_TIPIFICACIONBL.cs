using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IFAR_TIPIFICACIONBL
{
    public interface IFAR_TIPIFICACIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string rolNombre);

        IList<T> GetAllActives();
    }
}
