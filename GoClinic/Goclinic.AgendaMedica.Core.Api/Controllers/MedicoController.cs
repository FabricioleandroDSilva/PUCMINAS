using Goclinic.AgendaMedica.Core.Business;
using Goclinic.AgendaMedica.Core.Business.Interfaces;
using Goclinic.AgendaMedica.Core.Business.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

using System.Threading.Tasks;

namespace Goclinic.AgendaMedica.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MedicoController : Controller
    {
        /// <summary>
        /// Api módulo de agendamento medico
        /// </summary>
        /// <returns></returns>
        private readonly IMedicoRepository _medico;
        private readonly IUsuarioRepository _usuario;
        public MedicoController(IMedicoRepository medico, IUsuarioRepository usuario)
        {
            _medico = medico;
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
        [HttpPost("AdicionarMedico")]

        public async Task<ActionResult<Medico>> AdicionarMedico(Medico Medicos)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    await _medico.Adicionar(Medicos);
                    return Ok(Medicos);
                }
                return Ok("Usuário não autenticado.");


            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
