namespace DescomplicandoGenerics.Domain
{
    public class Categoria : Entity
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }

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
