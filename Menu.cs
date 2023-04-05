using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_IntroDotNet_Proj_Escola
{
    internal class Menu
    {
        private List<Turma> Turmas = new List<Turma>();
        public void Run()
        {
            //TODO: Criar lógica da turma selecionada para depois adicionar na turma em questão
            //TODO: Fazer lógica para troca de turma selecionada
            //TODO: Fazser lógica para inspeção de todas as turmas
            int OpcaoLocal = 9999;
            string MenuOpcoes =
                "\n-------------| MENU |-------------"
                + "\nInforme a Opção Desejada:\n"
                + "1- Cadastrar Turma\n"
                + "2- Listar Turma\n"
                + "3- inspecionar Turma\n"
                + "4- Cadastrar Aluno\n"
                + "5- Calcular Média Geral\n"
                + "6- Sair\n"
                + "----------------------------------\n"
                ;

            while (OpcaoLocal != 0)
            {
                try
                {
                    Console.WriteLine(MenuOpcoes);
                    Console.Write("Digite:");
                    OpcaoLocal = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException err)
                {
                    Console.Error.WriteLine(err.ToString());
                    Console.WriteLine("Formato Inválido!!!\nTente Novamente...");
                    Run();
                }

                switch (OpcaoLocal)
                {
                    case 1:
                        Console.Write("\n O nome da Nova Turma:");
                        string TurmaNome = Console.ReadLine();

                        
                        Console.Write("\nInforme a capacidade da Nova Turma:");
                        int TurmaCapacidade = Convert.ToInt16(Console.ReadLine());

                        Turma NovaTurma = new Turma(TurmaNome, TurmaCapacidade);
                        Turmas.Add(NovaTurma);
                        break;
                    case 2:
                        //TODO: Listar Aluno
                        foreach(var turma in Turmas)
                        {
                            int Index = 0;
                            Console.WriteLine($"{Index}: {turma}");
                        }
                        break;
                    case 3:
                        //TODO: Calcular Média Geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
