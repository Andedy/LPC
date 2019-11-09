using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using contasLuz.Domain.Entities;
using contasLuz.Repositories.Interfaces;

namespace contasLuz.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private IImovelRepositories Repositories;

        public ImovelController(IImovelRepositories Repositories)
        {
            this.Repositories = Repositories;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Imovel>> Get()
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
        public ActionResult<Imovel> Get(int id)
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
        public ActionResult Post([FromBody] Imovel entity)
        {
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
        public ActionResult Put(int id, [FromBody] Imovel entity)
        {
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
