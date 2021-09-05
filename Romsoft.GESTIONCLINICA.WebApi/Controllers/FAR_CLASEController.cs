using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_CLASE;
using Romsoft.GESTIONCLINICA.Entidades.FAR_CLASE;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAR_CLASEController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var claseList = FAR_CLASEBL.Instancia.GetAllActives();
                var docidentidadDTOList = MapperHelper.Map<IEnumerable<FAR_CLASE>, IEnumerable<FAR_CLASEDTO>>(claseList);
                jsonResponse.Data = claseList;
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