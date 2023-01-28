namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {


            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {

                throw new ArgumentOutOfRangeException("Número de hospedes superior a capacidade da Suite.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            int quantidade = Hospedes.Count;

            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {


            decimal valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;


            if (DiasReservados >= 10)
            {
                decimal desconto = (10 / 100) * valor;

                valor = valor - desconto;
            }

            return valor;
        }
    }
}