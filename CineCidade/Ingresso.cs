namespace CineCidade
{
    class Ingresso
    {
        public string nomeCliente;
        public int qtdIngresso;
        public string cupom;
        public int idadeCliente;

        public double CalcularValorBruto()
        {
            return 5.00 + (qtdIngresso * 25.00);
        }

        public double CalcularDesconto()
        {
            if (cupom == "CINEMA10")
            {
                return CalcularValorBruto() * 0.10;
            }

            return 0.00;
        }

        public double CalcularValorFinal()
        {
            return CalcularValorBruto() - CalcularDesconto();
        }

        public bool ElegivelSessaoNoturna()
        {
            return qtdIngresso > 1 && idadeCliente >= 18;
        }
    }
}
