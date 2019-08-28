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
    public class CategoriaController : ControllerBase
    {
        private EcommerceContext ContextCategoria;

        public void CategoriaController1(EcommerceContext parametro)
        {
            ContextCategoria = parametro;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var user = ContextCategoria.Categorias.FirstOrDefault(x => x.CategoriaId ==id);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("dato mal ingresado");
            }
        } 

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Categoria value)
        {
            ContextCategoria.Categorias.Add(value);
            ContextCategoria.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Categoria value)
        {
            var Categoria = ContextCategoria.Categorias.Find(id);
            if (Categoria != null)
            {
                Categoria.Titulo = value.Titulo;
                Categoria.CategoriaId = value.CategoriaId;
                Categoria.Precio = value.Precio;
                ContextCategoria.SaveChanges();

            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var remove = ContextCategoria.Clientes.Find(id);
            if (remove != null)
            {
                ContextCategoria.Clientes.Remove(remove);
                ContextCategoria.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound ("daleee compaa");
            }
        }
    }
}
