namespace projeto;

public class Tipos
{
    public void TiposPrimitivos()
    {
        Console.WriteLine("=== Exemplo: Estruturas de Dados ===\n");

        // Imagine que você precisa guardar informações sobre frutas
        // Sem estrutura: seria difícil organizar e acessar
        // Com estrutura: fica fácil!

        // Tipo simples (string, int, bool, double)
        string fruta = "Banana";
        int quantidadeDeFrutas = 3;
        bool estoqueDisponivel = true;
        double precoMedio = 2.14;
        string mensagem = "Bem-vindo ao programa de frutas!";
        Console.WriteLine($"Quantidade de bananas: {quantidadeDeFrutas}");
        Console.WriteLine($"Preço Médio: {precoMedio}");
        Console.WriteLine($"Estoque disponível?: {estoqueDisponivel}");
        Console.WriteLine($"Mensagem: {mensagem}");
        Console.WriteLine("Quantas bananas você quer?");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 0)
        {
            Console.Write("Até logo!");
        }
        else
        {
            int quantidade = resposta;
            double aumento = precoMedio * 1.1;
            double novoPreco = precoMedio * aumento;
            double total = quantidade * novoPreco;
            string totalFormatado = total.ToString("F2");
            if (quantidade > quantidadeDeFrutas)
            {
                estoqueDisponivel = false;
            }

            Console.Write(
                $"Quantidade de {fruta}: {quantidade}, o valor é {totalFormatado}. Estoque disponível: {estoqueDisponivel}");
        }
    }

    public void TipoArray()
    {
        // Array: lista fixa de frutas
        // estruturas fixas - sempre terá a posição definida no começo!
        // não é dinâmico, não é possível aumentar ou diminuir, não existe PUSH ou POP
        // permitem alterações, ótima performance
        // para excluir deve-se atribuir um valor vazio
        // impressão via loop / iteração! 
        // arrays de tipos únicos! não é possível ter strings com ints, etc. 
        string[] frutasArray = ["Banana", "Maçã", "Uva"];
        string[] frutas = new string[3];
        frutas[0] = "Kiwi";
        frutas[1] = "Pitaya";
        frutas[2] = "Romã";

        Console.WriteLine("\nArray de frutas:");
        foreach (var f in frutasArray) // não é possível imprimir o índice diretamente na sintaxe padrão 
        {
            Console.WriteLine($" - {f}");
        }

        frutas[1] = "Pera";
        int frutinha = Array.IndexOf(frutas, "Maça");
        Console.WriteLine($"\nIndex de frutinha: {frutinha}");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($" índice {i}: {frutas[i]}");
        }
    }

    public void TipoList()
    {
        // Lista: coleção dinâmica
        // permite alteração
        // métodos: add (adiciona na última posição), remove, clear, sort, indexOf
        // impressão via loop e iteração
        // não aceita tipos primitivos diferentes, mas é possível com complexos (definidos pelo dev)
        // na list para saber length > count! 

        // List<Tipo> nome = new List<Tipo> {10, 20} pode iniciar com valores 
        List<string> frutasLista = new List<string>();
        frutasLista.Add("Laranja");
        frutasLista.Add("Melancia");
        Console.WriteLine("\nLista de frutas (dinâmica):");
        foreach (var f in frutasLista)
        {
            Console.WriteLine($" - {f}");
        }

        List<int> numeros = new List<int> { 10, 20, 30 };
        Console.WriteLine("\nLista de numeros:");
        foreach (var num in numeros)
        {
            Console.WriteLine($" - {num}");
        }

        numeros[1] = 50;
        int idx = numeros.IndexOf(10);
        numeros[idx] = 5;
        numeros.Remove(30);
        if (numeros.Contains(50))
        {
            Console.WriteLine("A lista contém 50");
        }
        Console.WriteLine("\nLista de numeros atualizada:");
        for (int i = 0; i < numeros.Count; i++)
        {
            Console.WriteLine($"{i} - {numeros[i]}");
        }
        
        Console.WriteLine("\nLista tem " + numeros.Count + " valores");
    }

    public void TipoDict()
    {
        // Dicionário: chave-valor (fruta -> cor)
        // estruturas dinâmicas
        // permite alteração
        // utilizam chaves e não índices
        // impressão via loop / iteração
        // possui métodos para manipular 
        // ----- Dictionary<TKey, TValue> ----- 
        Dictionary<int, string> frutasCores = new Dictionary<int, string>();
        frutasCores[1] = "Banana";
        frutasCores[2] = "Uva";
        Console.WriteLine("\nDicionário (Chave -> Valor):");
        foreach (var par in frutasCores)
        {
            Console.WriteLine($" - {par.Key} é {par.Value}");
        }

        Dictionary<string, string> capitais = new Dictionary<string, string>();
        capitais["Brasil"] = "Brasília";
        capitais["França"] = "Paris";
        capitais.Add("Canada", "Ottawa");
        capitais.Add("Japão", "Tóquio");
        bool england = capitais.ContainsKey("Inglaterra");
        Console.WriteLine(england);
        foreach (var kv in capitais) 
        {
            Console.WriteLine($" {kv.Key} -> {kv.Value}");
        }
    
        // para fazer um for - copia as chaves para uma array antes? pois não há indice
        string[] chaves = new string[capitais.Count];
        capitais.Keys.CopyTo(chaves, 0);
        for (int i = 0; i < capitais.Count; i++)
        {
            string chave = chaves[i];
            string valor = capitais[chave];
            Console.WriteLine($" - {chaves[i]} - {valor}");
        }
        Console.WriteLine("\nPor que isso é importante?");
        Console.WriteLine("Organizar dados facilita encontrar, atualizar e usar informações rapidamente.");
    }

}