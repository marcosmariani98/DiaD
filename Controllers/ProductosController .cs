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
    public class ProductoController : ControllerBase
    {
        private EcommerceContext ContextProducto;

        public void ProductoController1(EcommerceContext parametro)
        {
            ContextProducto = parametro;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
            var user = ContextProducto.Productos.FirstOrDefault(x => x.ProductoId ==id);
            if (user != null)
            {
                return user;
            }else{
                return NotFound("dato mal ingresado");
            }
        } 

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Producto value)
        {
            ContextProducto.Productos.Add(value);
            ContextProducto.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Producto value)
        {
            var producto = ContextProducto.Productos.Find(id);
            if (producto != null)
            {
                producto.ProductoId = value.ProductoId;
                producto.Descripcion = value.Descripcion;
                producto.Precio = value.Precio;
                ContextProducto.SaveChanges();

            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var remove = ContextProducto.Productos.Find(id);
            if (remove != null)
            {
                ContextProducto.Productos.Remove(remove);
                ContextProducto.SaveChanges();

                return Ok();
            }
            else
            {
                return NotFound ("daleee compaa");
            }
        }
    }
}
