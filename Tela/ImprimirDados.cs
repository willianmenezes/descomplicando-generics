using DescomplicandoGenerics.Domain;

namespace DescomplicandoGenerics.Tela
{
    public static class ImprimirDados
    {
        public static void Imprimir(List<object> objetos)
        {
            if (objetos.Count == 0)
            {
                Console.WriteLine($"Lista de {objetos.GetType()} vazia");
                return;
            }

            foreach (var obj in objetos)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
        }
    }
}
