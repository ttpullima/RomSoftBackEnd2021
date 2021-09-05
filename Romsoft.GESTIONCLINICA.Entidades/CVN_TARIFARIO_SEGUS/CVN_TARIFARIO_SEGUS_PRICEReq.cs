using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Entidades.CVN_TARIFARIO_SEGUS
{
    public class CVN_TARIFARIO_SEGUS_PRICEReq
    {
        //
        public int id_categoria_pago { get; set; }
        public string valor { get; set; }
        public string c_idioma { get; set; }
    }
}
