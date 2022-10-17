using InjecaoDependenciaExemplo.Interfaces;
using InjecaoDependenciaExemplo.Models;
using InjecaoDependenciaExemplo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InjecaoDependenciaExemplo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExemploService _exemploService;
        private readonly IExemploTransient _transientExemplo;
        private readonly IExemploScoped _scopedExemplo;
        private readonly IExemploSingleton _singletonExemplo;
        private readonly IExemploSingletonInstance _singletonInstanceExemplo;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,
            ExemploService exemploService,
            IExemploTransient transientExemplo,
            IExemploScoped scopedExemplo,
            IExemploSingleton singletonExemplo,
            IExemploSingletonInstance singletonInstanceExemplo)
        {
            _logger = logger;

            _exemploService = exemploService;
            _transientExemplo = transientExemplo;
            _scopedExemplo = scopedExemplo;
            _singletonExemplo = singletonExemplo;
            _singletonInstanceExemplo = singletonInstanceExemplo;
        }

        public IActionResult Index()
        {
            // ViewBag contando os exemplos de requisição
            ViewBag.Transient = _transientExemplo;
            ViewBag.Scoped = _scopedExemplo;
            ViewBag.Singleton = _singletonExemplo;
            ViewBag.SingletonInstance = _singletonInstanceExemplo;

            // Serviço das requisições
            ViewBag.Service = _exemploService;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}