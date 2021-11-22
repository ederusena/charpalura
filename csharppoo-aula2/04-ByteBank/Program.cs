using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            contaBruno.Sacar(51);
            Console.WriteLine(contaBruno.saldo);

        }
    }
}
