using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace LoggerSample.Controllers
{
    [Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void index()
        {
            // Utilização apenas durante o desenvolvimento
            _logger.LogTrace("Log de Trace");
            _logger.LogDebug("Log de Debug");

            // Apenas para informações
            _logger.LogInformation("Log de Informação");

            // Exemplo, erro 404
            _logger.LogWarning("Log de Aviso");

            // Log para registrar os erros
            _logger.LogError("Log de Erro");

            // Ameaça a performance, a saude da aplicação
            _logger.LogCritical("Log de Problema Critico");
        }
    }
}