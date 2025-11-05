using System;


namespace aula13
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Console.WriteLine("Escolha uma direção para mover o personagem:[W]Cima, [S]Baixo, [A]Esquerda, [D]Direita");
            switch (Console.ReadLine())
            {
                case 1:
                    Console.WriteLine("Personagem movendo para cima");
                    break;
                case 2:
                    Console.WriteLine("Personagem movendo para baixo");
                    break;
                case 3:
                    Console.WriteLine("Personagem movendo para esquerda");
                    break;
                case 4:
                    Console.WriteLine("Personagem movendo para direita");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
    
    public class JoyStick
    {
        public static int MoverCima()
        {
            return 1;
        }

        public static int MoverBaixo()
        {
            return 2;
        }

        public static int MoverEsquerda()
        {
            return 3;
        }

        public static int MoverDireita()
        {
            return 4;
        }
    }
}