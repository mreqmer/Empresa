using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.DAL
{
    public class ClsListado
    {

        static List<ClsPersona> listaPersonas;
        static List<ClsDepartamento> listaDepartamentos;

        public static List<ClsPersona> ListadoPersonas()
        {
            listaPersonas = new List<ClsPersona>
            {
                new ClsPersona("Juan", "Barrena", 25, 2),
                new ClsPersona("Maria", "Lopez", 30, 1),
                new ClsPersona("Pedro", "Gomez", 28, 3),
                new ClsPersona("Lucia", "Martinez", 22, 1),
                new ClsPersona("Ana", "Garcia", 27, 2),
                new ClsPersona("Carlos", "Fernandez", 35, 3),
                new ClsPersona("Elena", "Ruiz", 29, 1),
                new ClsPersona("Miguel", "Sanchez", 24, 2),
                new ClsPersona("Sofia", "Hernandez", 26, 3),
                new ClsPersona("David", "Perez", 32, 1)

            };
            return listaPersonas;
            
        }

        public static ClsPersona sacarPersonasRandom()
        {
            Random ran = new Random();
            List<ClsPersona> personas = ListadoPersonas();
            int indice = ran.Next(personas.Count);

            return personas[indice];
        }

        static List<ClsDepartamento> ListadoDepartamentos()
        {
            listaDepartamentos = new List<ClsDepartamento>
            {
                new ClsDepartamento(1, "Tecnología de la Información"),
                new ClsDepartamento(2, "Finanzas"),
                new ClsDepartamento(3, "Marketing")

            };
            return listaDepartamentos;

        }


    }
}
