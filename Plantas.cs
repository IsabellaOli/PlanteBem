using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantas_Isabella_1706438
{
   public class Plantas 
    {
            private int id;
            public int ID { get { return id; } set { id = value; } }
            public string Nome { get; set; }
            public string Caracteristica { get; set; }
            public string Descricao { get; set; }
            public string Imagem { get; set; }
            public string Dicas { get; set; }

        public Plantas() { }

            public string obterNome()
            {
                return ID.ToString() + Nome;
            }
        }
}
