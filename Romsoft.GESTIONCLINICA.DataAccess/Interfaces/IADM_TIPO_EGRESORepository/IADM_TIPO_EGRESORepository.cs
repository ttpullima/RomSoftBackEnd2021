﻿using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_EGRESORepository
{

    public interface IADM_TIPO_EGRESORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
