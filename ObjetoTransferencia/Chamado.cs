using System;

namespace ObjetoTransferencia
{
    public class Chamado
    {
        public int IdChamados { get; set; }
        public string NomeDoSolicitante { get; set; }
        public string TipoDeChamado { get; set; }
        public DateTime DataDoChamado { get; set; }
        public string DescricaoDoChamado { get; set; }
        public Boolean Situacao { get; set; }
    }
}
