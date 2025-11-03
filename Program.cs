using System;

namespace aula07
{
    class Program
    {
        public const string fullname = "Gabriel Henrique";
        
        

        static void Main(string[] args)
        {
            // uso de constantes
            this.fullname = "João Silva"; // Erro: não é possível modificar uma constante
            Console.WriteLine("Nome completo: " + fullname);
        }
    }
}