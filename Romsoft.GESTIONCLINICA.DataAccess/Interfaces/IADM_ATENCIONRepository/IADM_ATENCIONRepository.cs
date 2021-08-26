using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ATENCIONRepository
{
    public interface IADM_ATENCIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllPaciente(int idPaciente);
        IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente);
        System.Tuple<int, string> Add2(T entity);

        System.Tuple<int, string> Update2(T entity);

        IList<ADM_ATENCION_PendingResponse> GetAtencionPending(int id_atencion, string c_tipo_pendiente, string c_tipo_facturacion, string c_idioma, int id_usuario);

        //
    }

}
