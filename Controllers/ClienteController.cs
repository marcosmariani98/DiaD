using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiaD.Models;

namespace ProyectoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private EcommerceContext ContextCliente;

        public void ClienteController1(EcommerceContext parametro)
        {
            ContextCliente = parametro;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(string Username)
        {
            var user = ContextCliente.Clientes.FirstOrDefault(x => x.Username ==Username);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("dato mal ingresado");
            }
        } 

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente value)
        {
            ContextCliente.Clientes.Add(value);
            ContextCliente.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente value)
        {
            var Cliente = ContextCliente.Clientes.Find(id);
            if (Cliente != null)
            {
                Cliente.Nombre = value.Nombre;
                Cliente.Apellido = value.Apellido;
                Cliente.Username = value.Username;
                ContextCliente.SaveChanges();

            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string Username)
        {
            var remove = ContextCliente.Clientes.Find(Username);
            if (remove != null)
            {
                ContextCliente.Clientes.Remove(remove);
                ContextCliente.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound ("daleee compaa");
            }
        }
    }
}
