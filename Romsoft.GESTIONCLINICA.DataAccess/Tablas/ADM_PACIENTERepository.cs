using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PACIENTERepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_PACIENTERepository : Singleton<ADM_PACIENTERepository>, IADM_PACIENTERepository<ADM_PACIENTE>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(ADM_PACIENTE entity)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Add2(ADM_PACIENTE entity)
        {
            
            int id;
            string mensaje = "";

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Insert")))
            {
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.Int32, entity.n_historia_clinica);
                _database.AddInParameter(comando, "@t_apellido_paterno", DbType.String, entity.t_apellido_paterno);
                _database.AddInParameter(comando, "@t_apellido_materno", DbType.String, entity.t_apellido_materno);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_paciente", DbType.String, entity.t_paciente);
                _database.AddInParameter(comando, "@d_fecha_nacimiento", DbType.DateTime, entity.d_fecha_nacimiento);
                _database.AddInParameter(comando, "@id_genero", DbType.Int32, entity.id_genero);
                _database.AddInParameter(comando, "@id_estado_civil", DbType.Int32, entity.id_estado_civil);
                _database.AddInParameter(comando, "@id_documento_identidad", DbType.Int32, entity.id_documento_identidad);
                _database.AddInParameter(comando, "@c_documento_identidad", DbType.String, entity.c_documento_identidad);
                _database.AddInParameter(comando, "@id_grupo_sanguineo", DbType.Int32, entity.id_grupo_sanguineo);
                _database.AddInParameter(comando, "@id_ocupacion", DbType.Int32, entity.id_ocupacion);
                _database.AddInParameter(comando, "@t_ocupacion", DbType.String, entity.t_ocupacion);
                _database.AddInParameter(comando, "@t_email_paciente", DbType.String, entity.t_email_paciente);
                _database.AddInParameter(comando, "@c_p_fono_casa", DbType.String, entity.c_p_fono_casa);
                _database.AddInParameter(comando, "@c_p_fono_personal", DbType.String, entity.c_p_fono_personal);
                _database.AddInParameter(comando, "@c_p_fono_corporativo", DbType.String, entity.c_p_fono_corporativo);
                _database.AddInParameter(comando, "@id_ubigeo_nacimiento", DbType.Int32, entity.id_ubigeo_nacimiento);
                _database.AddInParameter(comando, "@id_ubigeo_domicilio", DbType.Int32, entity.id_ubigeo_domicilio);
                _database.AddInParameter(comando, "@t_referencia", DbType.String, entity.t_referencia);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_responsable", DbType.String, entity.t_responsable);
                _database.AddInParameter(comando, "@t_email_responsable", DbType.String, entity.t_email_responsable);
                _database.AddInParameter(comando, "@c_r_fono_casa", DbType.String, entity.c_r_fono_casa);
                _database.AddInParameter(comando, "@c_r_fono_personal", DbType.String, entity.c_r_fono_personal);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.FechaCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.AddOutParameter(comando, "@response_t", DbType.String, 100);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
                mensaje = Convert.ToString(_database.GetParameterValue(comando, "@response_t"));
            }

            return Tuple.Create(id, mensaje);
        }

        public int Delete(ADM_PACIENTE entity)
        {
            int idResult;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Delete")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                idResult = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return idResult;
        }

        public bool Exists(ADM_PACIENTE entity)
        {
            bool existe = false;
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_VerifyExists")))
            {
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.String, entity.n_historia_clinica);

                using (var lector = _database.ExecuteReader(comando))
                {
                    if (lector.Read())
                    {
                        existe = Convert.ToBoolean(lector.GetInt32(0));
                    }
                }
            }

            return existe;
        }

        public IList<ADM_PACIENTE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllFilters(ADM_PACIENTE entity)
        {
            List<ADM_PACIENTE> paciente = new List<ADM_PACIENTE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.valorRequest);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new ADM_PACIENTE
                        {

                            id_paciente = lector.IsDBNull(lector.GetOrdinal("Codigo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("Codigo")),
                            historia_clinica = lector.IsDBNull(lector.GetOrdinal("Historia")) ? default(string) : lector.GetString(lector.GetOrdinal("Historia")),
                            t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("APaterno")) ? default(string) : lector.GetString(lector.GetOrdinal("APaterno")),
                            t_apellido_materno = lector.IsDBNull(lector.GetOrdinal("AMaterno")) ? default(string) : lector.GetString(lector.GetOrdinal("AMaterno")),
                            t_nombres = lector.IsDBNull(lector.GetOrdinal("Nombres")) ? default(string) : lector.GetString(lector.GetOrdinal("Nombres")),
                            t_documento = lector.IsDBNull(lector.GetOrdinal("TDocumento")) ? default(string) : lector.GetString(lector.GetOrdinal("TDocumento")),
                            c_documento_identidad = lector.IsDBNull(lector.GetOrdinal("NDocumento")) ? default(string) : lector.GetString(lector.GetOrdinal("NDocumento")),
                            sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(string) : lector.GetString(lector.GetOrdinal("sexo")),
                            d_fecha_nacimiento = Convert.ToDateTime(lector.IsDBNull(lector.GetOrdinal("FNacimiento")) ? default(string) : lector.GetString(lector.GetOrdinal("FNacimiento"))),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("Direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("Direccion")),
                            c_p_fono_personal = lector.IsDBNull(lector.GetOrdinal("Telefono")) ? default(string) : lector.GetString(lector.GetOrdinal("Telefono")),
                            //t_email_paciente = lector.IsDBNull(lector.GetOrdinal("t_email_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_paciente")),
                            //estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return paciente;
        }

        public IList<ADM_PACIENTEATENCIONRes> GetAllPacienteAtencionFilters(string t_dato, string tipo_dato)
        {
            List<ADM_PACIENTEATENCIONRes> atenciones = new List<ADM_PACIENTEATENCIONRes>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_ATENCION_GetAllFilter")))
            {
                //_database.AddInParameter(comando, "@n_historia_clinica", DbType.Int32, historia_clinica);
                //_database.AddInParameter(comando, "@n_cuenta_corriente", DbType.Int32, cuenta_corriente);
                //_database.AddInParameter(comando, "@t_nombre_paciente", DbType.String, nombre_paciente);
                //_database.AddInParameter(comando, "@d_fecha_atencion", DbType.DateTime, fecha_atencion);
                _database.AddInParameter(comando, "@t_dato", DbType.String, t_dato.ToUpper());
                _database.AddInParameter(comando, "@c_tipo_dato", DbType.String, tipo_dato.ToUpper());

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_PACIENTEATENCIONRes
                        {
                            n_historia_clinica = lector.IsDBNull(lector.GetOrdinal("n_historia_clinica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_historia_clinica")),
                            t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("t_apellido_paterno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_paterno")),
                            t_apellido_materno = lector.IsDBNull(lector.GetOrdinal("t_apellido_materno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_materno")),
                            t_nombres = lector.IsDBNull(lector.GetOrdinal("t_nombres")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombres")),
                            t_paciente = lector.IsDBNull(lector.GetOrdinal("t_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_paciente")),
                            d_fecha_nacimiento = lector.IsDBNull(lector.GetOrdinal("d_fecha_nacimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_nacimiento")),
                            id_genero = lector.IsDBNull(lector.GetOrdinal("id_genero")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_genero")),
                            Genero = lector.IsDBNull(lector.GetOrdinal("Genero")) ? default(string) : lector.GetString(lector.GetOrdinal("Genero")),
                            id_estado_civil = lector.IsDBNull(lector.GetOrdinal("id_estado_civil")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_estado_civil")),
                            EstadoCivil = lector.IsDBNull(lector.GetOrdinal("EstadoCivil")) ? default(string) : lector.GetString(lector.GetOrdinal("EstadoCivil")),
                            id_documento_identidad = lector.IsDBNull(lector.GetOrdinal("id_documento_identidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_identidad")),
                            c_documento_identidad = lector.IsDBNull(lector.GetOrdinal("c_documento_identidad")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_identidad")),
                            id_grupo_sanguineo = lector.IsDBNull(lector.GetOrdinal("id_grupo_sanguineo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_grupo_sanguineo")),
                            id_ocupacion = lector.IsDBNull(lector.GetOrdinal("id_ocupacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ocupacion")),
                            t_ocupacion = lector.IsDBNull(lector.GetOrdinal("t_ocupacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_ocupacion")),
                            t_email_paciente = lector.IsDBNull(lector.GetOrdinal("t_email_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_paciente")),
                            c_p_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_p_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_casa")),
                            c_p_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_p_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_personal")),
                            c_p_fono_corporativo = lector.IsDBNull(lector.GetOrdinal("c_p_fono_corporativo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_corporativo")),
                            id_ubigeo_nacimiento = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_nacimiento")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_nacimiento")),
                            UbigeoNacimiento = lector.IsDBNull(lector.GetOrdinal("UbigeoNacimiento")) ? default(string) : lector.GetString(lector.GetOrdinal("UbigeoNacimiento")),
                            id_ubigeo_domicilio = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_domicilio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_domicilio")),
                            UbigeoDomicilio = lector.IsDBNull(lector.GetOrdinal("UbigeoDomicilio")) ? default(string) : lector.GetString(lector.GetOrdinal("UbigeoDomicilio")),
                            t_referencia = lector.IsDBNull(lector.GetOrdinal("t_referencia")) ? default(string) : lector.GetString(lector.GetOrdinal("t_referencia")),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            t_responsable = lector.IsDBNull(lector.GetOrdinal("t_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_responsable")),
                            t_email_responsable = lector.IsDBNull(lector.GetOrdinal("t_email_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_responsable")),
                            c_r_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_r_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_casa")),
                            c_r_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_r_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_personal")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),
                            //atencion
                            id_atencion = lector.IsDBNull(lector.GetOrdinal("id_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_atencion")),
                            id_paciente = lector.IsDBNull(lector.GetOrdinal("id_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_paciente")),
                            id_tipo_paciente = lector.IsDBNull(lector.GetOrdinal("id_tipo_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_paciente")),
                            id_tipo_atencion = lector.IsDBNull(lector.GetOrdinal("id_tipo_atencion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_atencion")),
                            d_fecha_registro = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            c_hora_registro = lector.IsDBNull(lector.GetOrdinal("c_hora_registro")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_registro")),
                            n_paciente_derivado = lector.IsDBNull(lector.GetOrdinal("n_paciente_derivado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_paciente_derivado")),
                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            plan_seguro = lector.IsDBNull(lector.GetOrdinal("plan_seguro")) ? default(string) : lector.GetString(lector.GetOrdinal("plan_seguro")),
                            id_categoria_pago = lector.IsDBNull(lector.GetOrdinal("id_categoria_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_categoria_pago")),
                            categoria_pago = lector.IsDBNull(lector.GetOrdinal("categoria_pago")) ? default(string) : lector.GetString(lector.GetOrdinal("categoria_pago")),
                            c_codigo_asegurado = lector.IsDBNull(lector.GetOrdinal("c_codigo_asegurado")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_asegurado")),
                            c_contrato = lector.IsDBNull(lector.GetOrdinal("c_contrato")) ? default(string) : lector.GetString(lector.GetOrdinal("c_contrato")),
                            id_beneficio = lector.IsDBNull(lector.GetOrdinal("id_beneficio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_beneficio")),
                            codigo_beneficio = lector.IsDBNull(lector.GetOrdinal("codigo_beneficio")) ? default(string) : lector.GetString(lector.GetOrdinal("codigo_beneficio")),
                            beneficio = lector.IsDBNull(lector.GetOrdinal("beneficio")) ? default(string) : lector.GetString(lector.GetOrdinal("beneficio")),
                            id_documento_prestacion1 = lector.IsDBNull(lector.GetOrdinal("id_documento_prestacion1")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_prestacion1")),
                            documento_prestacion = lector.IsDBNull(lector.GetOrdinal("documento_prestacion")) ? default(string) : lector.GetString(lector.GetOrdinal("documento_prestacion")),
                            c_documento_prestacion1 = lector.IsDBNull(lector.GetOrdinal("c_documento_prestacion1")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_prestacion1")),
                            d_fecha_autorizacion1 = lector.IsDBNull(lector.GetOrdinal("d_fecha_autorizacion1")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_autorizacion1")),
                            //id_documento_prestacion2 = lector.IsDBNull(lector.GetOrdinal("id_documento_prestacion2")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_prestacion2")),
                            //c_documento_prestacion2 = lector.IsDBNull(lector.GetOrdinal("c_documento_prestacion2")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_prestacion2")),
                            //d_fecha_autorizacion2 = lector.IsDBNull(lector.GetOrdinal("d_fecha_autorizacion2")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_autorizacion2")),
                            id_tipo_filiacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_filiacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_filiacion")),
                            tipo_filiacion = lector.IsDBNull(lector.GetOrdinal("tipo_filiacion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_filiacion")),
                            t_nombre_titular = lector.IsDBNull(lector.GetOrdinal("t_nombre_titular")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombre_titular")),
                            id_tipo_afiliacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_afiliacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_afiliacion")),
                            tipo_afiliacion = lector.IsDBNull(lector.GetOrdinal("tipo_afiliacion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_afiliacion")),
                            //id_moneda = lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            n_copago_fijo = lector.IsDBNull(lector.GetOrdinal("n_copago_fijo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_fijo")),
                            n_copago_variable = lector.IsDBNull(lector.GetOrdinal("n_copago_variable")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable")),
                            id_tipo_diagnostico = lector.IsDBNull(lector.GetOrdinal("id_tipo_diagnostico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_diagnostico")),
                            tipo_diagnostico = lector.IsDBNull(lector.GetOrdinal("tipo_diagnostico")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_diagnostico")),
                            id_diagnostico = lector.IsDBNull(lector.GetOrdinal("id_diagnostico")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_diagnostico")),
                            codigo_diagnostico = lector.IsDBNull(lector.GetOrdinal("c_codigo_diagnostico")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_diagnostico")),
                            diagnostico = lector.IsDBNull(lector.GetOrdinal("diagnostico")) ? default(string) : lector.GetString(lector.GetOrdinal("diagnostico")),
                            id_profesional = lector.IsDBNull(lector.GetOrdinal("id_profesional")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_profesional")),
                            profesional = lector.IsDBNull(lector.GetOrdinal("profesional")) ? default(string) : lector.GetString(lector.GetOrdinal("profesional")),
                            c_numero_documento_profesional = lector.IsDBNull(lector.GetOrdinal("c_numero_documento_profesional")) ? default(string) : lector.GetString(lector.GetOrdinal("c_numero_documento_profesional")),
                            id_especialidad = lector.IsDBNull(lector.GetOrdinal("id_especialidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_especialidad")),
                            especialidad = lector.IsDBNull(lector.GetOrdinal("especialidad")) ? default(string) : lector.GetString(lector.GetOrdinal("especialidad")),

                            //n_copago_variable_far = lector.IsDBNull(lector.GetOrdinal("n_copago_variable_far")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable_far")),
                            //id_producto_plan = lector.IsDBNull(lector.GetOrdinal("id_producto_plan")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto_plan")),
                            //n_limite_cobertura = lector.IsDBNull(lector.GetOrdinal("n_limite_cobertura")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_limite_cobertura")),

                            //c_numero_placa = lector.IsDBNull(lector.GetOrdinal("c_numero_placa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_numero_placa")),
                            //n_deja_denuncia = lector.IsDBNull(lector.GetOrdinal("n_deja_denuncia")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_deja_denuncia")),
                            //n_deja_carta = lector.IsDBNull(lector.GetOrdinal("n_deja_carta")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_deja_carta")),
                            //t_observacion_accidente = lector.IsDBNull(lector.GetOrdinal("t_observacion_accidente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion_accidente")),
                            
                            //id_hospitalizacion = lector.IsDBNull(lector.GetOrdinal("id_hospitalizacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_hospitalizacion")),
                            //t_observacion_general = lector.IsDBNull(lector.GetOrdinal("t_observacion_general")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion_general")),
                            d_fecha_cierre = lector.IsDBNull(lector.GetOrdinal("d_fecha_cierre")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_cierre")),
                            c_hora_cierre = lector.IsDBNull(lector.GetOrdinal("c_hora_cierre")) ? default(string) : lector.GetString(lector.GetOrdinal("c_hora_cierre")),
                            //id_tipo_facturacion = lector.IsDBNull(lector.GetOrdinal("id_tipo_facturacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_facturacion")),
                            //n_a_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_a_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_no_gravado")),
                            //n_a_gravado = lector.IsDBNull(lector.GetOrdinal("n_a_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_gravado")),
                            //n_a_impuesto = lector.IsDBNull(lector.GetOrdinal("n_a_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_impuesto")),
                            //n_a_total = lector.IsDBNull(lector.GetOrdinal("n_a_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_a_total")),
                            //n_p_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_p_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_no_gravado")),
                            //n_p_gravado = lector.IsDBNull(lector.GetOrdinal("n_p_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_gravado")),
                            //n_p_impuesto = lector.IsDBNull(lector.GetOrdinal("n_p_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_impuesto")),
                            //n_p_total = lector.IsDBNull(lector.GetOrdinal("n_p_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_p_total")),
                            //n_g_no_gravado = lector.IsDBNull(lector.GetOrdinal("n_g_no_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_no_gravado")),
                            //n_g_gravado = lector.IsDBNull(lector.GetOrdinal("n_g_gravado")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_gravado")),
                            //n_g_impuesto = lector.IsDBNull(lector.GetOrdinal("n_g_impuesto")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_impuesto")),
                            //n_g_total = lector.IsDBNull(lector.GetOrdinal("n_g_total")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_g_total")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_PACIENTE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetById(ADM_PACIENTE entity)
        {
            List<ADM_PACIENTE> paciente = new List<ADM_PACIENTE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetById")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new ADM_PACIENTE
                        {
                            n_historia_clinica = lector.IsDBNull(lector.GetOrdinal("n_historia_clinica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_historia_clinica")),
                            t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("t_apellido_paterno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_paterno")),
                            t_apellido_materno = lector.IsDBNull(lector.GetOrdinal("t_apellido_materno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_materno")),
                            t_nombres = lector.IsDBNull(lector.GetOrdinal("t_nombres")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombres")),
                            t_paciente = lector.IsDBNull(lector.GetOrdinal("t_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_paciente")),
                            d_fecha_nacimiento = lector.IsDBNull(lector.GetOrdinal("d_fecha_nacimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_nacimiento")),
                            id_genero = lector.IsDBNull(lector.GetOrdinal("id_genero")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_genero")),
                            sexo = lector.IsDBNull(lector.GetOrdinal("Genero")) ? default(string) : lector.GetString(lector.GetOrdinal("Genero")),
                            id_estado_civil = lector.IsDBNull(lector.GetOrdinal("id_estado_civil")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_estado_civil")),
                            des_estadocivil = lector.IsDBNull(lector.GetOrdinal("EstadoCivil")) ? default(string) : lector.GetString(lector.GetOrdinal("EstadoCivil")),
                            id_documento_identidad = lector.IsDBNull(lector.GetOrdinal("id_documento_identidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_identidad")),
                            c_documento_identidad = lector.IsDBNull(lector.GetOrdinal("c_documento_identidad")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_identidad")),
                            id_grupo_sanguineo = lector.IsDBNull(lector.GetOrdinal("id_grupo_sanguineo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_grupo_sanguineo")),
                            id_ocupacion = lector.IsDBNull(lector.GetOrdinal("id_ocupacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ocupacion")),
                            t_ocupacion = lector.IsDBNull(lector.GetOrdinal("t_ocupacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_ocupacion")),
                            t_email_paciente = lector.IsDBNull(lector.GetOrdinal("t_email_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_paciente")),
                            c_p_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_p_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_casa")),
                            c_p_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_p_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_personal")),
                            c_p_fono_corporativo = lector.IsDBNull(lector.GetOrdinal("c_p_fono_corporativo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_corporativo")),
                            id_ubigeo_nacimiento = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_nacimiento")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_nacimiento")),
                            des_ubigeo_nacimiento = lector.IsDBNull(lector.GetOrdinal("UbigeoNacimiento")) ? default(string) : lector.GetString(lector.GetOrdinal("UbigeoNacimiento")),
                            id_ubigeo_domicilio = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_domicilio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_domicilio")),
                            des_ubigeo_domicilio = lector.IsDBNull(lector.GetOrdinal("UbigeoDomicilio")) ? default(string) : lector.GetString(lector.GetOrdinal("UbigeoDomicilio")),
                            t_referencia = lector.IsDBNull(lector.GetOrdinal("t_referencia")) ? default(string) : lector.GetString(lector.GetOrdinal("t_referencia")),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            t_responsable = lector.IsDBNull(lector.GetOrdinal("t_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_responsable")),
                            t_email_responsable = lector.IsDBNull(lector.GetOrdinal("t_email_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_responsable")),
                            c_r_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_r_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_casa")),
                            c_r_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_r_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_personal")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            id_usuarioCreacion = lector.IsDBNull(lector.GetOrdinal("id_user_registro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_registro")),
                            id_usuarioModifica = lector.IsDBNull(lector.GetOrdinal("id_user_modifica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_modifica")),
                            FechaCreacion = lector.IsDBNull(lector.GetOrdinal("fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_registro")),
                            FechaModificacion = lector.IsDBNull(lector.GetOrdinal("fecha_modifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_modifica"))

                        });
                    }
                }
            }

            return paciente;
        }

        public int Update(ADM_PACIENTE entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Update")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.Int32, entity.n_historia_clinica);
                _database.AddInParameter(comando, "@t_apellido_paterno", DbType.String, entity.t_apellido_paterno);
                _database.AddInParameter(comando, "@t_apellido_materno", DbType.String, entity.t_apellido_materno);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_paciente", DbType.String, entity.t_paciente);
                _database.AddInParameter(comando, "@d_fecha_nacimiento", DbType.DateTime, entity.d_fecha_nacimiento);
                _database.AddInParameter(comando, "@id_genero", DbType.Int32, entity.id_genero);
                _database.AddInParameter(comando, "@id_estado_civil", DbType.Int32, entity.id_estado_civil);
                _database.AddInParameter(comando, "@id_documento_identidad", DbType.Int32, entity.id_documento_identidad);
                _database.AddInParameter(comando, "@c_documento_identidad", DbType.String, entity.c_documento_identidad);
                _database.AddInParameter(comando, "@id_grupo_sanguineo", DbType.Int32, entity.id_grupo_sanguineo);
                _database.AddInParameter(comando, "@id_ocupacion", DbType.Int32, entity.id_ocupacion);
                _database.AddInParameter(comando, "@t_ocupacion", DbType.String, entity.t_ocupacion);
                _database.AddInParameter(comando, "@t_email_paciente", DbType.String, entity.t_email_paciente);
                _database.AddInParameter(comando, "@c_p_fono_casa", DbType.String, entity.c_p_fono_casa);
                _database.AddInParameter(comando, "@c_p_fono_personal", DbType.String, entity.c_p_fono_personal);
                _database.AddInParameter(comando, "@c_p_fono_corporativo", DbType.String, entity.c_p_fono_corporativo);
                _database.AddInParameter(comando, "@id_ubigeo_nacimiento", DbType.Int32, entity.id_ubigeo_nacimiento);
                _database.AddInParameter(comando, "@id_ubigeo_domicilio", DbType.Int32, entity.id_ubigeo_domicilio);
                _database.AddInParameter(comando, "@t_referencia", DbType.String, entity.t_referencia);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_responsable", DbType.String, entity.t_responsable);
                _database.AddInParameter(comando, "@t_email_responsable", DbType.String, entity.t_email_responsable);
                _database.AddInParameter(comando, "@c_r_fono_casa", DbType.String, entity.c_r_fono_casa);
                _database.AddInParameter(comando, "@c_r_fono_personal", DbType.String, entity.c_r_fono_personal);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_modifica", DbType.Int32, entity.id_usuarioModifica);
                _database.AddInParameter(comando, "@d_fecha_modifica", DbType.DateTime, entity.FechaModificacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }
    }
}
