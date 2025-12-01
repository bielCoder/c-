using System;

namespace Aula18
{
    // Interface que representa um ovo
    interface IEgg
    {
        int GetAmount();             // quantidade de ovos
        int SetIncrementsAmount();   // incrementa e retorna o total
    }

    // Implementação concreta da contagem de ovos
    class Egg : IEgg
    {
        private int amount;

        public int SetIncrementsAmount()
        {
            return ++amount; // incrementa e retorna o valor atualizado
        }

        public int GetAmount()
        {
            Console.WriteLine($"Total de ovos: {amount}");
            return amount;
        }
    }

    // Classe Chicken (galinha)
    class Chicken
    {
        private readonly string name;
        private readonly IEgg eggCounter;  // ← composição (galinha usa Eggs)
        private bool alreadyLaid = false;

        public Chicken(string name, IEgg eggCounter)
        {
            this.name = name;
            this.eggCounter = eggCounter;
        }

        public void Lay()
        {
            eggCounter.SetIncrementsAmount();

            // if (!alreadyLaid)
            // {
            //     Console.WriteLine($"{name} botou um ovo");
            //     alreadyLaid = true;
            // }

                Console.WriteLine($"{name} botou um ovo");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEgg eggs = new Egg();
            Chicken hen = new Chicken("Lucileide", eggs);

            while (true)
            {
                Console.WriteLine("Pressione ENTER para Lucileide botar um ovo, ou digite 'sair' para encerrar:");
                string input = Console.ReadLine() ?? "";// <- espera ENTER ou texto

                if (input.ToLower() == "sair")
                    break;

                hen.Lay();
                eggs.GetAmount();
                Console.WriteLine();
            }

            eggs.GetAmount();   // ← agora funciona perfeitamente
        }
    }
}
