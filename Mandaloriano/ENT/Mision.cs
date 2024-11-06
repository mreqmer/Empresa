using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class Mision
    {
        #region Atributos/GettersSetters
        public int Id { get;}
        public string Titulo { get; set; } 
        public string Descripcion { get; set; }
        public string Recompensa {  get; set; }
        #endregion
        #region Constructores
        public Mision() { 
        }
        public Mision(int id, string titulo, string descripcion, string recompensa)
        {
            Id = id;
            Titulo = titulo;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }
        #endregion
    }
}
