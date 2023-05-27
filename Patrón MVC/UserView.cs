using System;

namespace Patrón_MVC
{
    internal class UserView
    {
        public class UsuarioView
        {
            public void ImprimirDetallesUsuario(string nombre, int edad)
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
            }
        }

    }
}
