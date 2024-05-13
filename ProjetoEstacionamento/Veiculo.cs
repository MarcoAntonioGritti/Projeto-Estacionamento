using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento
{
    public class Veiculo
    {

        public string Placa{get;set;}
        
        public Veiculo(string p){
            Placa = p;
        }
    }
}