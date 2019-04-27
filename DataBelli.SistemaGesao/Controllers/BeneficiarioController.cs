using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBelli.Gestao.Data;
using DataBelli.SistemaGestao.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataBelli.SistemaGestao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly DataContext context;

        public BeneficiarioController(DataContext context) => this.context = context;

        // GET: api/Beneficiario
        [HttpGet]
        public IEnumerable<Beneficiario> Get()
        {
            var beneficiario = context.Beneficiarios.ToList();
            return beneficiario;
        }

        // GET: api/Beneficiario/5
        [HttpGet("{id}", Name = "Get")]
        public Beneficiario Get(int id)
        {
            var beneficiario = context.Beneficiarios.FirstOrDefault(b => b.Id == id);
            return beneficiario;
        }

        // POST: api/Beneficiario
        [HttpPost]
        public void Post([FromBody] Beneficiario beneficiario)
        {
            context.Beneficiarios.Add(beneficiario);
            context.SaveChanges();
        }

        // PUT: api/Beneficiario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
