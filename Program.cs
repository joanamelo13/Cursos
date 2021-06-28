using System;

namespace CourseProject{
    class Program{
        static void Main(string[] args){
            ContaBancaria account;
            double over;
            Console.Write("Informe o número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome do titular da conta: ");
            String name = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S'){
                Console.Write("Informe o valor do depósito: ");
                over = double.Parse(Console.ReadLine());
                account = new ContaBancaria(name, number, over);
            }
            else{
               over = 0;
               account = new ContaBancaria(name, number, over);
            }

            Console.WriteLine();
            Console.WriteLine("DADOS BANCÁRIOS: ");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Digite N para depósito ou S para saque. ");
            Console.Write("Informe a operação desejada: ");
            resp = char.Parse(Console.ReadLine());
            
            if(resp == 'n' || resp == 'N'){
                Console.Write("Informe o valor do depósito: ");
                over = double.Parse(Console.ReadLine());
                account.Depositar(over);
            }else if(resp == 's' || resp == 'S'){
                Console.WriteLine("Informe o valor de saque: ");
                over = double.Parse(Console.ReadLine());
                account.Sacar(over);
            }else{
                Console.WriteLine("Operação inválida. Por favor, informe a operação correta.");
            }

            Console.WriteLine("DADOS BANCÁRIOS ATUALIZADOS: ");
            Console.WriteLine(); 
            Console.WriteLine(account);
        }
    }
}
