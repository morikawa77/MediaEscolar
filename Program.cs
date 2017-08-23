using System;

namespace MediaEscolar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			decimal nota1, nota2, nota3, media;

			Console.Write("Digite a nota 1: ");
            nota1 = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Digite a nota 2: ");
			nota2 = Convert.ToDecimal(Console.ReadLine());
			Console.Write("Digite a nota 3: ");
            nota3 = Convert.ToDecimal(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
			if (media >= 6)
			{
                Console.Write("Média {0:##,##0.00} - Aprovado", media);
            } else {
                Console.Write("Média {0:##,##0.00} - Reprovado", media);
            }
			Console.ReadLine();
        }
    }
}
