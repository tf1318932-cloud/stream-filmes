public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n=== Filme cadastrado ===");
        Console.WriteLine("titulo: " + titulo);
        Console.WriteLine("genero: " + genero);
        Console.WriteLine("lançamento: " + anoLancamento);
        Console.WriteLine("clçassificação: " + classificacaoIndicativa);

    }
}