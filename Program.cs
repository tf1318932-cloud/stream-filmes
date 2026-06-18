Filme filme = new Filme();

Console.Write("titulo: ");
filme.titulo = Console.ReadLine();

Console.Write("genero: ");
filme.genero = Console.ReadLine();

Console.Write("ano lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.Write("classificação indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();