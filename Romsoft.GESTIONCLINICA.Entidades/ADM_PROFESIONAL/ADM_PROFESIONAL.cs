using Romsoft.GESTIONCLINICA.Entidades.Core;
using System;

namespace Romsoft.GESTIONCLINICA.Entidades.ADM_PROFESIONAL
{
    public class ADM_PROFESIONAL : EntityAuditable
    {
        public int id_profesional {get;set;}
        public string c_codigo { get; set; }
        public string t_apellidos { get; set; }
        public string t_nombres { get; set; }
        public string t_medico { get; set; }
        public string t_direccion { get; set; }
        public string t_observacion { get; set; }
        public DateTime d_fecha_nace { get; set; }
        public int  id_genero { get; set; }
        public int  id_tipo_documento { get; set; }
        public string c_numero_documento { get; set; }
        public int id_especialidad { get; set; }
        public string c_nro_especialidad { get; set; }
        public int id_tipo_profesional { get; set; }
        public string c_colegiatura { get; set; }
        public int id_condicion_profesional { get; set; }
        public string c_telefono_1 { get; set; }
        public string c_telefono_2 { get; set; }
        public int f_estado { get; set; }

        //Response

    }
}
