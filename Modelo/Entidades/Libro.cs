using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Libro
{
    public int Codlibro { get; set; }

    public string Nombre { get; set; } = null!;

    public int? Disponible { get; set; }

    public int? Idautor { get; set; }

    public virtual Autore? IdautorNavigation { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
