﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservacion
{
  public class Usuario
  {
    public string Nombre { get; set; }
    public string Email { get; set; }
    public Usuario(string nombre, string email)
    {
      Nombre = nombre;
      Email = email;
    }

  }
}
