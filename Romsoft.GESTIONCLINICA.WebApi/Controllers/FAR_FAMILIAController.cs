using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_FAMILIA;
using Romsoft.GESTIONCLINICA.Entidades.FAR_FAMILIA;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAR_FAMILIAController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var familiaList = FAR_FAMILIABL.Instancia.GetAllActives();
                var docidentidadDTOList = MapperHelper.Map<IEnumerable<FAR_FAMILIA>, IEnumerable<FAR_FAMILIADTO>>(familiaList);
                jsonResponse.Data = familiaList;
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