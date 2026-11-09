using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Prestamo
{
    public int IdPrestamo { get; set; }

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaDevolucionE { get; set; }

    public DateTime? FechaDevolucionR { get; set; }

    public string? Estado { get; set; }

    public int? Codlibro { get; set; }

    public int? Idlector { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual Libro? CodlibroNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }

    public virtual Lectore? IdlectorNavigation { get; set; }

    public virtual ICollection<Multum> Multa { get; set; } = new List<Multum>();
}
