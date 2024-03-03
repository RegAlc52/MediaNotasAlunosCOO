using System;

namespace MediaNotasAlunosCOO
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            double nota1, nota2, nota3;

            Console.WriteLine("Digite a nota do primeiro trimestre:");
            while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 100)
            {
                Console.WriteLine("Nota inválida. Digite novamente:");
            }

            Console.WriteLine("Digite a nota do segundo trimestre:");
            while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 100)
            {
                Console.WriteLine("Nota inválida. Digite novamente:");
            }

            Console.WriteLine("Digite a nota do terceiro trimestre:");
            while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 100)
            {
                Console.WriteLine("Nota inválida. Digite novamente:");
            }

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

            aluno.ImprimirDados();
        }
    }

    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularNotaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public string Situacao()
        {
            double notaFinal = CalcularNotaFinal();
            return notaFinal >= 60 ? "APROVADO" : "REPROVADO";
        }

        public double PontosFaltantes()
        {
            double notaFinal = CalcularNotaFinal();
            double pontosFaltantes = 60 - notaFinal;
            return pontosFaltantes < 0 ? 0 : pontosFaltantes;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome do aluno: {Nome}");
            Console.WriteLine($"Nota final: {CalcularNotaFinal()}");
            Console.WriteLine($"Situação: {Situacao()}");

            if (Situacao() == "REPROVADO")
            {
                Console.WriteLine($"Pontos faltantes para aprovação: {PontosFaltantes()}");
            }
        }
    }
}
//Fazer um programa que leia
//nome de um aluno = string
//e três notas que ele obteve nos =  double
//três trimestres do ano = double
//primeiro trimestre vale 30
//segundo e terceiro valem 35 cada
//Mostrar em tela para o usuraio nota final do aluno no ano = double
//Informar se
//APROVADO ou = string
//REPROVADO = string
//Se reprovado mostra uma mensagem informando
//quantos pontos o aluno deveria obter para ser aprovado = double
//Considerar nota para aprovação 60 pontos = double
//Com orientação a objetos