using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using System;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_PACIENTEBL
{

    public interface IADM_PACIENTEBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

        IList<ADM_PACIENTEATENCIONRes> GetAllPacienteAtencionFilters(string t_dato, string tipo_dato);

        System.Tuple<int, string> Add2(T entity);
       


    }

}
