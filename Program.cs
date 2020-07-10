using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis: inteiros e ponto flutuante
            //Entrada do usuário
            //Validações requeridas
            //Estrutura condicional requerida / aninhamento

            double notaUm, notaDois, notaTres, notaQuatro, mediaFinal;
            bool notaUmValido, notaDoisValido, notaTresValido, notaQuatroValido;
            Console.WriteLine("-- Média --");
            Console.WriteLine("Digite as suas notas abaixo.");

            Console.Write("Nota 1: ");
            notaUmValido = Double.TryParse(Console.ReadLine(), out notaUm);
            Console.Write("Nota 2: ");
            notaDoisValido = Double.TryParse(Console.ReadLine(), out notaDois);
            Console.Write("Nota 3: ");
            notaTresValido = Double.TryParse(Console.ReadLine(), out notaTres);
            Console.Write("Nota 1: ");
            notaQuatroValido = Double.TryParse(Console.ReadLine(), out notaQuatro);

            if (!notaUmValido   || !notaDoisValido 
             || !notaTresValido || !notaQuatroValido)
            {
                 Console.WriteLine("Por favor, informe somente números!");
                 Environment.Exit(-1);
            }
            
            if (notaUm < 0     || notaUm > 10
             || notaDois < 0   || notaDois > 10
             || notaTres < 0   || notaTres > 10
             || notaQuatro < 0 || notaQuatro > 10 )
            {
                 Console.WriteLine("Digite somente notas entre 0 e 10.");
                 Environment.Exit(-1);
            }

            mediaFinal = (notaUm + notaDois + notaTres + notaQuatro) / 4;
            Console.WriteLine($"Você ficou com média {mediaFinal:N1}.");
            Console.Write("Resultado: ");
            /*
            |-----------|--------------|------------|
            0           5              6            10
            <<<<<<<<<<<<
            REPROVADO
            */
            if (mediaFinal < 5)
            {
                Console.WriteLine("Reprovado");
            }
            /*
            |-----------|--------------|------------|
            0           5              6            10
                        <<<<<<<<<<<<<<<<
                         EM RECUPERAÇÃO
            */
            else if (mediaFinal >=5 && mediaFinal <= 6)
            {
                Console.WriteLine("Em recuperação");
            }
            
            /*
            |-----------|--------------|------------|
            0           5              6            10
                                        <<<<<<<<<<<<<
                                        APROVADO
            */
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
