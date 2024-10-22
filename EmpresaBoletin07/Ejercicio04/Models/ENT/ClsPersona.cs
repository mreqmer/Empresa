namespace Ejercicio04.Models.ENT
{
    public class ClsPersona
    {

        String Nombre { get; set; }
        String Apellidos { get; set; }
        int Edad {  get; set; }
        int IdDepartamento { get; set; }

        public ClsPersona(string nombre, string apellidos, int edad, int idDepartamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            IdDepartamento = idDepartamento;
        }

    }
}
