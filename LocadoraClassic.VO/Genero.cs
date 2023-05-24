using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Genero()
        {

        }
        public Genero(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public Genero(string nome) { 
          Nome = nome;
        }
    }
}
