using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE
{
    public class ADM_PACIENTEATENCIONRes
    {
        public int n_historia_clinica { get; set; }
        public string t_apellido_paterno { get; set; }
        public string t_apellido_materno { get; set; }
        public string t_nombres { get; set; }
        public string t_paciente { get; set; }
        public DateTime d_fecha_nacimiento { get; set; }
        public int id_genero { get; set; }
        public string Genero { get; set; }
        public int id_estado_civil { get; set; }
        public string EstadoCivil { get; set; }
        public int id_documento_identidad { get; set; }
        public string c_documento_identidad { get; set; }
        public int id_grupo_sanguineo { get; set; }
        public int id_ocupacion { get; set; }
        public string t_ocupacion { get; set; }
        public string t_email_paciente { get; set; }
        public string c_p_fono_casa { get; set; }
        public string c_p_fono_personal { get; set; }
        public string c_p_fono_corporativo { get; set; }
        public int id_ubigeo_nacimiento { get; set; }
        public string UbigeoNacimiento { get; set; }
        public int id_ubigeo_domicilio { get; set; }
        public string UbigeoDomicilio { get; set; }
        public string t_referencia { get; set; }
        public string t_direccion { get; set; }
        public string t_responsable { get; set; }
        public string t_email_responsable { get; set; }
        public string c_r_fono_casa { get; set; }
        public string c_r_fono_personal { get; set; }
        public int f_estado { get; set; }
        public string estado { get; set; }

        //-----
        //Atencion
        //---- -

        public int id_atencion { get; set; }
        public int id_paciente { get; set; }
        public int id_tipo_paciente { get; set; }
        public int id_tipo_atencion { get; set; }
        public DateTime d_fecha_registro { get; set; }
        public string c_hora_registro { get; set; }
        public int n_paciente_derivado { get; set; }
        public int id_plan_seguro { get; set; }
        public string plan_seguro { get; set; }
        public int id_categoria_pago { get; set; }
        public string categoria_pago { get; set; }
        public string c_codigo_asegurado { get; set; }
        public string c_contrato { get; set; }
        public int id_beneficio { get; set; }
        public string codigo_beneficio { get; set; }
        public string beneficio { get; set; }
        public int id_documento_prestacion1 { get; set; }
        public string documento_prestacion { get; set; }
        public string c_documento_prestacion1 { get; set; }
        public DateTime d_fecha_autorizacion1 { get; set; }
        public int id_documento_prestacion2 { get; set; }
        public string c_documento_prestacion2 { get; set; }
        public DateTime d_fecha_autorizacion2 { get; set; }
        public int id_tipo_filiacion { get; set; }
        public string tipo_filiacion { get; set; }
        public string t_nombre_titular { get; set; }
        public int id_tipo_afiliacion { get; set; }
        public string tipo_afiliacion { get; set; }
        public int id_moneda { get; set; }
        public decimal n_copago_fijo { get; set; }
        public decimal n_copago_variable { get; set; }
        public decimal n_copago_variable_far { get; set; }
        public int id_producto_plan { get; set; }
        public decimal n_limite_cobertura { get; set; }
        public int id_tipo_diagnostico { get; set; }
        public int id_diagnostico { get; set; }
        
        public string tipo_diagnostico { get; set; }
        public string codigo_diagnostico { get; set; }
        public string diagnostico { get; set; }
        public string c_numero_placa { get; set; }
        public int n_deja_denuncia { get; set; }
        public int n_deja_carta { get; set; }
        public string t_observacion_accidente { get; set; }
        public int id_profesional { get; set; }
        public string profesional { get; set; }
        public string c_numero_documento_profesional { get; set; }

        public int id_especialidad { get; set; }
        public string especialidad { get; set; }

        public int id_hospitalizacion { get; set; }
        public string t_observacion_general { get; set; }
        public DateTime d_fecha_cierre { get; set; }
        public string c_hora_cierre { get; set; }
        public int id_tipo_facturacion { get; set; }
        //public decimal n_a_no_gravado { get; set; }
        //public decimal n_a_gravado { get; set; }
        //public decimal n_a_impuesto { get; set; }
        //public decimal n_a_total { get; set; }
        //public decimal n_p_no_gravado { get; set; }
        //public decimal n_p_gravado { get; set; }
        //public decimal n_p_impuesto { get; set; }
        //public decimal n_p_total { get; set; }
        //public decimal n_g_no_gravado { get; set; }
        //public decimal n_g_gravado { get; set; }
        //public decimal n_g_impuesto { get; set; }
        //public decimal n_g_total { get; set; }
        //public int f_estado { get; set; }
    }

}
