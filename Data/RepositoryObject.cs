namespace DescomplicandoGenerics.Data
{
    internal class RepositoryObject
    {
        private List<object> _objetos;

        public RepositoryObject()
        {
            _objetos = new List<object>();
        }

        public void Adicionar(object obj)
        {
            _objetos.Add(obj);
        }

        public List<object> BuscarTodos()
        {
            return _objetos;
        }
    }
}
