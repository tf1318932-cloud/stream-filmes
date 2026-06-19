Filme filme = new Filme();

int opcao;

do
{
    Console.WriteLine("\n====CATALOGO DE FILMES=====");
    Console.WriteLine("1 - cadasttrar filme");
    Console.WriteLine("2 - exibir filme");
    Console.WriteLine("0 - sair");
    Console.WriteLine("escolha sua opção ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("titulo: ");
            filme.titulo = Console.ReadLine();

            Console.Write("genero: ");
            filme.genero = Console.ReadLine();

            Console.Write("ano lançamento: ");
            filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

            Console.Write("classificação indicativa: ");
            filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nFilme cdastrado com sucesso");

            break;
        case 2:
            if (string.IsNullOrEmpty(filme.titulo))
            {
                Console.WriteLine("\n Nenhum filme cadastrado ainda");
            }
            else
            {
                filme.ExibirInformacoes();
            }
            break;
        case 0:
            Console.WriteLine("\n prpograma encerrado");
            break;
        default:
            Console.WriteLine("\n opçaõ invalida");
            break;


    }

} while (opcao != 0);


Console.Write("titulo: ");
filme.titulo = Console.ReadLine();

Console.Write("genero: ");
filme.genero = Console.ReadLine();

Console.Write("ano lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.Write("classificação indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();