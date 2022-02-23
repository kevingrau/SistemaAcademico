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
            objaluno.cpf = 1234346634.ToString();
            objaluno.dataNascimento = new DateTime(2004, 11, 27);
            objaluno.nome = "Maria";
            objaluno.endereco = "Rua Padre Marcelo ";
            objaluno.telefone = "(19) 977777777";
            joao.cpf = 32423412.ToString();
            joao.dataNascimento = new DateTime(1970, 09, 11);
            joao.nome = "João Pedro";
            joao.endereco = "Rua Padre Judiel ";
            joao.telefone = "(19) 988888888";

            Console.WriteLine("CPF:");
            Console.WriteLine(objaluno.cpf);
            Console.WriteLine();
            Console.WriteLine("Nome:");
            Console.WriteLine(objaluno.nome);
            Console.WriteLine();
            Console.WriteLine("Data de Nascimento:");
            Console.WriteLine(objaluno.dataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Endereço:");
            Console.WriteLine(objaluno.endereco);
            Console.WriteLine();
            Console.WriteLine("Telefone:");
            Console.WriteLine(objaluno.telefone);
            Console.WriteLine();
            Console.WriteLine("CPF:");
            Console.WriteLine(joao.cpf);
            Console.WriteLine();
            Console.WriteLine("Nome:");
            Console.WriteLine(joao.nome);
            Console.WriteLine();
            Console.WriteLine("Data de Nascimento:");
            Console.WriteLine(joao.dataNascimento.ToString("dd/MM/yyyy"));
            Console.WriteLine();
            Console.WriteLine("Endereço:");
            Console.WriteLine(objaluno.endereco);
            Console.WriteLine();
            Console.WriteLine("Telefone:");
            Console.WriteLine(objaluno.telefone);
            Console.WriteLine();
            Console.ReadKey();                     
        }
    }
}
