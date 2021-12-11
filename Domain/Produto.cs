namespace DescomplicandoGenerics.Domain
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {Valor}";
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
