using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuelaUtil;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");

            ImprimirCursosEscuela(engine.Escuela);

        }

        private static bool Predicado(Curso curobj)
        {
            return curobj.Nombre == "301";
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la Escuela");
            
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id: {curso.UniqueId}");
                }
            }
        }
    }
}
