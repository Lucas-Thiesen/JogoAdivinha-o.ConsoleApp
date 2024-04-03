using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Runtime.InteropServices;

namespace JogoAdivinhação.ConsoleApp
{
internal class Program
{
// Desenvolva um jogo de adivinhação.O computador pensará em um número, e você, jogador, precisará adivinhá-lo
// A cada erro, a máquina lhe dirá se o número chutado foi maior ou menor do que o pensado.
// Você também poderá escolher o nível de dificuldade do jogo, e isso lhe dará mais ou menos oportunidades de chutar um número.
//Ao final, se você ganhar, o computador lhe dirá quantos pontos você fez, baseando-se em quão bons eram seus chutes.

//A pontuação do usuário começará em 1000, caso o usuário erre, será subtraído um valor da pontuação com a seguinte fórmula: 
//(numero chutado – numero aleatório) / 2 


static void Main(string[] args)

{
while (true)
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao jogo de adivinhação! ");
    Console.WriteLine("Escolha a dificuldade:\n 1 - Fácil\n 2 - Médio\n 3 - Difícil");
    Console.WriteLine("Digite S para sair!");

    Random aleatorio = new Random();
    int valorAleatorio = aleatorio.Next(1, 20);
    int comando = Convert.ToInt32(Console.ReadLine());
    int pontuacao = 1000;
    if (comando == 1)
    {
        Console.WriteLine("Você optou pela dificuldade fácil! Boa sorte :)");
        int tentativa = 0;                   
        while (tentativa < 15)
        {
            Console.WriteLine($"\n{tentativa + 1}ª tentativa");
            Console.Write("Digite um número de 1 á 20!\n");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == valorAleatorio)
                {
                    Console.WriteLine("Parabéns! Você acertou!!");
                    Console.ReadLine();
                    break;
                }
                else if (numeroDigitado < valorAleatorio)
                {
                    Console.WriteLine("O Numero é menor que o sorteado!");
                    pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
                }
                else if (numeroDigitado > valorAleatorio)
                {
                    Console.WriteLine("O numero é maior que o sorteado!");
                    pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
                }
                tentativa++;
                                
        }
        Console.WriteLine("Tente novamente! O numero sorteado foi: " + valorAleatorio + " \nsua pontuação: " + pontuacao);
        Console.ReadKey();
    }
    else if (comando == 2)
    {
        Console.WriteLine("Você optou pela dificuldade média! Boa sorte :)");
        int tentativa = 0;
        while (tentativa < 10)
        {
            Console.WriteLine($"\n{tentativa + 1}ª tentativa");
            Console.Write("Digite um número de 1 á 20!\n");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == valorAleatorio)
                {
                    Console.WriteLine("Parabéns! Você acertou!!");
                    Console.ReadLine();
                    break;
                }
                else if (numeroDigitado < valorAleatorio)
                {
                    Console.WriteLine("O Numero é menor que o sorteado!");
                    pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
                }
                else if (numeroDigitado > valorAleatorio)
                {
                    Console.WriteLine("O numero é maior que o sorteado!");
                    pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
                }
                tentativa++;                                                   
        }
        Console.WriteLine("Tente novamente! O numero sorteado foi: " + valorAleatorio + " \nsua pontuação: " + pontuacao);
        Console.ReadKey();
    }
    else if (comando == 3)
    {

        Console.WriteLine("Você optou pela dificuldade difícil! Boa sorte :)");
        int tentativa = 0;
        while (tentativa < 5)
        {
            Console.WriteLine($"\n {tentativa + 1}ª tentativa");
            Console.Write("Digite um número de 1 á 20!\n");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado == valorAleatorio)
            {
                Console.WriteLine("Parabéns! Você acertou!!");
                Console.ReadLine();
                break;
            }
            else if (numeroDigitado < valorAleatorio)
            {
                Console.WriteLine("O Numero é menor que o sorteado!");
                pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
            }
            else if (numeroDigitado > valorAleatorio)
            {
                Console.WriteLine("O numero é maior que o sorteado!");
                pontuacao -= Math.Abs((numeroDigitado - valorAleatorio) / 2);
            }
            tentativa++;
        }
        Console.WriteLine("Tente novamente! O numero sorteado foi: " + valorAleatorio + " \nsua pontuação: " + pontuacao);
        Console.ReadKey();
    }
}                 
                           
}
}
}
