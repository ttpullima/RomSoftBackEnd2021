using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_TARIFARIO_SEGUS
{
    public class CVN_TARIFARIO_SEGUS_PRICEDTO
    {
        //
        public int id_tarifario_segus { get; set; }
        public string c_codigo { get; set; }
        public string t_descripcion { get; set; }
        public string t_observacion { get; set; }
        public decimal Precio { get; set; }
        public int cantidad { get; set; }
        public int id_clasificacion_segus { get; set; }
        public string t_clasificacion_segus { get; set; }
        public string estado { get; set; }
    }
}
