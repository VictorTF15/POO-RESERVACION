using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservacion
{
  public class Reserva
  {
    public Usuario Usuario { get; set; }
    public string Fecha { get; set; }
    public string Estado { get; set; } = "Pendiente";
    public Reserva(Usuario usuario, string fecha)
    {
      Usuario = usuario;
      Fecha = fecha;
    }
    public string ConfirmarReserva()
    {
      Random rnd = new Random();
      bool disponible = rnd.Next(0, 2) == 1;
      if (disponible)
      {
        Estado = "Confirmada";
        return $"Reserva confirmada para {Usuario.Nombre} el {Fecha}";
      }
      else
      {
        return $"No hay disponibilidad para {Fecha}";
      }
    }
  }
}
