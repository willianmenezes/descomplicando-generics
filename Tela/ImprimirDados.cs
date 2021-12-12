using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Tela
{
    public static class ImprimirDados
    {
        public static void Imprimir<T>(List<T> item)
        {
            if (item.Count == 0)
            {
                Console.WriteLine($"Lista de {typeof(T).Name} vazia");
                return;
            }

            foreach (var obj in item)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }
    }
}
