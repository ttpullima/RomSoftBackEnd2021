using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICON_CONTACTOBL
{
    public interface ICON_CONTACTOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string rolNombre);

        IList<T> GetAllActives();
    }
}
