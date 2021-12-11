using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Data
{
    public class ProdutoRepository
    {
        private List<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = new List<Produto>();
        }

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public List<Produto> BuscarTodos()
        {
            return _produtos;
        }
    }
}
