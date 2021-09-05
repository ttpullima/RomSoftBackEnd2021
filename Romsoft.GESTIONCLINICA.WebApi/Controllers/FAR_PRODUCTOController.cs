using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.FAR_PRODUCTO;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.Entidades.FAR_PRODUCTO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class FAR_PRODUCTOController : BaseController
    {
        [HttpPost]
        public JsonResponse Add(FAR_PRODUCTOReqDTO farproductoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                string Mensaje = "";

                var farproducto = MapperHelper.Map<FAR_PRODUCTOReqDTO, FAR_PRODUCTOReq>(farproductoDTO);

                //if (!ADM_ATENCIONBL.Instancia.Exists(atencion))
                //{
                var resultado1 = FAR_PRODUCTOBL.Instancia.Add2(farproducto);

                if (resultado1.Item1 > 0)
                {
                    jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                    jsonResponse.Data = resultado1.Item1;  //Retorna Item
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = resultado1.Item2; //Mensajes.RegistroFallido;
                }
                //}
                //else
                //{
                //    jsonResponse.Warning = true;
                //    jsonResponse.Message = Mensajes.YaExisteRegistro;
                //}

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = farproductoDTO.id_user_registro.ToString(),
                    Objeto = JsonConvert.SerializeObject(farproductoDTO)
                });
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
                    Usuario = farproductoDTO.id_user_registro.ToString(),
                    Objeto = JsonConvert.SerializeObject(farproductoDTO)
                });
            }

            return jsonResponse;
        }


        [HttpPost]
        public JsonResponse Update(FAR_PRODUCTOReqDTO farproductoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                string Mensaje = "";

                var farproducto = MapperHelper.Map<FAR_PRODUCTOReqDTO, FAR_PRODUCTOReq>(farproductoDTO);

                //if (!ADM_ATENCIONBL.Instancia.Exists(atencion))
                //{
                var resultado1 = FAR_PRODUCTOBL.Instancia.Update2(farproducto);

                if (resultado1.Item1 > 0)
                {
                    jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = resultado1.Item2; //Mensajes.RegistroFallido;
                }
                //}
                //else
                //{
                //    jsonResponse.Warning = true;
                //    jsonResponse.Message = Mensajes.YaExisteRegistro;
                //}

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = farproductoDTO.id_user_registro.ToString(),
                    Objeto = JsonConvert.SerializeObject(farproductoDTO)
                });
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
                    Usuario = farproductoDTO.id_user_registro.ToString(),
                    Objeto = JsonConvert.SerializeObject(farproductoDTO)
                });
            }

            return jsonResponse;
        }


        [HttpPost]
        public JsonResponse GetById(int idProducto)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var farproductoList = FAR_PRODUCTOBL.Instancia.GetProductoById(idProducto);
                var farproductoDTOList = MapperHelper.Map<IEnumerable<FAR_PRODUCTOByIdRes>, IEnumerable<FAR_PRODUCTOByIdResDTO>>(farproductoList);
                jsonResponse.Data = farproductoDTOList;
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