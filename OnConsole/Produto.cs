using System.Globalization;


namespace OnConsole {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public override string ToString() {
            return $"{Nome} " +
                $"|| Preço: {Preco.ToString("f2", CultureInfo.InvariantCulture)} " +
                $"|| {Quantidade} unidades"+
                $"|| Total: {ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)} ";
        }
    }
}
