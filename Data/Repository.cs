namespace DescomplicandoGenerics.Data
{
    public  class Repository<T> where T : class
    {
        private List<T> _itens;

        public Repository()
        {
            _itens = new List<T>();
        }

        public void Adicionar(T item)
        {
            _itens.Add(item);
        }

        public List<T> BuscarTodos()
        {
            return _itens;
        }
    }
}
