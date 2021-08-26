using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IFAC_DOCUMENTO_PAGORepository;
using Romsoft.GESTIONCLINICA.Entidades.FAC_DOCUMENTO_PAGO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class FAC_DOCUMENTO_PAGORepository : Singleton<FAC_DOCUMENTO_PAGORepository>, IFAC_DOCUMENTO_PAGORepository<FAC_DOCUMENTO_PAGOReq>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion


        public int Add(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Add2(FAC_COMPROBANTEReq entity)
        {
            int id;
            string mensaje;
            mensaje = "";

            ////Se crea tabla con las misma estrcura del detalle SQL
            DataTable tvpDetalle = new DataTable();
            tvpDetalle.Columns.Add("id_tarifario_segus");
            tvpDetalle.Columns.Add("t_tarifario_segus");
            tvpDetalle.Columns.Add("c_codigo_segus");
            tvpDetalle.Columns.Add("id_clasificacion_segus");
            tvpDetalle.Columns.Add("t_clasificacion_segus");
            tvpDetalle.Columns.Add("n_precio");
            tvpDetalle.Columns.Add("n_cantidad");
            tvpDetalle.Columns.Add("n_subtotal");
            tvpDetalle.Columns.Add("n_descuento");
            tvpDetalle.Columns.Add("n_total");


            foreach (var _Detalle in entity.DetalleComprobante)
            {
                DataRow row2 = tvpDetalle.NewRow();
                row2["id_tarifario_segus"] = _Detalle.id_tarifario_segus.ToString();
                row2["t_tarifario_segus"] = _Detalle.t_tarifario_segus.ToString();
                row2["c_codigo_segus"] = _Detalle.c_codigo_segus.ToString();
                row2["id_clasificacion_segus"] = _Detalle.id_clasificacion_segus;
                row2["t_clasificacion_segus"] = _Detalle.t_clasificacion_segus.ToString();
                row2["n_precio"] = Convert.ToDecimal(_Detalle.n_precio);
                row2["n_cantidad"] = Convert.ToDecimal(_Detalle.n_cantidad);
                row2["n_subtotal"] = Convert.ToDecimal(_Detalle.n_subtotal);
                row2["n_descuento"] = Convert.ToDecimal(_Detalle.n_descuento);
                row2["n_total"] = Convert.ToDecimal(_Detalle.n_total);

                tvpDetalle.Rows.Add(row2);
            }
            tvpDetalle.AcceptChanges();

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAC_COMPROBANTE_Insert")))
            {
                _database.AddInParameter(comando, "@id_documento_pago", DbType.Int32, entity.id_documento_pago);
                _database.AddInParameter(comando, "@id_atencion", DbType.Int32, entity.id_atencion);
                _database.AddInParameter(comando, "@id_tipo_documento", DbType.Int32, entity.id_tipo_documento);
                _database.AddInParameter(comando, "@c_numero_de_documento", DbType.String, entity.c_numero_de_documento);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_paciente", DbType.String, entity.t_paciente);
                _database.AddInParameter(comando, "@d_fecha_emis", DbType.DateTime, entity.d_fecha_emis);
                _database.AddInParameter(comando, "@id_condicion_pago", DbType.Int32, entity.id_condicion_pago);
                _database.AddInParameter(comando, "@id_moneda", DbType.Int32, entity.id_moneda);
                _database.AddInParameter(comando, "@n_porcen_igv", DbType.Decimal, entity.n_porcen_igv);
                _database.AddInParameter(comando, "@n_porcen_descu", DbType.Decimal, entity.n_porcen_descu);
                _database.AddInParameter(comando, "@n_total_bruto", DbType.Decimal, entity.n_total_bruto);
                _database.AddInParameter(comando, "@n_total_descuento", DbType.Decimal, entity.n_total_descuento);
                _database.AddInParameter(comando, "@n_total_anticipo", DbType.Decimal, entity.n_total_anticipo);
                _database.AddInParameter(comando, "@n_total_gravada", DbType.Decimal, entity.n_total_gravada);
                _database.AddInParameter(comando, "@n_total_no_gravada", DbType.Decimal, entity.n_total_no_gravada);
                _database.AddInParameter(comando, "@n_total_icbper", DbType.Decimal, entity.n_total_icbper);
                _database.AddInParameter(comando, "@n_total_impuesto", DbType.Decimal, entity.n_total_impuesto);
                _database.AddInParameter(comando, "@n_total_neto", DbType.Decimal, entity.n_total_neto);
                _database.AddInParameter(comando, "@t_observacion", DbType.String, entity.t_observacion);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_user_registro);

                var parametroLista = new SqlParameter("@comprobante_detalle", SqlDbType.Structured);
                parametroLista.TypeName = "Romsoft.FAC_COMPROBANTE_DET_TYPE";
                parametroLista.Value = tvpDetalle;

                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.AddOutParameter(comando, "@Response_t", DbType.String, 100);

                comando.Parameters.Add(parametroLista);

                _database.ExecuteNonQuery(comando);

                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
                mensaje = Convert.ToString(_database.GetParameterValue(comando, "@Response_t"));
            }

            return Tuple.Create(id, mensaje);
        }

        public int Delete(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGO> GetAllFacDocumentoPagoFilters(string c_dato)
        {
            List<FAC_DOCUMENTO_PAGO> paciente = new List<FAC_DOCUMENTO_PAGO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_FAC_DOCUMENTO_PAGO_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@c_dato", DbType.String, c_dato);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new FAC_DOCUMENTO_PAGO
                        {
                            id_documento_pago= lector.IsDBNull(lector.GetOrdinal("id_documento_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_pago")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return paciente;
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllFilters(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }

        public IList<FAC_DOCUMENTO_PAGOReq> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public int Update(FAC_DOCUMENTO_PAGOReq entity)
        {
            throw new NotImplementedException();
        }
    }
}
