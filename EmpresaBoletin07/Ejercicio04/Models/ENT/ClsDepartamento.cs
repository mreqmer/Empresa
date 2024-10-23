namespace Ejercicio04.Models.ENT
{
    public class ClsDepartamento
    {
        #region Atributos de Departamento
        public int IdDepartamento {  get; set; }
        public String Nombre { get; set; }
        #endregion


        #region Constructor de departamento
        public ClsDepartamento(int idDepartamento, String nombre)
        {
            IdDepartamento = idDepartamento;
            Nombre = nombre;
           
        }
        #endregion

    }
}
