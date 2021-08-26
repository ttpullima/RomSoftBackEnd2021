using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ATENCIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_ATENCIONRepository : Singleton<ADM_ATENCIONRepository>, IADM_ATENCIONRepository<ADM_ATENCION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        public int Add(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        //Retorma mas de 1 mensaje de respuesta
        public Tuple<int, string> Add2(ADM_ATENCION entity)
        {
            int id;
            string mensaje = "";

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_Insert")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@id_tipo_paciente", DbType.Int32, entity.id_tipo_paciente);
                _database.AddInParameter(comando, "@id_tipo_atencion", DbType.Int32, entity.id_tipo_atencion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.d_fecha_registro);
                _database.AddInParameter(comando, "@c_hora_registro", DbType.String, entity.c_hora_registro);
                _database.AddInParameter(comando, "@n_paciente_derivado", DbType.Int32, entity.n_paciente_derivado);
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);
                _database.AddInParameter(comando, "@id_categoria_pago", DbType.Int32, entity.id_categoria_pago);
                _database.AddInParameter(comando, "@c_codigo_asegurado", DbType.String, entity.c_codigo_asegurado);
                _database.AddInParameter(comando, "@c_contrato", DbType.String, entity.c_contrato);
                _database.AddInParameter(comando, "@id_beneficio", DbType.Int32, entity.id_beneficio);
                _database.AddInParameter(comando, "@id_documento_prestacion1", DbType.Int32, entity.id_documento_prestacion1);
                _database.AddInParameter(comando, "@c_documento_prestacion1", DbType.String, entity.c_documento_prestacion1);
                _database.AddInParameter(comando, "@d_fecha_autorizacion1", DbType.DateTime, entity.d_fecha_autorizacion1);
                _database.AddInParameter(comando, "@id_documento_prestacion2", DbType.Int32, entity.id_documento_prestacion2);
                _database.AddInParameter(comando, "@c_documento_prestacion2", DbType.String, entity.c_documento_prestacion2);
                _database.AddInParameter(comando, "@d_fecha_autorizacion2", DbType.DateTime, entity.d_fecha_autorizacion2);
                _database.AddInParameter(comando, "@id_tipo_filiacion", DbType.Int32, entity.id_tipo_filiacion);
                _database.AddInParameter(comando, "@t_nombre_titular", DbType.String, entity.t_nombre_titular);
                _database.AddInParameter(comando, "@id_tipo_afiliacion", DbType.Int32, entity.id_tipo_afiliacion);
                _database.AddInParameter(comando, "@id_moneda", DbType.Int32, entity.id_moneda);
                _database.AddInParameter(comando, "@n_copago_fijo", DbType.Decimal, entity.n_copago_fijo);
                _database.AddInParameter(comando, "@n_copago_variable", DbType.Decimal, entity.n_copago_variable);
                _database.AddInParameter(comando, "@n_copago_variable_far", DbType.Decimal, entity.n_copago_variable_far);
                _database.AddInParameter(comando, "@id_producto_plan", DbType.Int32, entity.id_producto_plan);
                _database.AddInParameter(comando, "@n_limite_cobertura", DbType.String, entity.n_limite_cobertura);
                _database.AddInParameter(comando, "@id_tipo_diagnostico", DbType.Int32, entity.id_tipo_diagnostico);
                _database.AddInParameter(comando, "@id_diagnostico", DbType.Int32, entity.id_diagnostico);
                _database.AddInParameter(comando, "@c_numero_placa", DbType.String, entity.c_numero_placa);
                _database.AddInParameter(comando, "@n_deja_denuncia", DbType.Int32, entity.n_deja_denuncia);
                _database.AddInParameter(comando, "@n_deja_carta", DbType.Int32, entity.n_deja_carta);
                _database.AddInParameter(comando, "@t_observacion_accidente", DbType.String, entity.t_observacion_accidente);
                _database.AddInParameter(comando, "@id_profesional", DbType.Int32, entity.id_profesional);
                _database.AddInParameter(comando, "@id_hospitalizacion", DbType.Int32, entity.id_hospitalizacion);
                _database.AddInParameter(comando, "@t_observacion_general", DbType.String, entity.t_observacion_general);
                _database.AddInParameter(comando, "@d_fecha_cierre", DbType.DateTime, entity.d_fecha_cierre);
                _database.AddInParameter(comando, "@c_hora_cierre", DbType.String, entity.c_hora_cierre);
                _database.AddInParameter(comando, "@id_tipo_facturacion", DbType.Int32, entity.id_tipo_facturacion);
                _database.AddInParameter(comando, "@n_a_no_gravado", DbType.Decimal, entity.n_a_no_gravado);
                _database.AddInParameter(comando, "@n_a_gravado", DbType.Decimal, entity.n_a_gravado);
                _database.AddInParameter(comando, "@n_a_impuesto", DbType.Decimal, entity.n_a_impuesto);
                _database.AddInParameter(comando, "@n_a_total", DbType.Decimal, entity.n_a_total);
                _database.AddInParameter(comando, "@n_p_no_gravado", DbType.Decimal, entity.n_p_no_gravado);
                _database.AddInParameter(comando, "@n_p_gravado", DbType.Decimal, entity.n_p_gravado);
                _database.AddInParameter(comando, "@n_p_impuesto", DbType.Decimal, entity.n_p_impuesto);
                _database.AddInParameter(comando, "@n_p_total", DbType.Decimal, entity.n_p_total);
                _database.AddInParameter(comando, "@n_g_no_gravado", DbType.Decimal, entity.n_g_no_gravado);
                _database.AddInParameter(comando, "@n_g_gravado", DbType.Decimal, entity.n_g_gravado);
                _database.AddInParameter(comando, "@n_g_impuesto", DbType.Decimal, entity.n_g_impuesto);
                _database.AddInParameter(comando, "@n_g_total", DbType.Decimal, entity.n_g_total);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@id_user_modifica", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_modifica", DbType.DateTime, entity.FechaCreacion);
                _database.AddInParameter(comando, "@d_fecha_hospitalizacion", DbType.DateTime, entity.d_fecha_hospitalizacion);
                _database.AddInParameter(comando, "@c_hora_hospitalizacion", DbType.String, entity.c_hora_hospitalizacion);
                _database.AddInParameter(comando, "@id_habitacion", DbType.Int32, entity.id_habitacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.AddOutParameter(comando, "@Response_t", DbType.String,100);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
                mensaje = Convert.ToString(_database.GetParameterValue(comando, "@Response_t"));
            }

            return Tuple.Create(id,mensaje);
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
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetAllFilter")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@d_fecha_registro_1", DbType.DateTime, entity.d_fecha_registro_1);
                _database.AddInParameter(comando, "@d_fecha_registro_2", DbType.DateTime, entity.d_fecha_registro_2);



                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaciente(int idPaciente)
        {
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetAll")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, idPaciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION_ResponseGetAllActives> GetAtencionAllFilters(int idPaciente)
        {
            List<ADM_ATENCION_ResponseGetAllActives> atenciones = new List<ADM_ATENCION_ResponseGetAllActives>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetAllFilter")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, idPaciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION_ResponseGetAllActives
                        {
                            id_atencion = lector.IsDBNull(lector.GetOrdinal("id_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion")),
                            d_fecha_registro = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            c_hora_registro = lector.IsDBNull(lector.GetOrdinal("c_hora_registro")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_registro")),
                            HClinica = lector.IsDBNull(lector.GetOrdinal("HClinica")) ? default(string) : lector.GetString(lector.GetOrdinal("HClinica")),
                            Paciente = lector.IsDBNull(lector.GetOrdinal("Paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("Paciente")),
                            Garante = lector.IsDBNull(lector.GetOrdinal("Garante")) ? default(string) : lector.GetString(lector.GetOrdinal("Garante")),
                            Prestacion = lector.IsDBNull(lector.GetOrdinal("Prestacion")) ? default(string) : lector.GetString(lector.GetOrdinal("Prestacion")),
                            TAtencion = lector.IsDBNull(lector.GetOrdinal("TAtencion")) ? default(string) : lector.GetString(lector.GetOrdinal("TAtencion")),
                            TPaciente = lector.IsDBNull(lector.GetOrdinal("TPaciente")) ? default(string) : lector.GetString(lector.GetOrdinal("TPaciente")),
                            Estado = lector.IsDBNull(lector.GetOrdinal("Estado")) ? default(string) : lector.GetString(lector.GetOrdinal("Estado")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION_PendingResponse> GetAtencionPending(int id_atencion, string c_tipo_pendiente, string c_tipo_facturacion, string c_idioma, int id_usuario)
        {
            List<ADM_ATENCION_PendingResponse> atenciones = new List<ADM_ATENCION_PendingResponse>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_Pending")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_atencion", DbType.Int32, id_atencion);
                _database.AddInParameter(comando, "@c_tipo_pendiente", DbType.String, c_tipo_pendiente);
                _database.AddInParameter(comando, "@c_tipo_facturacion", DbType.String, c_tipo_facturacion);
                _database.AddInParameter(comando, "@c_idioma", DbType.String, c_idioma);
                _database.AddInParameter(comando, "@id_usuario", DbType.String, id_usuario);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION_PendingResponse
                        {
                            id_moneda = lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            n_copago_fijo = lector.IsDBNull(lector.GetOrdinal("n_copago_fijo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_fijo")),
                            id_documento_pago = lector.IsDBNull(lector.GetOrdinal("id_documento_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_pago")),
                            id_forma_pago = lector.IsDBNull(lector.GetOrdinal("id_forma_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_forma_pago")),
                            id_documento_identidad = lector.IsDBNull(lector.GetOrdinal("id_documento_identidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_identidad")),
                            c_documento_identidad = lector.IsDBNull(lector.GetOrdinal("c_documento_identidad")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_identidad")),
                            t_adquiriente = lector.IsDBNull(lector.GetOrdinal("t_adquiriente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_adquiriente")),
                            t_direccion= lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            t_paciente = lector.IsDBNull(lector.GetOrdinal("t_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_paciente")),
                            id_tipo_atencion = lector.IsDBNull(lector.GetOrdinal("id_tipo_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_atencion")),
                            n_historia_clinica = lector.IsDBNull(lector.GetOrdinal("n_historia_clinica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_historia_clinica")),
                            id_atencion = lector.IsDBNull(lector.GetOrdinal("id_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion")),
                            d_fecha_registro = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            id_clasificacion_segus = lector.IsDBNull(lector.GetOrdinal("id_clasificacion_segus")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_clasificacion_segus")),
                            t_clasificacion_segus = lector.IsDBNull(lector.GetOrdinal("t_clasificacion_segus")) ? default(string) : lector.GetString(lector.GetOrdinal("t_clasificacion_segus")),
                            id_tarifario_segus = lector.IsDBNull(lector.GetOrdinal("id_tarifario_segus")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tarifario_segus")),
                            c_codigo_segus = lector.IsDBNull(lector.GetOrdinal("c_codigo_segus")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_segus")),
                            t_descripcion_segus = lector.IsDBNull(lector.GetOrdinal("t_descripcion_segus")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion_segus")),
                            n_precio = lector.IsDBNull(lector.GetOrdinal("n_precio")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_precio")),
                            n_cantidad = lector.IsDBNull(lector.GetOrdinal("n_cantidad")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_cantidad")),
                            n_subtotal = lector.IsDBNull(lector.GetOrdinal("n_subtotal")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_subtotal")),
                            n_descuento = lector.IsDBNull(lector.GetOrdinal("n_descuento")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_descuento")),
                            n_total = lector.IsDBNull(lector.GetOrdinal("n_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_total")),
                            id_profesional = lector.IsDBNull(lector.GetOrdinal("id_profesional")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_profesional")),
                            id_naciones_unidas = lector.IsDBNull(lector.GetOrdinal("id_naciones_unidas")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_naciones_unidas")),
                            //
                            n_anticipo= lector.IsDBNull(lector.GetOrdinal("n_anticipo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_anticipo")),
                            n_gravado = lector.IsDBNull(lector.GetOrdinal("n_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_gravado")),
                            n_no_grabado = lector.IsDBNull(lector.GetOrdinal("n_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_no_gravado")),
                            n_impuesto = lector.IsDBNull(lector.GetOrdinal("n_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_impuesto")),
                            total = lector.IsDBNull(lector.GetOrdinal("total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("total")),


                        });
                    }
                }
            }

            


            return atenciones;
        }

        public IList<ADM_ATENCION> GetById(int idAtencion)
        {
            List<ADM_ATENCION> paciente = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetById")))
            {
                _database.AddInParameter(comando, "@id_atencion", DbType.Int32, idAtencion);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new ADM_ATENCION
                        {
                            //n_historia_clinica = lector.IsDBNull(lector.GetOrdinal("n_historia_clinica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_historia_clinica")),
                            //t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("t_apellido_paterno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_paterno")),
                            //d_fecha_nacimiento = lector.IsDBNull(lector.GetOrdinal("d_fecha_nacimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_nacimiento")),
                            
                            id_atencion = lector.IsDBNull(lector.GetOrdinal("id_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion")),
                            id_paciente = lector.IsDBNull(lector.GetOrdinal("id_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_paciente")),
                            id_tipo_paciente = lector.IsDBNull(lector.GetOrdinal("id_tipo_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_paciente")),
                            id_tipo_atencion = lector.IsDBNull(lector.GetOrdinal("id_tipo_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_atencion")),
                            d_fecha_registro = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            c_hora_registro = lector.IsDBNull(lector.GetOrdinal("c_hora_registro")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_registro")),
                            n_paciente_derivado = lector.IsDBNull(lector.GetOrdinal("n_paciente_derivado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_paciente_derivado")),
                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            id_categoria_pago = lector.IsDBNull(lector.GetOrdinal("id_categoria_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_categoria_pago")),
                            c_codigo_asegurado = lector.IsDBNull(lector.GetOrdinal("c_codigo_asegurado")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_asegurado")),
                            c_contrato = lector.IsDBNull(lector.GetOrdinal("c_contrato")) ? default(string) : lector.GetString(lector.GetOrdinal("c_contrato")),
                            id_beneficio = lector.IsDBNull(lector.GetOrdinal("id_beneficio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_beneficio")),
                            id_documento_prestacion1 = lector.IsDBNull(lector.GetOrdinal("id_documento_prestacion1")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_prestacion1")),
                            c_documento_prestacion1 = lector.IsDBNull(lector.GetOrdinal("c_documento_prestacion1")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_prestacion1")),
                            d_fecha_autorizacion1 = lector.IsDBNull(lector.GetOrdinal("d_fecha_autorizacion1")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_autorizacion1")),
                            id_documento_prestacion2 = lector.IsDBNull(lector.GetOrdinal("id_documento_prestacion2")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_prestacion2")),
                            c_documento_prestacion2 = lector.IsDBNull(lector.GetOrdinal("c_documento_prestacion2")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_prestacion2")),
                            d_fecha_autorizacion2 = lector.IsDBNull(lector.GetOrdinal("d_fecha_autorizacion2")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_autorizacion2")),
                            id_tipo_filiacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_filiacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_filiacion")),
                            t_nombre_titular = lector.IsDBNull(lector.GetOrdinal("t_nombre_titular")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombre_titular")),
                            id_tipo_afiliacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_afiliacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_afiliacion")),
                            id_moneda = lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            n_copago_fijo = lector.IsDBNull(lector.GetOrdinal("n_copago_fijo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_fijo")),
                            n_copago_variable = lector.IsDBNull(lector.GetOrdinal("n_copago_variable")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable")),
                            n_copago_variable_far = lector.IsDBNull(lector.GetOrdinal("n_copago_variable_far")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable_far")),
                            id_producto_plan = lector.IsDBNull(lector.GetOrdinal("id_producto_plan")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto_plan")),
                            n_limite_cobertura = lector.IsDBNull(lector.GetOrdinal("n_limite_cobertura")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_limite_cobertura")),
                            id_tipo_diagnostico = lector.IsDBNull(lector.GetOrdinal("id_tipo_diagnostico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_diagnostico")),
                            id_diagnostico = lector.IsDBNull(lector.GetOrdinal("id_diagnostico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_diagnostico")),
                            c_numero_placa = lector.IsDBNull(lector.GetOrdinal("c_numero_placa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_numero_placa")),
                            n_deja_denuncia = lector.IsDBNull(lector.GetOrdinal("n_deja_denuncia")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_deja_denuncia")),
                            n_deja_carta = lector.IsDBNull(lector.GetOrdinal("n_deja_carta")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_deja_carta")),
                            t_observacion_accidente = lector.IsDBNull(lector.GetOrdinal("t_observacion_accidente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion_accidente")),
                            id_profesional = lector.IsDBNull(lector.GetOrdinal("id_profesional")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_profesional")),
                            id_hospitalizacion = lector.IsDBNull(lector.GetOrdinal("id_hospitalizacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_hospitalizacion")),
                            t_observacion_general = lector.IsDBNull(lector.GetOrdinal("t_observacion_general")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion_general")),
                            d_fecha_cierre = lector.IsDBNull(lector.GetOrdinal("d_fecha_cierre")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_cierre")),
                            c_hora_cierre = lector.IsDBNull(lector.GetOrdinal("c_hora_cierre")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_cierre")),
                            id_tipo_facturacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_facturacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_facturacion")),
                            n_a_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_a_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_no_gravado")),
                            n_a_gravado = lector.IsDBNull(lector.GetOrdinal("n_a_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_gravado")),
                            n_a_impuesto = lector.IsDBNull(lector.GetOrdinal("n_a_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_impuesto")),
                            n_a_total = lector.IsDBNull(lector.GetOrdinal("n_a_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_total")),
                            n_p_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_p_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_no_gravado")),
                            n_p_gravado = lector.IsDBNull(lector.GetOrdinal("n_p_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_gravado")),
                            n_p_impuesto = lector.IsDBNull(lector.GetOrdinal("n_p_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_impuesto")),
                            n_p_total = lector.IsDBNull(lector.GetOrdinal("n_p_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_total")),
                            n_g_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_g_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_no_gravado")),
                            n_g_gravado = lector.IsDBNull(lector.GetOrdinal("n_g_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_gravado")),
                            n_g_impuesto = lector.IsDBNull(lector.GetOrdinal("n_g_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_impuesto")),
                            n_g_total = lector.IsDBNull(lector.GetOrdinal("n_g_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_total")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            id_habitacion = lector.IsDBNull(lector.GetOrdinal("id_habitacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_habitacion")),
                            d_fecha_egreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_egreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_egreso")),
                            c_hora_egreso = lector.IsDBNull(lector.GetOrdinal("c_hora_egreso")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_egreso")),
                            id_tipo_egreso = lector.IsDBNull(lector.GetOrdinal("id_tipo_egreso")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_egreso")),

                        });
                    }
                }
            }

            return paciente;
        }


        public int Update(ADM_ATENCION entity)
        {

            throw new NotImplementedException();
        }

        public Tuple<int, string> Update2(ADM_ATENCION entity)
        {
            int id;
            string mensaje = "";

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_Update")))
            {
                comando.CommandTimeout = int.MaxValue;

                _database.AddInParameter(comando, "@id_atencion", DbType.Int32, entity.id_atencion);
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@id_tipo_paciente", DbType.Int32, entity.id_tipo_paciente);
                _database.AddInParameter(comando, "@id_tipo_atencion", DbType.Int32, entity.id_tipo_atencion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.d_fecha_registro);
                _database.AddInParameter(comando, "@c_hora_registro", DbType.String, entity.c_hora_registro);
                _database.AddInParameter(comando, "@n_paciente_derivado", DbType.Int32, entity.n_paciente_derivado);
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);
                _database.AddInParameter(comando, "@id_categoria_pago", DbType.Int32, entity.id_categoria_pago);
                _database.AddInParameter(comando, "@c_codigo_asegurado", DbType.String, entity.c_codigo_asegurado);
                _database.AddInParameter(comando, "@c_contrato", DbType.String, entity.c_contrato);
                _database.AddInParameter(comando, "@id_beneficio", DbType.Int32, entity.id_beneficio);
                _database.AddInParameter(comando, "@id_documento_prestacion1", DbType.Int32, entity.id_documento_prestacion1);
                _database.AddInParameter(comando, "@c_documento_prestacion1", DbType.String, entity.c_documento_prestacion1);
                _database.AddInParameter(comando, "@d_fecha_autorizacion1", DbType.DateTime, entity.d_fecha_autorizacion1);
                _database.AddInParameter(comando, "@id_documento_prestacion2", DbType.Int32, entity.id_documento_prestacion2);
                _database.AddInParameter(comando, "@c_documento_prestacion2", DbType.String, entity.c_documento_prestacion2);
                _database.AddInParameter(comando, "@d_fecha_autorizacion2", DbType.DateTime, entity.d_fecha_autorizacion2);
                _database.AddInParameter(comando, "@id_tipo_filiacion", DbType.Int32, entity.id_tipo_filiacion);
                _database.AddInParameter(comando, "@t_nombre_titular", DbType.String, entity.t_nombre_titular);
                _database.AddInParameter(comando, "@id_tipo_afiliacion", DbType.Int32, entity.id_tipo_afiliacion);
                _database.AddInParameter(comando, "@id_moneda", DbType.Int32, entity.id_moneda);
                _database.AddInParameter(comando, "@n_copago_fijo", DbType.Decimal, entity.n_copago_fijo);
                _database.AddInParameter(comando, "@n_copago_variable", DbType.Decimal, entity.n_copago_variable);
                _database.AddInParameter(comando, "@n_copago_variable_far", DbType.Decimal, entity.n_copago_variable_far);
                _database.AddInParameter(comando, "@id_producto_plan", DbType.Int32, entity.id_producto_plan);
                _database.AddInParameter(comando, "@n_limite_cobertura", DbType.String, entity.n_limite_cobertura);
                _database.AddInParameter(comando, "@id_tipo_diagnostico", DbType.Int32, entity.id_tipo_diagnostico);
                _database.AddInParameter(comando, "@id_diagnostico", DbType.Int32, entity.id_diagnostico);
                _database.AddInParameter(comando, "@c_numero_placa", DbType.String, entity.c_numero_placa);
                _database.AddInParameter(comando, "@n_deja_denuncia", DbType.Int32, entity.n_deja_denuncia);
                _database.AddInParameter(comando, "@n_deja_carta", DbType.Int32, entity.n_deja_carta);
                _database.AddInParameter(comando, "@t_observacion_accidente", DbType.String, entity.t_observacion_accidente);
                _database.AddInParameter(comando, "@id_profesional", DbType.Int32, entity.id_profesional);
                _database.AddInParameter(comando, "@id_hospitalizacion", DbType.Int32, entity.id_hospitalizacion);
                _database.AddInParameter(comando, "@t_observacion_general", DbType.String, entity.t_observacion_general);
                _database.AddInParameter(comando, "@d_fecha_cierre", DbType.DateTime, entity.d_fecha_cierre);
                _database.AddInParameter(comando, "@c_hora_cierre", DbType.String, entity.c_hora_cierre);
                _database.AddInParameter(comando, "@id_tipo_facturacion", DbType.Int32, entity.id_tipo_facturacion);
                _database.AddInParameter(comando, "@n_a_no_gravado", DbType.Decimal, entity.n_a_no_gravado);
                _database.AddInParameter(comando, "@n_a_gravado", DbType.Decimal, entity.n_a_gravado);
                _database.AddInParameter(comando, "@n_a_impuesto", DbType.Decimal, entity.n_a_impuesto);
                _database.AddInParameter(comando, "@n_a_total", DbType.Decimal, entity.n_a_total);
                _database.AddInParameter(comando, "@n_p_no_gravado", DbType.Decimal, entity.n_p_no_gravado);
                _database.AddInParameter(comando, "@n_p_gravado", DbType.Decimal, entity.n_p_gravado);
                _database.AddInParameter(comando, "@n_p_impuesto", DbType.Decimal, entity.n_p_impuesto);
                _database.AddInParameter(comando, "@n_p_total", DbType.Decimal, entity.n_p_total);
                _database.AddInParameter(comando, "@n_g_no_gravado", DbType.Decimal, entity.n_g_no_gravado);
                _database.AddInParameter(comando, "@n_g_gravado", DbType.Decimal, entity.n_g_gravado);
                _database.AddInParameter(comando, "@n_g_impuesto", DbType.Decimal, entity.n_g_impuesto);
                _database.AddInParameter(comando, "@n_g_total", DbType.Decimal, entity.n_g_total);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@id_user_modifica", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_modifica", DbType.DateTime, entity.FechaCreacion);
                _database.AddInParameter(comando, "@d_fecha_hospitalizacion", DbType.DateTime, entity.d_fecha_hospitalizacion);
                _database.AddInParameter(comando, "@c_hora_hospitalizacion", DbType.String, entity.c_hora_hospitalizacion);
                _database.AddInParameter(comando, "@id_habitacion", DbType.Int32, entity.id_habitacion);
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
