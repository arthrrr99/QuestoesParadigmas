using System;
using System.Collections.Generic;

namespace AtvParadigmasProgramacao
{
    class QuestoesMenu
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            bool loop = true;

            do
            {
                Console.WriteLine("Questões Paradigmas");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Digite 1 - Questão 01");
                Console.WriteLine("Digite 2 - Questão 02");
                Console.WriteLine("Digite 3 - Questão 03");
                Console.WriteLine("Digite 4 - Questão 04");
                Console.WriteLine("Digite 5 - Questão 05");
                Console.WriteLine("------------------------------------------------------------");
                string key = Console.ReadLine();
                Console.Clear();

                switch (key)
                {
                    case "1":
                        Questao1();
                        break;
                    case "2":
                        Questao2();
                        break;
                    case "3":
                        Questao3();
                        break;
                    case "4":
                        Questao4();
                        break;
                    case "5":
                        Questao5();
                        break;
                    default:
                        Console.WriteLine("Opção invalida, favor escolha uma das opções abaixo");
                        Console.WriteLine("------------------------------------------------------");
                        Menu();
                        break;
                }

                Console.WriteLine("Pressione enter para retornar ao menu");
                Console.ReadKey();
                Console.Clear();
                Menu();

            } while (loop);
        }

        public static void Questao1()
        {
            List<Pessoa> MaisVelhoNovo = new List<Pessoa>();
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe as informações da primeira pessoa:");
            Console.Write("Informe o nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            pessoa.Idade = Convert.ToInt16(Console.ReadLine().Replace(".", ","));
            MaisVelhoNovo.Add(new Pessoa(pessoa.Nome, pessoa.Idade));

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa.Idade = Convert.ToInt16(Console.ReadLine().Replace(".", ","));
            MaisVelhoNovo.Add(new Pessoa(pessoa.Nome, pessoa.Idade));

            for (int i = 0; i < MaisVelhoNovo.Count;)
            {
                if (MaisVelhoNovo[i].Idade > MaisVelhoNovo[i + 1].Idade)
                {
                    Console.WriteLine("Mais velho: " + MaisVelhoNovo[i].Nome);
                    break;
                }
                else
                {
                    Console.WriteLine("A pessoa mais velha é: " + MaisVelhoNovo[i + 1].Nome);
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    break;
                }
            }
        }

        public static void Questao2()
        {
            List<Funcionario> Funci = new List<Funcionario>();
            Funcionario func = new Funcionario();
            double _mediaSalarial = 0;

            Console.WriteLine("Primeiro funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func.SalarioBruto = Convert.ToInt16(Console.ReadLine().Replace(".", ","));
            Funci.Add(new Funcionario(func.Nome, func.SalarioBruto));

            Console.WriteLine("Segundo funcionário:");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func.SalarioBruto = Convert.ToInt16(Console.ReadLine().Replace(".", ","));
            Funci.Add(new Funcionario(func.Nome, func.SalarioBruto));

            foreach (var item in Funci)
                _mediaSalarial += item.SalarioBruto;

            Console.WriteLine("Media Salarial = " + (_mediaSalarial / 2).ToString("F2").Replace(",", "."));
        }

        public static void Questao3()
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Informe a Altura do retangulo: ");
            retangulo.Altura = (double)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("Informe a Largura do retangulo:");
            retangulo.Largura = (double)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Retangulo FigGeometrica = new Retangulo(retangulo.Largura, retangulo.Altura);

            Console.WriteLine("Área: " + FigGeometrica.Area().ToString("F2").Replace(",", "."));
            Console.WriteLine("Perimetro: " + FigGeometrica.Perimetro().ToString("F2").Replace(",", "."));
            Console.WriteLine("Diagonal: " + FigGeometrica.Diagonal().ToString("F2").Replace(",", "."));
        }

        public static void Questao4()
        {
            Funcionario func = new Funcionario();
            Console.Write("Nome do Funcionario: ");
            func.Nome = Console.ReadLine();
            Console.Write("Informe o salario bruto: ");
            func.SalarioBruto = (double)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));
            Console.Write("Informe o imposto: ");
            func.Imposto = (double)Convert.ToDecimal(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Funcionário: " + func.Nome + " recebe atualmente: R$ " + func.SalarioLiquido().ToString("F2").Replace(",", "."));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.Write("Digite quantos % de aumento o funcionario terá: ");
            double porcentAumentoSalarial = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            func.AumentarSalario(porcentAumentoSalarial);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("Dado salarial atualizado: " + func.Nome + " passará a receber: " + func.SalarioLiquido().ToString("F2").Replace(",", "."));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        public static void Questao5()
        {
            Aluno alu = new Aluno();
            alu.nota = new double[3];
            double NotaPeriodo = 0;

            for (int i = 0; i < 1; i++)
            {
                Console.Write("Nome do Aluno: ");
                alu.Nome = Console.ReadLine();

                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("Digite as três notas do aluno: ");
                for (int j = 0; j < alu.nota.Length; j++)
                {
                    bool loopNota = true;

                    do
                    {
                        Console.Write(string.Format("{0}º Trimestre: ", j + 1));
                        alu.nota[j] = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

                        switch (j)
                        {
                            case 0:
                                if (alu.nota[j] <= 30f)
                                {
                                    NotaPeriodo = (NotaPeriodo + alu.nota[j]);
                                    loopNota = false;
                                }
                                else
                                    Console.WriteLine("Nota invalida, o 1º semestre permite apenas 30 pontos!");
                                Console.WriteLine("---------------------------------------------------------------------------------------------");
                                break;
                            default:
                                if (alu.nota[j] <= 35f)
                                {
                                    NotaPeriodo = (NotaPeriodo + alu.nota[j]);
                                    loopNota = false;
                                }
                                else
                                    Console.WriteLine("Nota invalida, o 2º e 3º semestre permite apenas 35  pontos!");
                                Console.WriteLine("---------------------------------------------------------------------------------------------");
                                break;
                        }
                    } while (loopNota);
                }

                Console.Write("Nota no periodo de 3 trimestre foi : " + NotaPeriodo.ToString("F2").Replace(",", "."));

                if (NotaPeriodo <= 60f)
                    Console.WriteLine("O Aluno foi reprovado faltou: " + (60f - NotaPeriodo).ToString("F2") + " pontos");
                else
                    Console.WriteLine(" ,o aluno foi aprovado");
            }
        }
    }
}
