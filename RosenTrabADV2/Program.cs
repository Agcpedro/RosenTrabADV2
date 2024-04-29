using System;
using System.Collections.Generic;
using RosenTrabADV2;

class Program
{
    static void Main(string[] args)
    {
        List<Estudante> estudantes = new List<Estudante>();
        Estudante estudanteAtual = null;

        while (true)
        {
            CriarLinha();
            if (estudanteAtual != null)
            {
                Console.WriteLine("Aluno selecionado atual: " + estudanteAtual.Nome + ", Idade: " + estudanteAtual.Idade + ", Curso: " + estudanteAtual.Curso);
            }
            else
            {
                Console.WriteLine("Nenhum aluno selecionado.");
            }
            CriarLinha();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Cadastrar novo aluno");
            Console.WriteLine("2. Selecionar aluno");
            Console.WriteLine("3. Estudar conhecimento geral");
            Console.WriteLine("4. Estudar conhecimento específico");
            Console.WriteLine("5. Fazer exame");
            Console.WriteLine("6. Sair");
            CriarLinha();

            string input = Console.ReadLine();
            int opcao;

            if (!int.TryParse(input, out opcao))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                CriarLinha();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome do aluno:");
                    string nome = Console.ReadLine();
                    CriarLinha();
                    Console.WriteLine("Digite a idade do aluno:");
                    int idade = Convert.ToInt32(Console.ReadLine());
                    CriarLinha();
                    Console.WriteLine("Digite o curso do aluno:");
                    string curso = Console.ReadLine();
                    CriarLinha();
                    Estudante novoEstudante = new Estudante { Nome = nome, Idade = idade, Curso = curso };
                    estudantes.Add(novoEstudante);
                    estudanteAtual = novoEstudante;
                    Console.WriteLine("Aluno cadastrado com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Alunos cadastrados:");
                    foreach (var estudante in estudantes)
                    {
                        Console.WriteLine(estudante.Nome);
                    }
                    CriarLinha();
                    Console.WriteLine("Digite o nome do aluno que deseja selecionar:");
                    string nomeAluno = Console.ReadLine();
                    CriarLinha();
                    estudanteAtual = estudantes.Find(e => e.Nome == nomeAluno);
                    if (estudanteAtual != null)
                    {
                        Console.WriteLine("Aluno selecionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Aluno não encontrado!");
                    }
                    break;
                case 3:
                    if (estudanteAtual != null)
                    {
                        estudanteAtual.Estudar();
                    }
                    else
                    {
                        Console.WriteLine("Nenhum aluno selecionado!");
                    }
                    break;
                case 4:
                    if (estudanteAtual != null)
                    {
                        Console.WriteLine("Matérias já estudadas:");
                        foreach (var materia in estudanteAtual.ConhecimentoMaterias.Keys)
                        {
                            Console.WriteLine(materia);
                        }
                        CriarLinha();
                        Console.WriteLine("Digite a matéria que deseja estudar:");
                        string materiaEstudo = Console.ReadLine();
                        CriarLinha();
                        estudanteAtual.Estudar(materiaEstudo);
                    }
                    else
                    {
                        Console.WriteLine("Nenhum aluno selecionado!");
                    }
                    break;
                case 5:
                    if (estudanteAtual != null)
                    {
                        estudanteAtual.FazerExame();
                    }
                    else
                    {
                        Console.WriteLine("Nenhum aluno selecionado!");
                    }
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    private static void CriarLinha()
    {
        Console.WriteLine("/-------------------------------------------------------------/");
    }
}
