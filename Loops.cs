namespace projeto;

public class Loops
{
    public void While()
    {
        Console.WriteLine("Digite o número: ");
        var x = int.Parse(Console.ReadLine());
        while (x !=  0)
        {
            Console.WriteLine("Ainda não é esse! Tente outro: ");
            x = int.Parse(Console.ReadLine());
        } 
        Console.Write("Você acertou!");
    }

    public void DoWhile() // a primeira rodada dele sempre vai acontecer 
    {
        Console.Write("Digite o numero: "); 
        var x = int.Parse(Console.ReadLine());
        var contador = 1;
        do
        {
            Console.WriteLine($" = {contador}");
            contador++;
        } while (contador < x);
    }
    
    public void DoWhileUntil0() // a primeira rodada dele sempre vai acontecer 
    {
        int x;
        do
        {
            Console.WriteLine("Tente um número: ");
            x = int.Parse(Console.ReadLine());
        } while (x != 0);
        Console.Write("Você acertou!");
    }
}