using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BL;
using ENT;


namespace Mandaloriano2.Models
{
    internal class MisionesVM : INotifyPropertyChanged
    {


        private List<Mision> misiones;
        private Mision misionSeleccionada;
        private bool esVisible;

        public MisionesVM()
        {
            this.misiones = ListadosBL.ObtieneMisionesDurmiendo();

            
        }

        public MisionesVM(int id)
        {
            this.misiones = ListadosBL.ObtieneMisionesDurmiendo();
            this.misionSeleccionada = ListadosBL.ObtieneMisionBL(id, misiones);
        }

        public List<Mision> Misiones {
            get => misiones;
            set
            {
                misiones = value;

                if (misiones == null)
                {
                    esVisible = false;
                }
                OnPropertyChanged("EsVisible");
            }
        }

        public Mision MisionSeleccionada{
            get=> misionSeleccionada;
            set
            {
                misionSeleccionada = value;
                OnPropertyChanged("MisionSeleccionada");
            }

        }

        public bool EsVisible { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
