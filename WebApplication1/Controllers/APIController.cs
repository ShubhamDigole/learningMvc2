using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        classData data = null;
        public APIController(classData data)
        {
            this.data = data;
        }
        // GET: api/API
        [HttpGet]
        public List<stuClass> Get()
        {
           
            List<stuClass> data = this.data.stuClasses.ToList<stuClass>();
            return data;
        }

        // GET: api/API/5
        [HttpGet("{id}", Name = "Get")]
        public List<stuClass> Get(string id)
        {
            List<stuClass> vals = this.data.stuClasses.Where(s => s.LastName == id).ToList();
            return vals;
        }

        // POST: api/API
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public stuClass Post()
        {
            stuClass obj = new stuClass();
            obj.FirstName = Request.Form["firstName"];
            obj.LastName = Request.Form["lastName"];

            if (ModelState.IsValid)
            {
                data.stuClasses.Add(obj);
                data.SaveChanges();
            }
            Thread.Sleep(1000);
            
            return obj;
        }

        // PUT: api/API/5
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
