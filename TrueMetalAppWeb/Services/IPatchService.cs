using TrueMetalAppWeb.Models;

namespace TrueMetalAppWeb.Services;

public interface IPatchService
{
    IList<Patch> ObterTodos();
    Patch Obter(int id);
    void Incluir(Patch patch);
    void Alterar(Patch patch);
    void Excluir(int id);
    IList<Genero> ObterTodosGeneros();
    Genero ObterGenero(int id);
}
