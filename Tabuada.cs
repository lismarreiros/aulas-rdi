namespace helloworld;

public class Tabuada
{
    public void Tabuadas()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Tabuada do {i}");
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;
                Console.WriteLine($"{i} x {j} = {resultado}");
            }
            Console.WriteLine("FIM");
        }
    }
}