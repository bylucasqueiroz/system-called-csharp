
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ChamadoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public  string Inserir(Chamado chamado)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeDoSolicitante", chamado.NomeDoSolicitante);
                acessoDadosSqlServer.AdicionarParametros("@TipoDeChamado", chamado.TipoDeChamado);
                acessoDadosSqlServer.AdicionarParametros("@DataDoChamado", chamado.DataDoChamado);
                acessoDadosSqlServer.AdicionarParametros("@DescricaoDoChamado", chamado.DescricaoDoChamado);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", chamado.Situacao);
                string idChamados = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspChamadoInserir").ToString();
                return idChamados;
            }
            catch(Exception excepiton)
            {
                return excepiton.Message;
            }
        }

        public string Alterar(Chamado chamado)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdChamados", chamado.IdChamados);
                acessoDadosSqlServer.AdicionarParametros("@NomeDoSolicitante", chamado.NomeDoSolicitante);
                acessoDadosSqlServer.AdicionarParametros("@TipoDeChamado", chamado.TipoDeChamado);
                acessoDadosSqlServer.AdicionarParametros("@DataDoChamado", chamado.DataDoChamado);
                acessoDadosSqlServer.AdicionarParametros("@DescricaoDoChamado", chamado.DescricaoDoChamado);
                acessoDadosSqlServer.AdicionarParametros("@Situacao", chamado.Situacao);
                string idChamados = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspChamadoAlterar").ToString();
                return idChamados;
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Chamado chamado)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdChamados", chamado.IdChamados);
                string idChamados = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspChamadoExcluir").ToString();
                return idChamados;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public ChamadoCollection ConsultarPorNome(string nome)
        {
            try
            {
                ChamadoCollection chamadoCollection = new ChamadoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeDoSolicitante", nome);

                DataTable dataTableChamado = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspChamadoConsultarPorNomeDoSolicitante");

                foreach (DataRow linha in dataTableChamado.Rows)
                {
                    Chamado chamado = new Chamado();

                    chamado.IdChamados = Convert.ToInt32(linha["IdChamados"]);
                    chamado.NomeDoSolicitante = Convert.ToString(linha["NomeDoSolicitante"]);
                    chamado.TipoDeChamado = Convert.ToString(linha["TipoDeChamado"]);
                    chamado.DataDoChamado = Convert.ToDateTime(linha["DataDoChamado"]);
                    chamado.DescricaoDoChamado = Convert.ToString(linha["DescricaoDoChamado"]);
                    chamado.Situacao = Convert.ToBoolean(linha["Situacao"]);

                    chamadoCollection.Add(chamado);
                }
                return chamadoCollection;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível consultar o chamado por Nome. Detalhes: " + ex.Message);
            }
        }

        public ChamadoCollection ConsultarPorId(int idChamado)
        {
            try
            {
                ChamadoCollection chamadoCollection = new ChamadoCollection();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdChamado", idChamado);

                DataTable dataTableChamado = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspChamadoConsultarPorId");

                foreach ( DataRow dataRowLinha  in dataTableChamado.Rows)
                {
                    Chamado chamado = new Chamado();

                    chamado.IdChamados = Convert.ToInt32(dataRowLinha["IdChamados"]);
                    chamado.NomeDoSolicitante = Convert.ToString(dataRowLinha["NomeDoSolicitante"]);
                    chamado.TipoDeChamado = Convert.ToString(dataRowLinha["TipoDeChamado"]);
                    chamado.DataDoChamado = Convert.ToDateTime(dataRowLinha["DataDoChamado"]);
                    chamado.DescricaoDoChamado = Convert.ToString(dataRowLinha["DescricaoDoChamado"]);
                    chamado.Situacao = Convert.ToBoolean(dataRowLinha["Situacao"]);

                    chamadoCollection.Add(chamado);
                }

                return chamadoCollection;
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível consultar o chamado por ID. Detalhes: " + ex.Message);
            }
        }
    }
}
