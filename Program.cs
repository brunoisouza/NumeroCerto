using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroCerto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que sorteie um número aleatório. 
                Após isso o usuário pode informar com 3 tentativas um número para tentar adivinhar. 
                A cada suposição o sistema deve informar se o numero é menor ou maior que o sorteado. 
                Caso o usuário acerte deve ser mostrada uma mensagem de vitória, caso ele não consiga 
                deve ser mostrada a mensagem de derrota.
            */

            // Mensagem de abertura
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("*** SEJA BEM VINDO AO JOGO ACERTE O NÚMERO ***");
            Console.WriteLine("----------------------------------------------");

            // verificar a senha do usuário
            Console.WriteLine("Informe a senha para continuar: ");
            string senha = Console.ReadLine();

            if (senha != "abacaxi1")
            {
                Console.WriteLine("Senha Incorreta!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            // Limpar a tela
            Console.Clear();

            // Instruções
            Console.WriteLine("Instruções: ");
            Console.WriteLine(" - Tente acertar o número sorteado");
            Console.WriteLine(" ");
           Console.WriteLine("----------------------------------------------");

            // Sortear número aleatório
            int numeroAleatorio;
            Random rdm = new Random();
            numeroAleatorio = rdm.Next(10);

            // Variavel da tentativa
            int numeroTentativa;

            // Tentativa numero 1 de acerto
            Console.WriteLine(" *** PRIMEIRA TENTATIVA *** ");
            Console.WriteLine("Informe o primeiro número: ");
            numeroTentativa = int.Parse(Console.ReadLine());

            // Informar se a tentativa numero 1 é maior, menor ou mensagem de vitória
            if (numeroTentativa == numeroAleatorio)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ***       PARABÉNS VOCÊ ACERTOU !!!      *** ");
                Console.WriteLine("----------------------------------------------");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (numeroTentativa < numeroAleatorio)
                Console.WriteLine("O número informado é MENOR que o número sorteado");
            else
            {
                Console.WriteLine("O número informado é MAIOR que o número sorteado");
                Console.WriteLine("Você tem mais duas tentativas");
            }

            // Tentativa numero 2 de acerto
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" *** SEGUNDA TENTATIVA *** ");
            Console.WriteLine("Informe o segundo número: ");
            numeroTentativa = int.Parse(Console.ReadLine());

            // informar se a tentativa numero 2 é maior, menor ou mensagem de vitória
            if (numeroTentativa == numeroAleatorio)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ***       PARABÉNS VOCÊ ACERTOU !!!      *** ");
                Console.WriteLine("----------------------------------------------");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (numeroTentativa < numeroAleatorio)
                Console.WriteLine("O número informado é MENOR que o número sorteado");
            else
            {
                Console.WriteLine("O número informado é MAIOR que o número sorteado");
                Console.WriteLine("Você tem mais uma tentativa");
            }

            // Tentativa numero 3 de acerto
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" *** ÚLTIMATENTATIVA *** ");
            Console.WriteLine("Informe o último número: ");
            numeroTentativa = int.Parse(Console.ReadLine());

            // informar se a tentativa numero 3 é a correta, senão mostrar mensatem de derrota
            if (numeroTentativa == numeroAleatorio)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ***       PARABÉNS VOCÊ ACERTOU !!!      *** ");
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" ***       FIM DE JOGO, VOCÊ PERDEU!      *** ");
                Console.WriteLine("----------------------------------------------");
            }

            //Esperar qualquer tecla
            Console.ReadKey();

        }
    }
}
