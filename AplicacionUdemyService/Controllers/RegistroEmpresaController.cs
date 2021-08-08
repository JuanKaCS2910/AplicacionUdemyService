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
        private ImpuestoDTO impuestoDTO;
        private PorcentajeDTO porcentajeDTO;
        private EmpresaDTO empresaDTO;

        public RegistroEmpresaController()
        {
            paisesDTO = new PaisesDTO();
            monedaDTO = new MonedaDTO();
            impuestoDTO = new ImpuestoDTO();
            porcentajeDTO = new PorcentajeDTO();
            empresaDTO = new EmpresaDTO();
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

        [HttpPost]
        [Route("listarImpuestos")]
        public IHttpActionResult listarImpuesto(RegistroEmpresaEntity paramss)
        {
            try
            {
                var _result = impuestoDTO.listarImpuesto(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("listarPorcentajes")]
        public IHttpActionResult listarPorcentaje(RegistroEmpresaEntity paramss)
        {
            try
            {
                var _result = porcentajeDTO.listarPorcentaje(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("validarRegistro")]
        public IHttpActionResult validarRegistro(RegistroEmpresaEntity paramss)
        {
            try
            {
                var _result = empresaDTO.validarRegistro(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        [Route("insertarEmpresa")]
        public IHttpActionResult insertarEmpresa(RegistroEmpresaDTOEntity paramss)
        {
            try
            {
                var _result = empresaDTO.insertarEmpresa(paramss);
                return Ok(_result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
