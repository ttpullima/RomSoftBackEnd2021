using System;

namespace Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE
{
    public class ADM_PACIENTEATENCIONReq
    {
        public int historia_clinica { get; set; }
        public int cuenta_corriente { get; set; }
        public string nombre_paciente { get; set; }
        public DateTime fecha_atencion { get; set; }
        public char tipo_dato { get; set; }
    }
}
