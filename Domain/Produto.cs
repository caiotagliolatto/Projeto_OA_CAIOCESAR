using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Produto
    {
        public string preco;
        public string nome, descricao;
        public int id { get; set; }
        public Produto(string prec, string nom, string desc)
        {
            preco = prec;
            nome = nom;
            descricao = desc;
        }
        public Produto()
        {

        }
    }
}
