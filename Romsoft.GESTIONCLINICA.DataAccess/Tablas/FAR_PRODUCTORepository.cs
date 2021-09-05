using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAR_PRODUCTORepository;
using Romsoft.GESTIONCLINICA.Entidades.FAR_PRODUCTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAR_PRODUCTORepository : Singleton<FAR_PRODUCTORepository>, IFAR_PRODUCTORepository<FAR_PRODUCTOReq>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Add2(FAR_PRODUCTOReq entity)
        {
            int id;
            string mensaje = "";

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_PRODUCTO_Insert")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@t_descripcion", DbType.String, entity.t_descripcion);
                _database.AddInParameter(comando, "@t_presentacion", DbType.String, entity.t_presentacion);
                _database.AddInParameter(comando, "@t_rutaimagen", DbType.String, entity.t_rutaimagen);
                _database.AddInParameter(comando, "@id_tipo_producto", DbType.Int32, entity.id_tipo_producto);
                _database.AddInParameter(comando, "@id_clase", DbType.Int32, entity.id_clase);
                _database.AddInParameter(comando, "@id_generico", DbType.Int32, entity.id_generico);
                _database.AddInParameter(comando, "@id_familia", DbType.Int32, entity.id_familia);
                _database.AddInParameter(comando, "@id_tipificacion", DbType.Int32, entity.id_tipificacion);
                _database.AddInParameter(comando, "@c_gtin", DbType.String, entity.c_gtin);
                _database.AddInParameter(comando, "@c_unspsc", DbType.String, entity.c_unspsc);
                _database.AddInParameter(comando, "@n_stockmin", DbType.Decimal, entity.n_stockmin);
                _database.AddInParameter(comando, "@n_stockmax", DbType.Decimal, entity.n_stockmax);
                _database.AddInParameter(comando, "@n_pcosto", DbType.Decimal, entity.n_pcosto);
                _database.AddInParameter(comando, "@n_pvf", DbType.Decimal, entity.n_pvf);
                _database.AddInParameter(comando, "@n_utilidad", DbType.Decimal, entity.n_utilidad);
                _database.AddInParameter(comando, "@n_pvs", DbType.Decimal, entity.n_pvs);
                _database.AddInParameter(comando, "@n_plista", DbType.Decimal, entity.n_plista);
                _database.AddInParameter(comando, "@f_inafecto", DbType.Int32, entity.f_inafecto);
                _database.AddInParameter(comando, "@id_consignacion", DbType.Int32, entity.id_consignacion);
                _database.AddInParameter(comando, "@id_laboratorio", DbType.Int32, entity.id_laboratorio);
                _database.AddInParameter(comando, "@id_proveedor", DbType.Int32, entity.id_proveedor);
                _database.AddInParameter(comando, "@n_dscto_1", DbType.Decimal, entity.n_dscto_1);
                _database.AddInParameter(comando, "@n_dscto_2", DbType.Decimal, entity.n_dscto_2);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@n_valorizado", DbType.Int32, entity.n_valorizado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_user_registro);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.d_fecha_registro);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.AddOutParameter(comando, "@Response_t", DbType.String, 100);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
                mensaje = Convert.ToString(_database.GetParameterValue(comando, "@Response_t"));
            }

            return Tuple.Create(id, mensaje);
        }

        public int Delete(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllFilters(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOReq> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<FAR_PRODUCTOByIdRes> GetProductoById(int idproducto)
        {
            List<FAR_PRODUCTOByIdRes> listProducto = new List<FAR_PRODUCTOByIdRes>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_PRODUCTO_GetById")))
            {
                _database.AddInParameter(comando, "@id_producto", DbType.Int32, idproducto);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        listProducto.Add(new FAR_PRODUCTOByIdRes
                        {

                            id_producto = lector.IsDBNull(lector.GetOrdinal("id_producto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                            t_presentacion = lector.IsDBNull(lector.GetOrdinal("t_presentacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_presentacion")),
                            t_rutaimagen = lector.IsDBNull(lector.GetOrdinal("t_rutaimagen")) ? default(string) : lector.GetString(lector.GetOrdinal("t_rutaimagen")),
                            id_tipo_producto = lector.IsDBNull(lector.GetOrdinal("id_tipo_producto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_producto")),
                            id_clase = lector.IsDBNull(lector.GetOrdinal("id_clase")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_clase")),
                            id_generico = lector.IsDBNull(lector.GetOrdinal("id_generico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_generico")),
                            id_familia = lector.IsDBNull(lector.GetOrdinal("id_familia")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_familia")),
                            id_tipificacion = lector.IsDBNull(lector.GetOrdinal("id_tipificacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipificacion")),
                            c_gtin = lector.IsDBNull(lector.GetOrdinal("c_gtin")) ? default(string) : lector.GetString(lector.GetOrdinal("c_gtin")),
                            c_unspsc = lector.IsDBNull(lector.GetOrdinal("c_unspsc")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("c_unspsc")),
                            n_stockmin = lector.IsDBNull(lector.GetOrdinal("n_stockmin")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_stockmin")),
                            n_stockmax = lector.IsDBNull(lector.GetOrdinal("n_stockmax")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_stockmax")),
                            n_pcosto = lector.IsDBNull(lector.GetOrdinal("n_pcosto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_pcosto")),
                            n_pvf = lector.IsDBNull(lector.GetOrdinal("n_pvf")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_pvf")),
                            n_utilidad = lector.IsDBNull(lector.GetOrdinal("n_utilidad")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_utilidad")),
                            n_pvs = lector.IsDBNull(lector.GetOrdinal("n_pvs")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_pvs")),
                            n_plista = lector.IsDBNull(lector.GetOrdinal("n_plista")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_plista")),
                            f_inafecto = lector.IsDBNull(lector.GetOrdinal("f_inafecto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_inafecto")),
                            id_consignacion = lector.IsDBNull(lector.GetOrdinal("id_consignacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_consignacion")),
                            id_laboratorio = lector.IsDBNull(lector.GetOrdinal("id_laboratorio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_laboratorio")),
                            id_proveedor = lector.IsDBNull(lector.GetOrdinal("id_proveedor")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_proveedor")),
                            n_dscto_1 = lector.IsDBNull(lector.GetOrdinal("n_dscto_1")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_dscto_1")),
                            n_dscto_2 = lector.IsDBNull(lector.GetOrdinal("n_dscto_2")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_dscto_2")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            n_valorizado = lector.IsDBNull(lector.GetOrdinal("n_valorizado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_valorizado")),

                        });
                    }
                }
            }

            return listProducto;
        }

        public int Update(FAR_PRODUCTOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Update2(FAR_PRODUCTOReq entity)
        {
            int id;
            string mensaje = "";

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAR_PRODUCTO_Update")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_producto", DbType.String, entity.id_producto);
                _database.AddInParameter(comando, "@t_codigo", DbType.String, entity.t_codigo);
                _database.AddInParameter(comando, "@t_descripcion", DbType.String, entity.t_descripcion);
                _database.AddInParameter(comando, "@t_presentacion", DbType.String, entity.t_presentacion);
                _database.AddInParameter(comando, "@t_rutaimagen", DbType.String, entity.t_rutaimagen);
                _database.AddInParameter(comando, "@id_tipo_producto", DbType.Int32, entity.id_tipo_producto);
                _database.AddInParameter(comando, "@id_clase", DbType.Int32, entity.id_clase);
                _database.AddInParameter(comando, "@id_generico", DbType.Int32, entity.id_generico);
                _database.AddInParameter(comando, "@id_familia", DbType.Int32, entity.id_familia);
                _database.AddInParameter(comando, "@id_tipificacion", DbType.Int32, entity.id_tipificacion);
                _database.AddInParameter(comando, "@c_gtin", DbType.String, entity.c_gtin);
                _database.AddInParameter(comando, "@c_unspsc", DbType.String, entity.c_unspsc);
                _database.AddInParameter(comando, "@n_stockmin", DbType.Decimal, entity.n_stockmin);
                _database.AddInParameter(comando, "@n_stockmax", DbType.Decimal, entity.n_stockmax);
                _database.AddInParameter(comando, "@n_pcosto", DbType.Decimal, entity.n_pcosto);
                _database.AddInParameter(comando, "@n_pvf", DbType.Decimal, entity.n_pvf);
                _database.AddInParameter(comando, "@n_utilidad", DbType.Decimal, entity.n_utilidad);
                _database.AddInParameter(comando, "@n_pvs", DbType.Decimal, entity.n_pvs);
                _database.AddInParameter(comando, "@n_plista", DbType.Decimal, entity.n_plista);
                _database.AddInParameter(comando, "@f_inafecto", DbType.Int32, entity.f_inafecto);
                _database.AddInParameter(comando, "@id_consignacion", DbType.Int32, entity.id_consignacion);
                _database.AddInParameter(comando, "@id_laboratorio", DbType.Int32, entity.id_laboratorio);
                _database.AddInParameter(comando, "@id_proveedor", DbType.Int32, entity.id_proveedor);
                _database.AddInParameter(comando, "@n_dscto_1", DbType.Decimal, entity.n_dscto_1);
                _database.AddInParameter(comando, "@n_dscto_2", DbType.Decimal, entity.n_dscto_2);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@n_valorizado", DbType.Int32, entity.n_valorizado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_user_registro);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.d_fecha_registro);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.AddOutParameter(comando, "@Response_t", DbType.String, 100);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
                mensaje = Convert.ToString(_database.GetParameterValue(comando, "@Response_t"));
            }

            return Tuple.Create(id, mensaje);
        }
    }
}
