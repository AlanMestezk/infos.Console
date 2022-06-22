


namespace OnConsole {
    class Program {

        static void Main(string[] args) {

            Produto item = new Produto();   
            
            Console.WriteLine("Entre com os dados do produto: ");
            Console.WriteLine(" ");

            Console.Write("Nome: ");
            item.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            item.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            item.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Produto: {item}");
           

        } 

    }
}