﻿using Aplicacao.Shared;
using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.ServicoModule;
using EnviaEmail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Aplicacao.AluguelModule
{
    public class AluguelAppServices : EntidadeAppServices<Aluguel>
    {
        public override IAluguelRepository Repositorio { get; }
        public IRelatorioRepository RelatorioRepositorio { get; }
        public IRelatorioAluguel Relatorio { get; }
        public IServicoRepository ServicoRepositorio { get; }
        public ICupomRepository CupomRepositorio { get; }

        public AluguelAppServices(IAluguelRepository repositorio, IRelatorioAluguel relatorio, IRelatorioRepository relatorioRepositorio, IServicoRepository servicoRepositorio, ICupomRepository cupomRepositorio)
        {
            Repositorio = repositorio;
            Relatorio = relatorio;
            RelatorioRepositorio = relatorioRepositorio;
            ServicoRepositorio = servicoRepositorio;
            CupomRepositorio = cupomRepositorio;
        }

        public async void IniciaLoopEnvioEmails()
        {
            while (true)
            {
                try
                {
                    TentaEnviarRelatorioEmail();
                }
                catch (FilaEmailVazia)
                {
                    await Task.Delay(new TimeSpan(0, 5, 0));
                }
            }
        }
        public void TentaEnviarRelatorioEmail()
        {
            var proxEnvio = RelatorioRepositorio.GetProxEnvio();

            if (proxEnvio == null)
                throw new FilaEmailVazia();

            Stream ms = proxEnvio.StreamAttachment;
            var attachment = new Attachment(ms, "Pdf Resumo Aluguel.pdf");

            var corpoEmail = "Confira o resumo do seu mais novo aluguel: ";
            var titulo = "Resumo Aluguel Rech-a-car";
            var emailUsuario = proxEnvio.Aluguel.Cliente.Email;

            Email.Envia(emailUsuario, titulo, corpoEmail, new List<Attachment>() { attachment });
            RelatorioRepositorio.MarcarEnviado(proxEnvio.Id);
        }
        public override ResultadoOperacao Inserir(Aluguel aluguel)
        {
            var insercao = base.Inserir(aluguel);
            if (insercao.Resultado == EnumResultado.Falha)
                return insercao;

            if (aluguel.Cupom != null)
            {
                aluguel.Cupom.Usos++;
                CupomRepositorio.Editar(aluguel.Cupom.Id, aluguel.Cupom);
            }

            ServicoRepositorio.AlugarServicos(aluguel.Id, aluguel.Servicos);

            var relatorio = Relatorio.GerarRelatorio(aluguel);
            RelatorioRepositorio.SalvarRelatorio(new RelatorioAluguel(aluguel, relatorio));
            return insercao;
        }
        public override ResultadoOperacao Editar(int id, Aluguel entidade)
        {
            var edicao = base.Editar(id, entidade);
            if (edicao.Resultado == EnumResultado.Falha)
                return edicao;

            ServicoRepositorio.DesalugarServicosAlugados(id);
            ServicoRepositorio.AlugarServicos(entidade.Id, entidade.Servicos);
            return edicao;
        }
        public ResultadoOperacao ValidarCupom(Aluguel aluguel)
        {
            if (aluguel.Cupom == null)
                return new ResultadoOperacao("Cupom não existe", EnumResultado.Falha);

            var validacao = aluguel.ValidarCupom();

            if (validacao == string.Empty)
                return new ResultadoOperacao("Cupom aplicado com sucesso", EnumResultado.Sucesso);

            return new ResultadoOperacao(validacao, EnumResultado.Falha);
        }
    }
    [Serializable]
    public class FilaEmailVazia : Exception
    {
        public FilaEmailVazia()
        {
        }

        public FilaEmailVazia(string message) : base(message)
        {
        }
    }
}
