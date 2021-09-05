using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_TIPIFICACION;
using Romsoft.GESTIONCLINICA.Entidades.FAR_TIPIFICACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAR_TIPIFICACIONController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var tipificacionList = FAR_TIPIFICACIONBL.Instancia.GetAllActives();
                var docidentidadDTOList = MapperHelper.Map<IEnumerable<FAR_TIPIFICACION>, IEnumerable<FAR_TIPIFICACIONDTO>>(tipificacionList);
                jsonResponse.Data = tipificacionList;
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