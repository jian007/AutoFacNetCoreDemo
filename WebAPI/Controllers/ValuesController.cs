using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using DataModels;
//using LinqToDB;
//using LinqToDB.Data;
using Microsoft.AspNetCore.Mvc;
using ModelsEntity;
using Repository.IDAL;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        protected readonly IautofacdemoDAL iautofacdemoDAL;

        public ValuesController(IautofacdemoDAL iautofacdemoDAL)
        {
            this.iautofacdemoDAL = iautofacdemoDAL;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<Test> authroles = new List<Test>();
            Test role = null;
            for (int i = 1; i < 100; i++)
            {
                role = new Test();
                role.Id = i;
                role.Name = "管理者" + i.ToString();
               
                authroles.Add(role);
            }
            
            string exs = string.Empty;
            List<Test> tests = new List<Test>();
            try
            {
                tests = iautofacdemoDAL.GetList().ToList();
            }
            catch (Exception ex)
            {

                exs=ex.Message;
            }

            return Ok(tests);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
