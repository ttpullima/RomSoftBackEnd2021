using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_FORMA_PAGORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_FORMA_PAGO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_FORMA_PAGORepository : Singleton<ADM_FORMA_PAGORepository>, IADM_FORMA_PAGORepository<ADM_FORMA_PAGORes>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion


        public int Add(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_FORMA_PAGORes> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_FORMA_PAGORes> GetAllActives()
        {
            List<ADM_FORMA_PAGORes> atenciones = new List<ADM_FORMA_PAGORes>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_FORMA_PAGO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@c_dato", DbType.String, t_dato.ToUpper());

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_FORMA_PAGORes
                        {
                            id_forma_pago = lector.IsDBNull(lector.GetOrdinal("id_forma_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_forma_pago")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_FORMA_PAGORes> GetAllFilters(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }

        

        public IList<ADM_FORMA_PAGORes> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_FORMA_PAGORes entity)
        {
            throw new NotImplementedException();
        }
    }
}
