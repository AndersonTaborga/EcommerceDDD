using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notificacoes = new List<Notifies>();
        }

        [NotMapped]
        public string NomePropriedade { get; set; }
        [NotMapped]
        public string Mensagem { get; set; }
        [NotMapped]
        public List<Notifies> Notificacoes { get; set; }

        public bool ValidaPropriedadeString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrEmpty(valor) || string.IsNullOrEmpty(NomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }

            return true;
        }

        public bool ValidaPropriedadeInteiro(int valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrEmpty(NomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }

            return true;
        }

        public bool ValidaPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if (valor < 1 || string.IsNullOrEmpty(NomePropriedade))
            {
                Notificacoes.Add(new Notifies
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                return false;
            }

            return true;
        }


    }
}
