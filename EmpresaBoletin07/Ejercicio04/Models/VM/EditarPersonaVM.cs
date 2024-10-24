using Ejercicio04.Models.DAL;
using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.VM
{
    public class ClsEditarPersonaVM : ClsPersona
    {
        public List<ClsDepartamento> Departamentos { get; }

       
        public ClsEditarPersonaVM(ClsPersona persona) : base(persona.Nombre, persona.Apellido, persona.Edad, persona.IdDepartamento)
        {
            Departamentos = ClsListado.ListadoDepartamentos();
        }

       
        
    }
}
