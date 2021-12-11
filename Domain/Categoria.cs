namespace DescomplicandoGenerics.Domain
{
    public class Categoria
    {
        public Categoria(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome}";
        }

        public override bool Equals(object? obj)
        {
            var prod = obj as Produto;

            if (prod == null)
                return false;

            return prod.Id == Id;
        }
    }
}
