
using BL;
using ENT;

namespace Mandaloriano.Models.VM
{
    public class ListaMisionesVM : Mision
    {

        public List<Mision> Misiones { get; }


        public ListaMisionesVM()
        {

            Misiones = ListadosBL.ObtieneMisionesDurmiendo();

        }
        public ListaMisionesVM(int misionSeleccionada)
        {

            Misiones = ListadosBL.ObtieneMisionesDurmiendo();
            this.Id = misionSeleccionada;
        }


    }
}
