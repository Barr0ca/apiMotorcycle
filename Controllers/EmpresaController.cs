using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiMotorcycle.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiMotorcycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly ILogger<Empresas> _logger;

        public EmpresaController(ILogger<Empresas> logger)
        {
            _logger = logger;
        }
    }
}