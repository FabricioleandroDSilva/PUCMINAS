using Goclinic.Core.Business;
using GoClinic.Agendamento.Core.UI.Models;
using GoClinic.Core.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace GoClinic.Agendamento.Core.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public  const string URL  = "http://localhost:34941/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DadosCadastrais()
        {

            return View();
        }

        public IActionResult NovoPaciente()
        {
            return View();
        }
            [HttpPost]
        public IActionResult NovoPaciente(Paciente paciente)
        {
            try
            {
                if (!string.IsNullOrEmpty(paciente.Nome))
                {
                    HttpClientHandler clientHandler = new HttpClientHandler();
                    clientHandler.ServerCertificateCustomValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };
                    

                    using (var client = new HttpClient(clientHandler))
                    {

                        client.BaseAddress = new Uri(URL);
                        var postTask = client.PostAsJsonAsync<Paciente>("api/Paciente/AdicionarPaciente", paciente);
                        postTask.Wait();
                        var result = postTask.Result;

                        if (result.IsSuccessStatusCode)
                        {
                            return View("Index");
                        }

                    }
                }

                ModelState.AddModelError(string.Empty, "Erro no Servidor. Contacte o Administrador.");
                return View(paciente);
            }
            catch(Exception ex)
            {
                return View(ex);
            }
           

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
