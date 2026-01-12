namespace helloworld;

public class Poligonos
{
    public void Poligono()
    {
        Console.WriteLine("--- Polígonos Regulares ---");
        Console.WriteLine("Digite o número de lados que o seu polígono tem:");
        var numeroDeLados = int.Parse(Console.ReadLine());
        if (numeroDeLados < 3)
        {
            Console.WriteLine("Não é um polígono!");
            return;
        }
        
        switch (numeroDeLados)
        {
            case 3:
                Console.WriteLine("TRIÂNGULO");
                break;
            case 4:
                Console.WriteLine("QUADRADO");
                break;
            case 5:
                Console.WriteLine("PENTÁGONO");
                break;
            default:
                Console.WriteLine("Polígono não encontrado");
                break;
        }
        Console.WriteLine("Fim do programa :)");
    } 
}