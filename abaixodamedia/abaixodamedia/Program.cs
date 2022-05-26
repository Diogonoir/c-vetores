using System;

class Abaixo_Da_Media
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  Abaixo da Média");
        Console.WriteLine();

        int N;
        double soma, media;

        Console.WriteLine("Quantos elementos vai ter o vetor?");
        N = int.Parse(Console.ReadLine());


        double[] Vetor = new double[N];
        // o vetor como double alocado ao N para a digitação de um número

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um número");
            Vetor[i] = double.Parse(Console.ReadLine());
        }
        //um for para definir a quantidade de números a ser digitado 

        soma = 0;

        for (int i = 0; i < N; i++)
        {
            soma += Vetor[i];

            //um calculo no for para mostrar soma + soma = vetor, e pois dividir a soma por N, e assim exibir resultados da media 
        }

        media = soma / N;
        Console.WriteLine();

        Console.WriteLine("Média do vetor = " + media);
        Console.WriteLine("Elementos abaixo da média:");

        for (int i = 0; i < N; i++)
        {
            if (Vetor[i] < media)
            {
                Console.WriteLine(Vetor[i]);
            }
        }
        // e este for com if mostra quem está abaixo da media

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}

