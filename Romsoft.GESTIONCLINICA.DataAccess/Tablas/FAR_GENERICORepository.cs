using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.FAR_GENERICORepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_GENERICO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_GENERICORepository : Singleton<FAR_GENERICORepository>, IFAR_GENERICORepository<FAR_GENERICO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAllActives()
        {
            List<FAR_GENERICO> listGenerico = new List<FAR_GENERICO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_GENERICO_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listGenerico.Add(new FAR_GENERICO
                        {
                            id_generico = lector.IsDBNull(lector.GetOrdinal("id_generico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_generico")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return listGenerico;
        }

        public IList<FAR_GENERICO> GetAllFilters(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_GENERICO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_GENERICO entity)
        {
            throw new NotImplementedException();
        }
    }
}
