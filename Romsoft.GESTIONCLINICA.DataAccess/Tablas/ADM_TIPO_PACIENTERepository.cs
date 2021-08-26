using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_TIPO_PACIENTERepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_PACIENTE;
using System;
using System.Collections.Generic;
using System.Data;
namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_TIPO_PACIENTERepository : Singleton<ADM_TIPO_PACIENTERepository>, IADM_TIPO_PACIENTEDTORepository<ADM_TIPO_PACIENTE>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);


        #endregion

        public int Add(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAllActives()
        {
            List<ADM_TIPO_PACIENTE> tipopaciente = new List<ADM_TIPO_PACIENTE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_TIPO_PACIENTE_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        tipopaciente.Add(new ADM_TIPO_PACIENTE
                        {
                            id_tipo_paciente = lector.IsDBNull(lector.GetOrdinal("id_tipo_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_paciente")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                            id_moneda= lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            n_copago_variable= lector.IsDBNull(lector.GetOrdinal("n_copago_variable")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable")),
                            n_copago_variable_far = lector.IsDBNull(lector.GetOrdinal("n_copago_variable_far")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable_far")),
                            f_siteds = lector.IsDBNull(lector.GetOrdinal("f_siteds")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_siteds")),
                        });
                    }
                }
            }

            return tipopaciente;
        }

        public IList<ADM_TIPO_PACIENTE> GetAllFilters(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_TIPO_PACIENTE> GetById(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_TIPO_PACIENTE entity)
        {
            throw new NotImplementedException();
        }
    }
}
