using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.Entidades.FAR_PRODUCTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_PRODUCTORepository
{
    interface IFAR_PRODUCTORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        IList<FAR_PRODUCTOByIdRes> GetProductoById(int idproducto);
        System.Tuple<int, string> Add2(T entity);
        System.Tuple<int, string> Update2(T entity);
    }
}
