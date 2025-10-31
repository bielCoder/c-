using System;

namespace aula05
{
    class Program
    {
        // Operadores Aritméticos na prática
        static void Main(string[] args)
        {
            // int n1, n2, n3;
            // n1 = 10;
            // n2 = 20;
            // n3 = 30;

            // Console.WriteLine("n1=\t{0}\nn2=\t{1}\nn3=\t{2}", n1, n2, n3);

            NotaFiscal();
        }

        static void  NotaFiscal()
        {
            double valorCompra = 150.75;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            Console.WriteLine("Produto...............:{0,8} " , produto);
            Console.WriteLine("Val.Compra...............:{0,8:c} " , valorCompra);
            Console.WriteLine("Lucro...............:{0,8:p} " , lucro);
            valorVenda = valorCompra + (valorCompra * lucro);
            Console.WriteLine("Val.Venda...............:{0,8:c} ", valorVenda); 

            //ajustar branchs  
        
        }
    }
    

}