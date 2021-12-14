using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Data
{
    public interface IRepository <T> where T : Entity
    {
        public void Adicionar(T item);

        public List<T> BuscarTodos();
    }
}
