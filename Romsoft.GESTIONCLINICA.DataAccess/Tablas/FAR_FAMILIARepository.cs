using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_FAMILIARepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_FAMILIA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_FAMILIARepository : Singleton<FAR_FAMILIARepository>, IFAR_FAMILIARepository<FAR_FAMILIA>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        public int Add(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAllActives()
        {
            List<FAR_FAMILIA> listFamilia = new List<FAR_FAMILIA>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_FAMILIA_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listFamilia.Add(new FAR_FAMILIA
                        {
                            id_familia = lector.IsDBNull(lector.GetOrdinal("id_familia")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_familia")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return listFamilia;
        }

        public IList<FAR_FAMILIA> GetAllFilters(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_FAMILIA> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_FAMILIA entity)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
