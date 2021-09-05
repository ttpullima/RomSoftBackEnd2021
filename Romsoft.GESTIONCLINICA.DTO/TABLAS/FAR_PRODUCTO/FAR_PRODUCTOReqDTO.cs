using System;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_PRODUCTO
{
    public class FAR_PRODUCTOReqDTO
    {
		public int id_producto { get; set; }
		public string t_codigo { get; set; }
		public string t_descripcion { get; set; }
		public string t_presentacion { get; set; }
		public string t_rutaimagen { get; set; }
		public int id_tipo_producto { get; set; }
		public int id_clase { get; set; }
		public int id_generico { get; set; }
		public int id_familia { get; set; }
		public int id_tipificacion { get; set; }
		public string c_gtin { get; set; }
		public string c_unspsc { get; set; }
		public decimal n_stockmin { get; set; }
		public decimal n_stockmax { get; set; }
		public decimal n_pcosto { get; set; }
		public decimal n_pvf { get; set; }
		public decimal n_utilidad { get; set; }
		public decimal n_pvs { get; set; }
		public decimal n_plista { get; set; }
		public int f_inafecto { get; set; }
		public int id_consignacion { get; set; }
		public int id_laboratorio { get; set; }
		public int id_proveedor { get; set; }
		public decimal n_dscto_1 { get; set; }
		public decimal n_dscto_2 { get; set; }
		public int f_estado { get; set; }
		public int n_valorizado { get; set; }
		public int id_user_registro { get; set; }
		public DateTime d_fecha_registro { get; set; }
	}
}
