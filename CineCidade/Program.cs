namespace CineCidade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCliente;
            int qtdIngresso;
            string cupom;
            int idadeCliente;

            Console.Write("Digite o nome do cliente: ");
            nomeCliente = Console.ReadLine() ?? "";

            Console.Write("Digite a quantidade de ingressos: ");
            qtdIngresso = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o cupom de desconto: ");
            cupom = Console.ReadLine() ?? "";

            Console.Write("Digite a idade do cliente: ");
            idadeCliente = int.Parse(Console.ReadLine() ?? "0");

            Ingresso ingresso = new Ingresso();

            ingresso.nomeCliente = nomeCliente;
            ingresso.qtdIngresso = qtdIngresso;
            ingresso.cupom = cupom;
            ingresso.idadeCliente = idadeCliente;

            Console.WriteLine();
            Console.WriteLine("===== RESUMO DA COMPRA =====");

            Console.WriteLine($"Cliente: {ingresso.nomeCliente.ToUpper()}");
            Console.WriteLine($"Valor bruto: R$ {ingresso.CalcularValorBruto():F2}");
            Console.WriteLine($"Valor final: R$ {ingresso.CalcularValorFinal():F2}");
            Console.WriteLine($"Elegível para Sessão Noturna: {ingresso.ElegivelSessaoNoturna()}");
        }
    }
}
