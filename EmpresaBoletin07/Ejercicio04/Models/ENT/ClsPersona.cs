namespace Ejercicio04.Models.ENT
{
    public class ClsPersona
    {

        #region Atributos de Persona
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int Edad {  get; set; }
        public int IdDepartamento { get; set; }

        #endregion


        #region Constructores de Persona

        public ClsPersona() 
        { 
        }
        
        public ClsPersona(string nombre, string apellido, int edad, int idDepartamento)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            IdDepartamento = idDepartamento;
        }

        #endregion

    }
}
