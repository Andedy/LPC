using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Domain.Entities;
using contasLuz.Repositories.Interfaces;

namespace contasLuz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaLuzController : ControllerBase
    {
        private IContaLuzRepositories Repositories;
        private IImovelRepositories imovelRepositories;

        public ContaLuzController(IContaLuzRepositories Repositories, IImovelRepositories imovelRepositories)
        {
            this.Repositories = Repositories;
            this.imovelRepositories = imovelRepositories;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<ContaLuz>> Get()
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = Repositories.GetAll()
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<ContaLuz> Get(int id)
        {
            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = Repositories.GetByID(id)
            });
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ContaLuz entity)
        {
            var imovel = imovelRepositories.GetByID(entity.idimovel);

            if (imovel != null)
                entity.imovel = imovel;

            Repositories.Create(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ContaLuz entity)
        {
            var imovel = imovelRepositories.GetByID(entity.idimovel);

            if (imovel != null)
                entity.imovel = imovel;

            Repositories.Update(entity);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = entity
            });
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Repositories.Delete(id);

            return Ok(new
            {
                status = "200",
                msg = "OK",
                obj = new { }
            });
        }
    }
}
