using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIO_IntroDotNet_Proj_Escola
{
    internal class Turma
    {
        private string Nome;
        private int Capacidade;
        private int Index;
        public Aluno[] Alunos = new Aluno[0];
        public Turma(string nome, int capacidade)
        {
            Nome = nome;
            Capacidade = capacidade;
            Index = Capacidade;
            Array.Resize(ref Alunos, Capacidade);
        }

        public void CadastrarAluno(string nome, int nota)
        {
            Index = --Index;

            if(Index <= -1)
            {
                Console.Error.WriteLine("Turma sem capacidade");
            }
            else
            {
                Alunos[Index].Nome = nome;
                Alunos[Index].Nota = nota;
            }

            
        }
        public void CadastrarTurma(string nome, int capacidade)
        {
            try
            {
                Console.Write("\nDigite um nome para a turma:");
                Nome = Console.ReadLine();
            }
            catch (Exception ERR)
            {
                Console.WriteLine($"ERRO:{ERR}\n O nome pode ser grande de mais ou o formato está invalido, verifique e tente novamente!");
                Nome = Console.ReadLine();
            }

            try
            {
                Console.Write("\nInsira a capacidade da Turma:");
                Capacidade = Convert.ToInt16(Console.ReadLine());
            }
            catch (FormatException ERR1)
            {
                Console.Error.WriteLine($"ERRO:{ERR1}\n Tente mais uma vez, tenha certeza de usar números inteiro para cacpidade!");
                Capacidade = Convert.ToInt16(Console.ReadLine());
            }
            finally
            {
                Array.Resize(ref Alunos, Capacidade);
            }
        }
        public void InspecionarTurma()
        {
            Console.WriteLine("---");
            int Index = 0;
            foreach (var Aluno in Alunos)
            {
                ++Index;
                Console.WriteLine($"{Index}: {Aluno.Nome}");
            }

            Console.WriteLine("---");
        }
        public override string ToString()
        {
            return "Turma:" + Nome + " | Capacidade:"+ Capacidade;
        }
    }
}
