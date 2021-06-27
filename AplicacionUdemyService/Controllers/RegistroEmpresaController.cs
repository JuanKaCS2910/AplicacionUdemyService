using AplicacionUdemyService.Datos;
using AplicacionUdemyService.Entity.Parametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AplicacionUdemyService.Controllers
{
    [RoutePrefix("api/RegistroEmpresa")]
    public class RegistroEmpresaController : ApiController
    {
        private PaisesDTO paisesDTO;
        private MonedaDTO monedaDTO;

        public RegistroEmpresaController()
        {
            paisesDTO = new PaisesDTO();
            monedaDTO = new MonedaDTO();
        }

        [HttpPost]
        [Route("listarPaises")]
        public IHttpActionResult listarPaises(RegistroEmpresaEntity paramss)
        {
            try
            {
                var _result = paisesDTO.listarPaises(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarMonedas")]
        public IHttpActionResult listarMonedas(RegistroEmpresaEntity paramss)
        {
            try
            {
                var _result = monedaDTO.listarMonedas(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
