using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAC_DOCUMENTO_PAGO;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.Entidades.FAC_DOCUMENTO_PAGO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAC_DOCUMENTO_PAGOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllDocumentoPagoFilters(FAC_DOCUMENTO_PAGORequest documentoPagoDtoReq)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                //var documentoPago = MapperHelper.Map<FAC_DOCUMENTO_PAGODTO, FAC_DOCUMENTO_PAGO>(documentoPagoDto);

                var documentoPagoList = FAC_DOCUMENTO_PAGOBL.Instancia.GetAllFacDocumentoPagoFilters(documentoPagoDtoReq.c_dato);
                var documentoPagoDTOList = MapperHelper.Map<IEnumerable<FAC_DOCUMENTO_PAGO>, IEnumerable<FAC_DOCUMENTO_PAGODTO>>(documentoPagoList);
                jsonResponse.Data = documentoPagoDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse addComprobante(FAC_COMPROBANTEReqDTO ReqComprobanteDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {

                //int resultado = 0;
                var cabDetalle = MapperHelper.Map<FAC_COMPROBANTEReqDTO, FAC_COMPROBANTEReq>(ReqComprobanteDTO);

                string idprueba = "0";

                if (!PruebaBL.Instancia.Exists(idprueba))
                {
                   var resultado = FAC_DOCUMENTO_PAGOBL.Instancia.Add2(cabDetalle);

                    if (resultado.Item1 > 0)
                    {
                        jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                    }
                    else
                    {
                        jsonResponse.Warning = true;
                        jsonResponse.Message = resultado.Item2; //Mensajes.RegistroFallido;
                    }
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.YaExisteRegistro;
                }

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = jsonResponse.Message,
                    Usuario = Convert.ToString(ReqComprobanteDTO.id_user_registro.ToString()),
                    Objeto = JsonConvert.SerializeObject(ReqComprobanteDTO)
                }); ; ;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = ex.Message,
                    Usuario = Convert.ToString(ReqComprobanteDTO.id_user_registro.ToString()),
                    Objeto = JsonConvert.SerializeObject(ReqComprobanteDTO)
                });
            }

            return jsonResponse;
        }

    }
}
