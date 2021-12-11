using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Tela
{
    public static class ImprimirDados
    {
        public static void ImprimirProdutos(List<Produto> produtos)
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Lista de produtos vazia");
                return;
            }

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine();
        }

        public static void ImprimirCatgoria(List<Categoria> categorias)
        {
            if (categorias.Count == 0)
            {
                Console.WriteLine("Lista de categorias vazia");
                return;
            }

            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria);
            }

            Console.WriteLine();
        }
    }
}
