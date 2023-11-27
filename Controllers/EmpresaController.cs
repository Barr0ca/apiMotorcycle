using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiMotorcycle.Context;
using apiMotorcycle.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiMotorcycle.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly ILogger<Empresas> _logger;
        private readonly EmpresaContext _context;

        public EmpresaController(ILogger<Empresas> logger, EmpresaContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet(Name = "empresa")]

        public ActionResult<IEnumerable<Empresas>> Get()
        {
            var empresas = _context.Empresas.ToList();
            if(empresas is null)
                return NotFound();
            
            return empresas;
        }

        [HttpPost]
        public ActionResult Post(Empresas empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();

            return new CreatedAtRouteResult("empresa",
                new{id = empresa.ID},
                empresa);
        }
    }
}