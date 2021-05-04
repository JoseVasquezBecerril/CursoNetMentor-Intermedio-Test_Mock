using System;
using System.Collections.Generic;
using System.Text;
using DTOs;
using Data.Interfaces;

namespace Dominio.Service
{
    public class ArticulosServicios
    {
        private readonly IAutorRepository _autorRepository;
        private readonly IArticulosRepository _articuloRepository;

        public ArticulosServicios(IArticulosRepository articulosRepository, IAutorRepository autorRepository)
        {
            _articuloRepository = articulosRepository;
            _autorRepository = autorRepository;
        }
        public Articulo InsertarArticulo(string contenido, string titulo, int autorId)
        {
            if (!_autorRepository.AutorValido(autorId))
            {
                throw new Exception("Autor no Válido");
            }
            var articuloId = _articuloRepository.InsertarArticulo(contenido, titulo, autorId);
            return ConsultarArticulo(articuloId);

        }
        public Articulo ConsultarArticulo(int id)
        {
            return _articuloRepository.GetArticulo(id);
        }

    }
}
