using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_TIPO_PRODUCTORepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPO_PRODUCTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_TIPO_PRODUCTORepository : Singleton<FAR_TIPO_PRODUCTORepository>, IFAR_TIPO_PRODUCTORepository<FAR_TIPO_PRODUCTO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllActives()
        {
            List<FAR_TIPO_PRODUCTO> listtipoproducto = new List<FAR_TIPO_PRODUCTO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_TIPO_PRODUCTO_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listtipoproducto.Add(new FAR_TIPO_PRODUCTO
                        {
                            id_tipo_producto = lector.IsDBNull(lector.GetOrdinal("id_tipo_producto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_producto")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return listtipoproducto;
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllFilters(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_TIPO_PRODUCTO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAR_TIPO_PRODUCTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
