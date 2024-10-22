namespace Ejercicio04.Models.ENT
{
    public class ClsPersona
    {

        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int Edad {  get; set; }
        public int IdDepartamento { get; set; }

        public ClsPersona(string nombre, string apellidos, int edad, int idDepartamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            IdDepartamento = idDepartamento;
        }

    }
}
