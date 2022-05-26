using System;

class aprovados
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  -  aprovados");
        Console.WriteLine();

        int N;
        double media;

        Console.WriteLine("Quantos alunos serão digitados");
        N = int.Parse(Console.ReadLine());
        //Primeiro vem a pergunta, para assim depois vir o Vetor, por causa do int.Parse

        string[] nomes = new string[N];
        double[] notas1 = new double[N];
        double[] notas2 = new double[N];
        //Aqui foi definido todos os vetores alocando com a int N

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite o Nome, Primeira e Segunda nota do " + (i + 1) + "º Aluno");
            nomes[i] = Console.ReadLine();
            notas1[i] = double.Parse(Console.ReadLine());
            notas2[i] = double.Parse(Console.ReadLine());

            //O for para o usuario definir a quantidade de pessoas e notas que ele quer escrever
        }

        Console.WriteLine("Alunos aprovados: ");

        for (int i = 0; i < N; i++)
        {
            media = notas1[i] + notas2[i] / 2;

            if (media >= 6)
            {
                Console.WriteLine(nomes[i]);
            }
        }
        // E um for com if dentro para definir a media do alunos, e, mostrar quem foi aprovado 

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}