using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class dbInitializer
    {
        public static void Initialize(SistemaContext Context)
        {
            Context.Database.EnsureCreated();

            //Busqueda de registros

            if(Context.Categoria.Any())
            {
                return;
            }

            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacion", Descripcion="Cursos de Programacion (insertado por defecto)", Estado= true},
                new Categoria{Nombre="Diseño grafico", Descripcion="Cursos de Diseño Grafico (insertado por defecto)", Estado= true}
            };

            foreach (Categoria c in categorias)
            {
                Context.Categoria.Add(c);
            }

            Context.SaveChanges();
        }
    }
}
