using System;
using System.Collections.Generic;
using System.Text;
using DTOs;


namespace Data.Interfaces
{
    public interface IArticulosRepository
    {
        int InsertarArticulo(string contenido, string titulo, int autorId);
        Articulo GetArticulo(int id);
    }
}
