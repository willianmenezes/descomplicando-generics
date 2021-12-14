using DescomplicandoGenerics.Data;
using DescomplicandoGenerics.Domain;
using DescomplicandoGenerics.Tela;
using Microsoft.Extensions.DependencyInjection;

var provider = ConfigurarInjecaoDeDependencia();

var produtoRepository = provider.GetRequiredService<IRepository<Produto>>();
var categoriaRepository = provider.GetRequiredService<IRepository<Categoria>>();

produtoRepository.Adicionar(new Produto("Caderno", 10));
produtoRepository.Adicionar(new Produto("Tenis", 100));

categoriaRepository.Adicionar(new Categoria("Vestuario"));
categoriaRepository.Adicionar(new Categoria("Papelaria"));

produtoRepository.BuscarTodos().Imprimir();
categoriaRepository.BuscarTodos().Imprimir();

// convertendo explicitamente podendo dar excessoes de passarmos algo errado
var primeiroProduto = produtoRepository.BuscarTodos()[0];
//var primeiroProduto = (Produto)categoriaRepository.BuscarTodos()[0];

var nomeProduto = primeiroProduto.Nome;

Console.WriteLine(nomeProduto);


ServiceProvider ConfigurarInjecaoDeDependencia()
{
    var servicerCollection = new ServiceCollection();

    servicerCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));

    return servicerCollection.BuildServiceProvider();
}
