using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Negocio;

namespace ServiciosPetFunny
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public Usuario Validar(string UserName, string Password)
        {
            Negocio.Usuario usu = new Usuario();

            usu.UserName = UserName;
            usu.Password = Password;

            if (usu.Buscar() > 0)
            {
                return usu;
            }
            else
            {
                return null;
            }
        }
    }
}
