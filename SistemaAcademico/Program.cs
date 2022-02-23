using System;
using SistemaAcademico.Model;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno objaluno = new aluno(); //aluno () Método construtor
            professor joao = new professor();
            int x;
            objaluno.cpf = 12344387089.ToString();
            objaluno.dataNascimento = new DateTime(2004, 11, 27);     
            joao.cpf = 32423412.ToString();
            objaluno.nome = "Maria";
            joao.nome = "João Pedro";

            Console.WriteLine("CPF:");
            Console.WriteLine(objaluno.cpf);
            Console.WriteLine();
            Console.WriteLine("Nome:");
            Console.WriteLine(objaluno.nome);
            Console.WriteLine();
            Console.WriteLine("Data de Nascimento:");
            Console.WriteLine(objaluno.dataNascimento.ToString("dd/MM/yyyy"));
            Console.ReadKey();                     
        }
    }
}
