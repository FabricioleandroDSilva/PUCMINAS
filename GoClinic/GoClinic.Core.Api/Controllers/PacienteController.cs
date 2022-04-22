using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using Goclinic.Agendamento.Business.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Goclinic.Core.Business;
using System.Threading.Tasks;

namespace GoClinic.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public  class PacienteController : Controller
    {
    
        /// <summary>
        /// Api módulo de agendamento de pacientes
        /// </summary>
        /// <returns></returns>
        private readonly IPacienteRepository _paciente;
          
        public PacienteController(IPacienteRepository paciente)
        {
            _paciente = paciente;
                
        }
        [HttpPost("AdicionarPaciente")]
        public async Task<ActionResult<Paciente>> AdicionarPaciente(Paciente pacientes)
        {
            try
            {
               await _paciente.Adicionar(pacientes);
                return Ok();

            }
             catch(Exception ex)
            {
              
            }
            return Ok();
        }

        [HttpPost("AdicionarAgendamento")]
        public async Task<ActionResult<Paciente>> AdicionarAgendamento(Paciente pacientes)
        {
            try
            {
               // await _paciente.Adicionar(pacientes);
                return Ok();

            }
            catch (Exception ex)
            {

            }
            return Ok();
        }

        [HttpGet("ListarAtendimento")]
        public async Task<ActionResult<Paciente>> ListarAtendimento(Paciente pacientes)
        {
            try
            {
                // await _paciente.Adicionar(pacientes);
                return Ok();

            }
            catch (Exception ex)
            {

            }
            return Ok();
        }

    }
}
