using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demonstracao3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demonstracao3.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly List<Pessoa> _pessoas;
        public PessoaController()
        {
            _pessoas = new List<Pessoa>();
            _pessoas.Add(new Pessoa(1,"Paulo","123"));
            _pessoas.Add(new Pessoa(2,"Agnes","223"));
            _pessoas.Add(new Pessoa(3,"Thales","641"));
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> Get()
        {
            return _pessoas;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Pessoa> Get(int id)
        {
            Pessoa pessoa = _pessoas.FirstOrDefault(x => x.Id == id);
                if  (pessoa==null) return NotFound();
            return pessoa;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
