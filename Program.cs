using DescomplicandoGenerics.Data;
using DescomplicandoGenerics.Domain;
using DescomplicandoGenerics.Tela;

var produtoRepository = new ProdutoRepository();
var categoriaRepository = new CategoriaRepository();

produtoRepository.Adicionar(new Produto("Caderno", 10));
produtoRepository.Adicionar(new Produto("Tenis", 100));

categoriaRepository.Adicionar(new Categoria("Vestuario"));
categoriaRepository.Adicionar(new Categoria("Papelaria"));

ImprimirDados.ImprimirProdutos(produtoRepository.BuscarTodos());
ImprimirDados.ImprimirCatgoria(categoriaRepository.BuscarTodos());
