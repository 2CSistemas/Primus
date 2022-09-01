using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Aplicacao.Enums;
using Aplicacao.Util;
using cwkGestao.Modelo.Util;
using DevExpress.XtraCharts;

namespace Aplicacao
{
    public partial class FormImagemProduto : Aplicacao.IntermediariasTela.FormImagemProdutoIntermediaria
    {
        public string CaminhoImagens = "";
        RedimensionaImagens RedImg = new RedimensionaImagens();
        private List<Tuple<string, bool>> _listaImagens;
        private int _totalImagens = 0;

        public FormImagemProduto()
        {
            pbCaminhoFoto.InitialImage = pbCaminhoFoto.Image;
        }

        protected override void InitializeChildComponents()
        {
            InitializeComponent();
        }

        protected override void AcoesAntesBase_Load(object sender, EventArgs e)
        {
            base.AcoesAntesBase_Load(sender, e);

            this.sbGravar.Visible = false;
            this.sbCancelar.Text = "Fechar";

            txtCaminhoImagem.Text = "";
            txtNumeroImagem.Text = "";
            _totalImagens = 0;
            ckbPrincipal.Checked = false;
            _listaImagens = new List<Tuple<string, bool>>();

            if (CaminhoImagens.IsNullOrEmpty()) return;

            var tempImagens = CaminhoImagens.Split('|');
            foreach (var item in tempImagens)
            {
                var caminho = item.Split(';');
                var imagemPrincipal = false;
                if (caminho.Length > 1) bool.TryParse(caminho[1], out imagemPrincipal);
                _listaImagens.Add(new Tuple<string, bool>(caminho[0], imagemPrincipal));
            }

            _totalImagens = _listaImagens?.Count() ?? 0;
            txtTotal.Text = _totalImagens.ToString();
            if (_totalImagens > 0)
                AtualizarImagem(_listaImagens[0].Item1, "1", _listaImagens[0].Item2);
            else
                AtualizarImagem("", "");
        }

        private void AtualizarImagem(string imagem, string numeroImagem, bool principal = false)
        {
            pbCaminhoFoto.Image = null;
            pbCaminhoFoto.Image = pbCaminhoFoto.InitialImage;

            if (imagem.IsNotNullOrEmpty())
            {
                txtCaminhoImagem.Text = imagem;
                txtNumeroImagem.Text = numeroImagem;
                ckbPrincipal.Checked = principal;
                if (File.Exists(imagem))
                    pbCaminhoFoto.Image = Image.FromFile(imagem);
            }
        }

        private void MudarImagem(SentidoImagem sentido)
        {
            if (_totalImagens < 1)
            {
                AtualizarImagem("", "");
                return;
            }

            switch (sentido)
            {
                case SentidoImagem.Anterior:
                    if (txtNumeroImagem.Text.IsNullOrEmpty())
                        AtualizarImagem(_listaImagens[0].Item1, "1", _listaImagens[0].Item2);
                    else
                    {
                        var atual = txtNumeroImagem.Text.ToInt();
                        if (_totalImagens.Equals(1) || atual.Equals(1)) return;

                        AtualizarImagem(_listaImagens[atual - 2].Item1, $"{atual - 1}", _listaImagens[atual - 2].Item2);
                    }
                    break;
                case SentidoImagem.Proxima:
                    if (txtNumeroImagem.Text.IsNullOrEmpty())
                        AtualizarImagem(_listaImagens[_totalImagens - 1].Item1, $"{_totalImagens}", _listaImagens[_totalImagens - 1].Item2);
                    else
                    {
                        var atual = txtNumeroImagem.Text.ToInt();
                        if (_totalImagens.Equals(1) || atual.Equals(_totalImagens)) return;
                        AtualizarImagem(_listaImagens[atual].Item1, $"{atual + 1}", _listaImagens[atual].Item2);
                    }
                    break;
            }
        }

        private void btnImagemAnterior_Click(object sender, EventArgs e)
        {
            MudarImagem(SentidoImagem.Anterior);
        }

        private void btnImagemProximo_Click(object sender, EventArgs e)
        {
            MudarImagem(SentidoImagem.Proxima);
        }
    }
}