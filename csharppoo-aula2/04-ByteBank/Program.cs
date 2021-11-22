using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            ContaCorrente contaGabriela = new ContaCorrente();

            contaBruno.titular = "Bruno";
            contaGabriela.titular = "Gabriela";

            bool resultadoSaque = contaBruno.Sacar(1000);
            Console.WriteLine(resultadoSaque);

            contaBruno.Sacar(51);
            Console.WriteLine(contaBruno.saldo);

            contaBruno.Deposito(2000);
            Console.WriteLine(contaBruno.saldo);

            bool resultadoTranferencia = contaBruno.Transferir(1000, contaGabriela);

            Console.WriteLine("Resultado da transferencia= " + resultadoTranferencia);

            Console.WriteLine("Conta do Bruno: " + contaBruno.saldo);
            Console.WriteLine("Conta do Gabriela: " + contaGabriela.saldo);

        }
    }
}
