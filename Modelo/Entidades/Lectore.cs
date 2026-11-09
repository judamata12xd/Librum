using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Lectore
{
    public int Idlector { get; set; }

    public string Documento { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string TipoLector { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int? Idrol { get; set; }

    public virtual Role? IdrolNavigation { get; set; }

    public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
}
