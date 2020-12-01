using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Usuario
    {
        public Usuario(string correo, string nombre, string apellido, int edad, int mercado)
        {
            this.correo = correo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.mercado = mercado;
        }

        public string correo { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public int edad { get; set; }

        public int mercado { get; set; }
    }
}