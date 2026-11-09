using System;
using System.Collections.Generic;

namespace Modelo.Entidades;

public partial class Role
{
    public int Idrol { get; set; }

    public string NombreRol { get; set; } = null!;

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual ICollection<Lectore> Lectores { get; set; } = new List<Lectore>();
}
