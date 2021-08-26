using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using Romsoft.GESTIONCLINICA.Entidades.ADM_FORMA_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_FORMA_PAGOBL
{
    public interface IADM_FORMA_PAGOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);


    }
}
