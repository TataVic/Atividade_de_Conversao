using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Nick Name: Tauani Vitória;
 * Criação 17/02/2023;
 * Conversor de medidadas de Km/h para Nós e Mp/h, na qual armazena o valor de velocidade em vetor
 */
namespace AtividadeConversao_Tauani
{
     public class Program
    {
        static void Main(string[] args)
        {
            float velocidade, converteno, convertemp, resultado1, resultado2;
            float[] var = new float[2];

            Console.WriteLine("Digite a velocidade em km/h a ser convertida: ");
            velocidade = float.Parse(Console.ReadLine());

            converteno = velocidade / 1.852f;
            resultado1 = converteno;
            var[0] = resultado1;
            Console.WriteLine(resultado1 + " " + "Nós", converteno);
            Console.ReadKey();

            convertemp = velocidade / 1.609f;
            resultado2 = convertemp;
            var[1] = resultado2;
            Console.WriteLine(resultado2 + " " + "Mp/h", convertemp);
            Console.ReadKey();
        }
        }
    }
