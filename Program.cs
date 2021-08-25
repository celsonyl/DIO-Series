using DIO.Series.Entidades;
using DIO.Series.Enums;
using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repository = new SerieRepositorio();
        static void Main(string[] args)
        {
            String escolha = opcao();

            while(escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        //AtualizarSerie();
                        break;
                    case "4":
                        //ExcluirSerie();
                        break;
                    case "5":
                        //VisualizarTela();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                escolha = opcao();
            }
        }

        public static void InserirSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Inserir nova série!");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            String titulo = Console.ReadLine();

            Console.Write("Digite o Ano de início da série: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            String descricao = Console.ReadLine();

            var serie = new Serie(id: repository.ProximoId(),
                genero: (Genero)genero, titulo: titulo, ano: ano, descricao: descricao);

            repository.Insere(serie);
        }

        private static void ListarSerie()
        {
            Console.WriteLine();
            Console.WriteLine("Listar séries");

            var list = repository.Lista();
            if(list.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada!");
                return;
            }

            foreach(var serie in list)
            {
                Console.WriteLine(serie.ToString());
            }
        }

        private static String opcao()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries!");
            Console.WriteLine("Escolha a opção desejada");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            String opcao = Console.ReadLine().ToUpper();
            return opcao;
        }
    }
}
