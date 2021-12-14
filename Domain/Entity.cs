namespace DescomplicandoGenerics.Domain
{
    public abstract class Entity
    {
        protected Entity() => Id = Guid.NewGuid();

        public Guid Id { get; set; }
        public abstract override string ToString();
        public abstract override bool Equals(object? obj);
    }
}
