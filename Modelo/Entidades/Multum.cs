using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Multum
{
    public int Idmulta { get; set; }

    public decimal Valor { get; set; }

    public string Estado { get; set; } = null!;

    public int? IdPrestamo { get; set; }

    public virtual Prestamo? IdPrestamoNavigation { get; set; }
}
