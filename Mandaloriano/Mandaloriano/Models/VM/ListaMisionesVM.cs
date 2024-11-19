
using BL;
using ENT;

namespace Mandaloriano.Models.VM
{
    public class ListaMisionesVM 

    {
        private List<Mision> misiones;
        private Mision mision;

        public List<Mision> Misiones { get; }
        public Mision Mision { get { return mision; } }


        public ListaMisionesVM()
        {

            Misiones = ListadosBL.ObtieneMisionesDurmiendo();

        }
        public ListaMisionesVM(int misionSeleccionada)
        {

            Misiones = ListadosBL.ObtieneMisionesDurmiendo();
            mision = ListadosBL.ObtieneMisionBL(misionSeleccionada, misiones);
        }


    }
}
