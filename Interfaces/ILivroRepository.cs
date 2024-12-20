using Biblioteca.Entidades;

public interface ILivroRepository
{
    Task<Livro> AdicionarLivro(Livro livro);
    Task<Livro> BuscarLivro (int id);
    Task<IEnumerable<Livro>> BuscarTodosLivros();
    Task<Livro> AtualizarLivro(Livro livro);
    Task<bool> DeletarLivro(int id);
}