using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_FORMA_PAGODTO;
using Romsoft.GESTIONCLINICA.Entidades.ADM_FORMA_PAGO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_FORMA_PAGOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllFormaPagoActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                //var paciente = MapperHelper.Map<ADM_PACIENTEDTO, ADM_PACIENTE>(pacienteDTO);

                var formapagoList = ADM_FORMA_PAGOBL.Instancia.GetAllActives();
                var formapagoDTOList = MapperHelper.Map<IEnumerable<ADM_FORMA_PAGORes>, IEnumerable<ADM_FORMA_PAGOResDTO>>(formapagoList);

                if (formapagoList.Count <= 0)
                {
                    jsonResponse.Message = "No existe información de forma de pagos.";
                }

                jsonResponse.Data = formapagoDTOList;
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
