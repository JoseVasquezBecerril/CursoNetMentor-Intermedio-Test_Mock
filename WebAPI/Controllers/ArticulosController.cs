using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Service;
using DTOs;
using Data.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly ArticulosServicios  _articuloServicio;
        public ArticulosController(ArticulosServicios articulosServicios)
        {
            _articuloServicio = articulosServicios;
        }

        [HttpPost]
        [Route("Articulo")]
        public Articulo InsertarArticulo(string contenido, string titulo, int autor)
        {
            var resultado = _articuloServicio.InsertarArticulo(contenido, titulo, autor);
            return resultado;
        }

        [HttpGet]
        [Route("Articulo/{id}")]
        public Articulo ConsultarArticulo(int id)
        {
            var resultado = _articuloServicio.ConsultarArticulo(id);
            return resultado;
        }

    }
}
