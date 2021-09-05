using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_TIPIFICACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPIFICACION;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_TIPIFICACIONRepository : Singleton<FAR_TIPIFICACIONRepository>, IFAR_TIPIFICACIONRepository<FAR_TIPIFICACION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion


        public int Add(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAllActives()
        {
            List<FAR_TIPIFICACION> listTipificacion = new List<FAR_TIPIFICACION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_TIPIFICACION_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listTipificacion.Add(new FAR_TIPIFICACION
                        {
                            id_tipificacion = lector.IsDBNull(lector.GetOrdinal("id_tipificacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipificacion")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return listTipificacion;
        }

        public IList<FAR_TIPIFICACION> GetAllFilters(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPIFICACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_TIPIFICACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
