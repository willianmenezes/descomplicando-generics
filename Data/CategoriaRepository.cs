using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Data
{
    public class CategoriaRepository
    {
        private List<Categoria> _categorias;

        public CategoriaRepository()
        {
            _categorias = new List<Categoria>();
        }

        public void Adicionar(Categoria categoria)
        {
            _categorias.Add(categoria);
        }

        public List<Categoria> BuscarTodos()
        {
            return _categorias;
        }
    }
}
