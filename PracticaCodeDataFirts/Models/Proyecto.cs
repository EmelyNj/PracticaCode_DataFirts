﻿using System;
using System.Collections.Generic;

namespace PracticaCodeDataFirts.Models;

public partial class Proyecto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }
}
