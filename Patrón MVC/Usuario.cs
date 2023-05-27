using System;

namespace Patrón_MVC
{
    public class Usuario
    {
            public string Nombre { get; set; }
            public int Edad { get; set; }
        }

        public class UsuarioController
        {
            private Usuario modelo;
            private UsuarioView vista;

            public UsuarioController(Usuario modelo, UsuarioView vista)
            {
                this.modelo = modelo;
                this.vista = vista;
            }

            public void SetNombre(string nombre)
            {
                modelo.Nombre = nombre;
            }

            public void SetEdad(int edad)
            {
                modelo.Edad = edad;
            }

            public string GetNombre()
            {
                return modelo.Nombre;
            }

            public int GetEdad()
            {
                return modelo.Edad;
            }

            public void ActualizarVista()
            {
                vista.ImprimirDetallesUsuario(modelo.Nombre, modelo.Edad);
            }
        }

        public class UsuarioView
        {
            public void ImprimirDetallesUsuario(string nombre, int edad)
            {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            }
        }

        class Program
        {
        public Program()
        {
        }

        static void Main(string[] args)
            {
                // Crear el modelo
                Usuario modelo = new Usuario();

                // Crear la vista
                UsuarioView vista = new UsuarioView();

                // Crear el controlador y pasarle el modelo y la vista
                UsuarioController controlador = new UsuarioController(modelo, vista);

                // Actualizar el modelo
                controlador.SetNombre("John Doe");
                controlador.SetEdad(30);

                // Actualizar la vista con los datos del modelo
                controlador.ActualizarVista();

              Console.ReadKey();
            }
        }

    }

