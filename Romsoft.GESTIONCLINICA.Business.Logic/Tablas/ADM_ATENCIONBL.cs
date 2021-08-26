using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ATENCIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using System;
using System.Collections.Generic;
namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_ATENCIONBL : Singleton<ADM_ATENCIONBL>, IADM_ATENCIONBL<ADM_ATENCION>
    {
        public int Add(ADM_ATENCION entity)
        {
            //return ADM_ATENCIONRepository.Instancia.Add(entity);
            throw new NotImplementedException();
        }

        public Tuple<int,string> Add2(ADM_ATENCION entity)
        {
            return ADM_ATENCIONRepository.Instancia.Add2(entity);
        }

        public int Delete(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllFilters(ADM_ATENCION entity)
        {
            return ADM_ATENCIONRepository.Instancia.GetAllFilters(entity);
        }

        public IList<ADM_ATENCION> GetAllPaciente(int idPaciente)
        {
            return ADM_ATENCIONRepository.Instancia.GetAllPaciente(idPaciente);
        }

        public IList<ADM_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente)
        {
            return ADM_ATENCIONRepository.Instancia.GetAtencionAllFilters(idPaciente);
        }

        public IList<ADM_ATENCION_PendingResponse> GetAtencionPending(int id_atencion, string c_tipo_pendiente, string c_tipo_facturacion, string c_idioma, int id_usuario)
        {
            return ADM_ATENCIONRepository.Instancia.GetAtencionPending(id_atencion, c_tipo_pendiente, c_tipo_facturacion, c_idioma, id_usuario);
        }

        public IList<ADM_ATENCION> GetById(int idAtencion)
        {
            return ADM_ATENCIONRepository.Instancia.GetById(idAtencion);
        }

        public int Update(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Update2(ADM_ATENCION entity)
        {
            return ADM_ATENCIONRepository.Instancia.Update2(entity);
        }
    }
}
