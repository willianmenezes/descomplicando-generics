namespace DescomplicandoGenerics.Domain
{
    public class Produto : Entity
    {
        public Produto(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }



        public override bool Equals(object? obj)
        {
            var prod = obj as Produto;

            if (prod == null)
                return false;

            return prod.Id == Id;
        }

        public override string ToString()
        {
            return $"{Id} - {Nome} - {Valor}";
        }
    }
}
