namespace helloworld;

public class Cardapio
{
    public void Pedido()
    {
        Console.WriteLine("---- Cardápio ----");
        Console.WriteLine("Digite o código do produto (1 a 3) que você deseja: ");
        var pedido = int.Parse(Console.ReadLine());

        switch (pedido)
        {
            case 1:
                Console.WriteLine("Hambúrguer...... R$ 18.00");
                break;
            case 2:
                Console.WriteLine("Cheeseburger...... R$ 20.00");
                break;
            case 3:
                Console.WriteLine("Batata Frita...... R$ 10.00");
                break;
            default:
                Console.WriteLine("Produto não encontrado!");
                break;
        }

        if (pedido != 1 && pedido != 2 && pedido != 3)
        {
            Console.WriteLine("Por favor selecione um produto disponível!.");
        }
        else
        {
            Console.WriteLine("Bom Apetite!");
        }
      
    }
}