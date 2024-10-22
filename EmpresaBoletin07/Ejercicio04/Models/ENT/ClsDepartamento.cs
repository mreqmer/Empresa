namespace Ejercicio04.Models.ENT
{
    public class ClsDepartamento
    {

        public int Departamento {  get; set; }
        public String Nombre { get; set; }

        public ClsDepartamento(int departamento, String nombre)
        {
            Departamento = departamento;
            Nombre = nombre;
           
        }

    }
}
