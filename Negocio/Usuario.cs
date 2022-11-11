using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos;

namespace Negocio
{
    public class Usuario
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }

        private Datos.PetFunnyEntities entidades;

        public Usuario()
        {
            entidades = new PetFunnyEntities();
        }

        public int Buscar()
        {
            int res = 0;

            Datos.Usuario usuario = null;

            usuario = entidades.Usuarios.FirstOrDefault(a => a.UserName == this.UserName && a.Password == this.Password);

            if (usuario != null)
            {
                this.Nombres = usuario.Nombres;
                res = 1;
            }
            else
            {
                res = 0;
            }

            return res;
        }
    }
}
