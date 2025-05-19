using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservacion
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string nombre = textBox1.Text;
      string email = textBox2.Text;
      string fecha = textBox3.Text;

      Usuario usuario1 = new Usuario(nombre, email);
      Reserva reserva1 = new Reserva(usuario1, fecha);

      label4.Text = reserva1.ConfirmarReserva();
    }
  }
}
