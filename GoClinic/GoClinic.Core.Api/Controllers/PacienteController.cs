using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


using Goclinic.Agendamento.Business.Interfaces;

using Goclinic.Core.Business;
using System.Threading.Tasks;
using Goclinic.Agendamento.Core.Business.Models;
using Goclinic.Agendamento.Core.Business.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Goclinic.Agendamento.Core.Business;

namespace GoClinic.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public  class PacienteController : Controller
    {
    
        /// <summary>
        /// Api módulo de agendamento de pacientes
        /// </summary>
        /// <returns></returns>
        private readonly IPacienteRepository _paciente;
        private readonly IUsuarioRepository _usuario;
          
        public PacienteController(IPacienteRepository paciente, IUsuarioRepository usuario)
        {
            _paciente = paciente;
            _usuario = usuario;


        }
        
        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<Usuario>> Login(Usuario usuario)
        {
            try
            {
                var user = _usuario.Autenticar(usuario);
                if (user != null)
                {
                    var token = TokenService.GerarToken(user);
                   
                    return Ok(token);
                }

                else
                    return NotFound("Usuario ou senha incorretos, tente novamente");

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpGet("Logout"), Authorize]
        public async Task<ActionResult<Usuario>> Logout()
        {
            try
            {
                await HttpContext.SignOutAsync();
                return Ok("Logout efetuado com sucesso. ");
               

            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpPost("AdicionarPaciente")]
        public async Task<ActionResult<Paciente>> AdicionarPaciente(Paciente pacientes)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    await _paciente.Adicionar(pacientes);
                    return Ok(pacientes);
                }
                return Ok("Usuário não autenticado.");


            }
             catch(Exception ex)
            {
                return Ok(ex.Message);
            }

        }  
    }
}
