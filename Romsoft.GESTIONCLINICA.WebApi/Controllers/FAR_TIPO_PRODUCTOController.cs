
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_TIPO_PRODUCTO;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPO_PRODUCTO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAR_TIPO_PRODUCTOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var genericoList = FAR_TIPO_PRODUCTOBL.Instancia.GetAllActives();
                var docidentidadDTOList = MapperHelper.Map<IEnumerable<FAR_TIPO_PRODUCTO>, IEnumerable<FAR_TIPO_PRODUCTODTO>>(genericoList);
                jsonResponse.Data = genericoList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }
    }
}