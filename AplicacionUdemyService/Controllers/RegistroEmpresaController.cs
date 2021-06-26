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

        public RegistroEmpresaController()
        {
            paisesDTO = new PaisesDTO();
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

    }
}
