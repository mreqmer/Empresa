
using BL;
using ENT;

namespace Mandaloriano.Models.VM
{
<<<<<<< HEAD
    public class ListaMisionesVM 

    {
        private List<Mision> misiones;
        private Mision mision;

        public List<Mision> Misiones { get; }

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


            Misiones = ListadosBL.ObtieneMisionesDurmiendo();
            mision = ListadosBL.ObtieneMisionBL(misionSeleccionada, misiones);

            misiones = ListadosBL.ObtieneMisionesDurmiendo();
            mision = BL.ListadosBL.ObtieneMisionBL(misionSeleccionada, misiones);


        }


    }
}
