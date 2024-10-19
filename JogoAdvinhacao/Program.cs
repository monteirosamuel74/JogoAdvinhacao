using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JOGO DA ADVINAÇÃO");
            Console.WriteLine("Peça pra alguém inserir a pergunta, a resposta e uma dica.");
            Console.WriteLine("Insira quantas perguntas quiser. Depois você terá 3 chances de responder.");
            List<NovaPergunta> perguntas;
            perguntas = CriarPergunta();
            Random r = new Random();
            int pos = 0;
            int tentativas = 0;
            Boolean flag = false;
            String resposta = "";
            while (true)
            {
                while (tentativas < 3 && flag == false)
                {
                    pos = r.Next(0, perguntas.Count);
                    NovaPergunta pergunta = perguntas[pos];

                    Console.WriteLine("Pergunta: " + pergunta.Pergunta);
                    Console.Write("Resposta: ");
                    resposta = Console.ReadLine().ToUpper();

                    if (resposta == pergunta.Resposta)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Errou... Dica: " + pergunta.Dica);
                    }
                    tentativas++;
                    if (flag == true)
                    {
                        Console.WriteLine("Parabéns! Venceu.");

                    }
                    else
                    {
                        Console.WriteLine("Perdeu!!");
                    }
                }
                Console.Write("Continua? s/n: ");
                String sim = Console.ReadLine().ToUpper();
                if (sim == "S")
                {
                    tentativas = 0;
                    flag = false;
                    continue;
                }
                else
                {
                    flag = true;
                    break;
                }
            }
        }

        static List<NovaPergunta> CriarPergunta()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            String perg, resp, tip;
            while (true)
            {
                Console.Write("Insira a pergunta: ");
                perg = Console.ReadLine();
                Console.Write("Insira a resposta: ");
                resp = Console.ReadLine();
                Console.Write("Insira a dica: ");
                tip = Console.ReadLine();
                NovaPergunta p = new NovaPergunta(perg, resp, tip);
                lista.Add(p);
                Console.Write("Deseja inserir mais uma pergunta? s/n: ");
                String continua = Console.ReadLine().ToUpper();
                if (continua == "S")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
            return lista;
        }
    }
}
