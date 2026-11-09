using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class VwHistorialPrestamo
{
    public string DocumentoLector { get; set; } = null!;

    public string NombreLector { get; set; } = null!;

    public string TipoLector { get; set; } = null!;

    public int CodigoLibro { get; set; }

    public string NombreLibro { get; set; } = null!;

    public DateTime FechaPrestamo { get; set; }

    public DateTime FechaEsperada { get; set; }

    public string? EstadoPrestamo { get; set; }
}
