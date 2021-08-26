namespace Romsoft.GESTIONCLINICA.Entidades.ADM_TIPO_PACIENTE
{
    public class ADM_TIPO_PACIENTE
    {
        public int id_tipo_paciente { get; set; }
        public string  c_codigo { get; set; }
        public string t_descripcion { get; set; }
        //adicionales
        public int  id_moneda { get; set; }
        public decimal n_copago_variable { get; set; }
        public decimal n_copago_variable_far { get; set; }
        public int f_siteds { get; set; }

    }
}
