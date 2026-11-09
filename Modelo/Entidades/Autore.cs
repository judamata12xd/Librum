using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Autore
{
    public int Idautor { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
