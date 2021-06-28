using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject{
    class ContaBancaria{
        public int NumberAccount { get; private set; }
        public String NameAccount { get; set; }
        public double OverAccount  { get; set; }

        public ContaBancaria(String name, int number, double over){
            NameAccount = name;
            NumberAccount = number;
            OverAccount = over;
        }
        public override string ToString(){
            return "Conta: " + NumberAccount + ", Titular: " + NameAccount + ", Saldo R$: " + OverAccount;
        }
        public double Depositar(double over){
            return OverAccount += over;
        }
        public double Sacar(double over){
            OverAccount -= 5;
            return OverAccount -= over;
        }

    }
}
