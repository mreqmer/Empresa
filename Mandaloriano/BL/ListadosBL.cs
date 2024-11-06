using ENT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListadosBL
    {

        public static List<Mision> ObtieneMisionesBL()
        {
            List<Mision> ListadoMisionesBL = ListadosDAL.ObtieneMisionesDAL();
            return ListadoMisionesBL;
        }

        public static Mision ObtieneMisionBL(int id, List<Mision> ListaMisiones)
        {

            Mision mision = ListadosDAL.ObtieneMisionDAL(id, ListaMisiones);

            return mision;
        }

        public static List<Mision> ObtieneMisionesDurmiendo()
        {
            List<Mision> ListadoMisionesBL = new List<Mision>();

            if (DateTime.Now.Hour > 8)
            {
                ListadoMisionesBL = ListadosDAL.ObtieneMisionesDAL();
            }
            else
            {
                ListadoMisionesBL = null;
            }

            return ListadoMisionesBL;
        }
    }
}
