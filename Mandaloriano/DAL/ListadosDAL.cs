using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadosDAL
    {


        public static List<Mision>  ObtieneMisionesDAL()
        {
            List < Mision > ListadoMisiones = new List<Mision> 
            {
            new Mision (1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", "5000 créditos"),
            new Mision (2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", "2000 créditos"),
            new Mision (3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal 'Sorgon'.", "500 créditos"),
            new Mision (4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", "500 créditos")
        };
            return ListadoMisiones;
        }

        public static Mision ObtieneMisionDAL(int id, List<Mision> ListaMisiones)
        {

            Mision misionEncontrada = ListaMisiones.Find(m => m.Id == id);


            return misionEncontrada;
        }
    }
}
