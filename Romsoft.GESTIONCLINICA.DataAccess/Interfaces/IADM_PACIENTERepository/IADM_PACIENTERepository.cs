using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using System;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PACIENTERepository
{

    public interface IADM_PACIENTERepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);

        IList<ADM_PACIENTEATENCIONRes> GetAllPacienteAtencionFilters(string t_dato, string tipo_dato);

        System.Tuple<int, string> Add2(T entity);

    }
}
