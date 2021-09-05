using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_CLASERepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_CLASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_CLASERepository : Singleton<FAR_CLASERepository>, IFAR_CLASERepository<FAR_CLASE>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAllActives()
        {
            List<FAR_CLASE> listclase = new List<FAR_CLASE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_CLASE_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listclase.Add(new FAR_CLASE
                        {
                            id_clase = lector.IsDBNull(lector.GetOrdinal("id_clase")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_clase")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return listclase;
        }

        public IList<FAR_CLASE> GetAllFilters(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_CLASE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_CLASE entity)
        {
            throw new NotImplementedException();
        }
    }
}
