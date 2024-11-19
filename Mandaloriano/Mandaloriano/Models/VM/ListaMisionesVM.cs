
using BL;
using ENT;

namespace Mandaloriano.Models.VM
{
    public class ListaMisionesVM
    {
        private List<Mision> misiones;

        private Mision mision;

        public List<Mision> Misiones { get { return misiones; } }
        public Mision Mision { get { return mision; } }


        public ListaMisionesVM()
        {

            misiones = ListadosBL.ObtieneMisionesDurmiendo();

        }

        public ListaMisionesVM(int misionSeleccionada)
        {

            misiones = ListadosBL.ObtieneMisionesDurmiendo();
            mision = BL.ListadosBL.ObtieneMisionBL(misionSeleccionada, misiones);

        }


    }
}
