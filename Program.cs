using DescomplicandoGenerics.Data;
using DescomplicandoGenerics.Domain;
using DescomplicandoGenerics.Tela;

var produtoRepository = new Repository<Produto>();
var categoriaRepository = new Repository<Categoria>();

produtoRepository.Adicionar(new Produto("Caderno", 10));
produtoRepository.Adicionar(new Produto("Tenis", 100));

categoriaRepository.Adicionar(new Categoria("Vestuario"));
categoriaRepository.Adicionar(new Categoria("Papelaria"));

ImprimirDados.Imprimir<Produto>(produtoRepository.BuscarTodos());
ImprimirDados.Imprimir<Categoria>(categoriaRepository.BuscarTodos());

// convertendo explicitamente podendo dar excessoes de passarmos algo errado
var primeiroProduto = produtoRepository.BuscarTodos()[0];
//var primeiroProduto = (Produto)categoriaRepository.BuscarTodos()[0];

var nomeProduto = primeiroProduto.Nome;

Console.WriteLine(nomeProduto);
