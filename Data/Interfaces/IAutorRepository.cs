using System;
using System.Collections.Generic;
using System.Text;
using DTOs;

namespace Data.Interfaces
{
    public interface IAutorRepository
    {
        Autor GetAutor(int id);
        bool AutorValido(int id);
    }
}
