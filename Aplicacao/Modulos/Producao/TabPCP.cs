using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;
using System.Reflection;
using cwkGestao.Negocio.Utils;
using cwkGestao.Negocio;
using NHibernate.Collection;

namespace Aplicacao.Modulos.Producao
{
    public partial class TabPCP : UserControl
    {
       

        #region Sets/Gets componentes TabPCP

        public DevExpress.XtraGrid.GridControl gcFichaTecnicaPCPRegra { 
            get
            {
                return _gcFichaTecnicaPCPRegra;
            }
            set
            {
                _gcFichaTecnicaPCPRegra = value;
            }
        }
        public DevExpress.XtraEditors.MemoEdit meObservacao {
            get
            {
                return _meObservacao;
            }
            set
            {
                _meObservacao = value;
            }
        }
        public DevExpress.XtraGrid.GridControl gcFichaTecnicaPCPItem
        {
            get
            {
                return _gcFichaTecnicaPCPItem;
            }
            set
            {
                _gcFichaTecnicaPCPItem = value;
            }
        }
        public DevExpress.XtraGrid.Views.Grid.GridView gvFichaTecnicaPCPItem
        {
            get
            {
                return _gvFichaTecnicaPCPItem;
            }
            set
            {
                _gvFichaTecnicaPCPItem = value;
            }
        }
        public System.Windows.Forms.PictureBox pbImagemProduto
        {
            get
            {
                return _pbImagemProduto;
            }
            set
            {
                _pbImagemProduto = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seRevisao
        {
            get
            {
                return _seRevisao;
            }
            set
            {
                _seRevisao = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit sePesoLiquido
        {
            get
            {
                return _sePesoLiquido;
            }
            set
            {
                _sePesoLiquido = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seVolumeLiquido
        {
            get
            {
                return _seVolumeLiquido;
            }
            set
            {
                _seVolumeLiquido = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seAreaLiquido
        {
            get
            {
                return _seAreaLiquido;
            }
            set
            {
                _seAreaLiquido = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seEspessuraLiquido
        {
            get
            {
                return _seEspessuraLiquido;
            }
            set
            {
                _seEspessuraLiquido = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seLarguraLiquido
        {
            get
            {
                return _seLarguraLiquido;
            }
            set
            {
                _seLarguraLiquido = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seComprimentoLiquido
        {
            get
            {
                return _seComprimentoLiquido;
            }
            set
            {
                _seComprimentoLiquido = value;
            }
        }
        public DevExpress.XtraEditors.TextEdit txtCodBarras
        {
            get
            {
                return _txtCodBarras;
            }
            set
            {
                _txtCodBarras = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit sePecaOP
        {
            get
            {
                return _sePecaOP;
            }
            set
            {
                _sePecaOP = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit sePesoBruto
        {
            get
            {
                return _sePesoBruto;
            }
            set
            {
                _sePesoBruto = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seVolumeBruto
        {
            get
            {
                return _seVolumeBruto;
            }
            set
            {
                _seVolumeBruto = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seAreaBruto
        {
            get
            {
                return _seAreaBruto;
            }
            set
            {
                _seAreaBruto = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seEspessuraBruto
        {
            get
            {
                return _seEspessuraBruto;
            }
            set
            {
                _seEspessuraBruto = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seLarguraBruto
        {
            get
            {
                return _seLarguraBruto;
            }
        }
        public DevExpress.XtraEditors.MemoEdit meFormula
        {
            get
            {
                return _meFormula;
            }
            set
            {
                _meFormula = value;
            }
        }
        public DevExpress.XtraEditors.SpinEdit seComprimentoBruto
        {
            get
            {
                return _seComprimentoBruto;
            }
            set
            {
                _seComprimentoBruto = value;
            }
        }
        public DevExpress.XtraEditors.DateEdit deData
        {
            get
            {
                return _deData;
            }
            set
            {
                _deData = value;
            }
        }
        public DevExpress.XtraEditors.TextEdit txtCodigo
        {
            get
            {
                return _txtCodigo;
            }
            set
            {
                _txtCodigo = value;
            }
        }
        public FichaTecnicaPCP Ficha { get; set; }

        public event EventHandler BotaoEAN13Clicado;
        public event EventHandler BotaoCarregaFichaClicado;

        #endregion

        #region Construtores
        
        public TabPCP(FichaTecnicaPCP FichaTecnica)
        {
            InitializeComponent();
            this.Ficha = FichaTecnica;
            PreencheTab();
            dxErrorProviderTab.ClearErrors();
        }

        public TabPCP()
        {
            InitializeComponent();
            this.Ficha = new FichaTecnicaPCP();
            if (this.Ficha.FichaTecnicaPCPItens == null)
            {
                this.Ficha.FichaTecnicaPCPItens = new List<FichaTecnicaPCPItem>();
            }
            if (this.Ficha.FichaTecnicaPCPRegras == null)
            {
                this.Ficha.FichaTecnicaPCPRegras = new List<FichaTecnicaPCPRegra>();
            }
            PreencheTab();
            dxErrorProviderTab.ClearErrors();
        }

        #endregion

        #region Metodos de preenchimento

        public void PreencheTab()
        {
            this.txtCodigo.Text = this.Ficha.Codigo;
            this.txtCodBarras.Text = this.Ficha.Barra;
            this.deData.EditValue = this.Ficha.Data;
            this.seRevisao.EditValue = this.Ficha.NumeroRevisao;
            this.sePecaOP.EditValue = this.Ficha.PecasOP;
            this.seComprimentoBruto.EditValue = this.Ficha.ComprimentoBruto;
            this.seComprimentoLiquido.EditValue = this.Ficha.ComprimentoLiquido;
            this.seLarguraBruto.EditValue = this.Ficha.LarguraBruta;
            this.seLarguraLiquido.EditValue = this.Ficha.LarguraLiquida;
            this.seEspessuraBruto.EditValue = this.Ficha.EspessuraBruta;
            this.seEspessuraLiquido.EditValue = this.Ficha.EspessuraLiquida;
            this.seEspessuraLiquido.EditValue = this.Ficha.EspessuraLiquida;
            this.seAreaBruto.EditValue = this.Ficha.AreaBruta;
            this.seAreaLiquido.EditValue = this.Ficha.AreaLiquida;
            this.seVolumeBruto.EditValue = this.Ficha.VolumeBruto;
            this.seVolumeLiquido.EditValue = this.Ficha.VolumeLiquido;
            this.sePesoBruto.EditValue = this.Ficha.PesoBruto;
            this.sePesoLiquido.EditValue = this.Ficha.PesoLiquido;
            this.meFormula.EditValue = this.Ficha.Formula;
            this.meObservacao.EditValue = this.Ficha.Observacao;
            this.pbImagemProduto.Image = ImageUtil.byteArrayToImage(this.Ficha.Imagem);
            this.pbImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            this.gcFichaTecnicaPCPItem.DataSource = this.Ficha.FichaTecnicaPCPItens;
            this.gcFichaTecnicaPCPRegra.DataSource = this.Ficha.FichaTecnicaPCPRegras;
            this.Refresh();
        }

        public void PreencheFicha(Produto p)
        {
            this.Ficha.Codigo = this.txtCodigo.Text;
            this.Ficha.Barra = this.txtCodBarras.Text;
            this.Ficha.Data = this.deData.DateTime;
            this.Ficha.NumeroRevisao = (int)this.seRevisao.Value;
            this.Ficha.PecasOP = (int)this.sePecaOP.Value;
            this.Ficha.ComprimentoBruto = this.seComprimentoBruto.Value;
            this.Ficha.ComprimentoLiquido = this.seComprimentoLiquido.Value;
            this.Ficha.LarguraBruta = this.seLarguraBruto.Value;
            this.Ficha.LarguraLiquida = this.seLarguraLiquido.Value;
            this.Ficha.EspessuraBruta = this.seEspessuraBruto.Value;
            this.Ficha.EspessuraLiquida = this.seEspessuraLiquido.Value;
            this.Ficha.EspessuraLiquida = this.seEspessuraLiquido.Value;
            this.Ficha.AreaBruta = this.seAreaBruto.Value;
            this.Ficha.AreaLiquida = this.seAreaLiquido.Value;
            this.Ficha.VolumeBruto = this.seVolumeBruto.Value;
            this.Ficha.VolumeLiquido = this.seVolumeLiquido.Value;
            this.Ficha.PesoBruto = this.sePesoBruto.Value;
            this.Ficha.PesoLiquido = this.sePesoLiquido.Value;
            this.Ficha.Formula = this.meFormula.Text;
            this.Ficha.Observacao = this.meObservacao.Text;
            this.Ficha.Imagem = ImageUtil.imageToByteArray(this.pbImagemProduto.Image);
            this.Ficha.FichaTecnicaPCPItens = (IList<FichaTecnicaPCPItem>)(this.gcFichaTecnicaPCPItem.DataSource);//(PersistentBag)
            this.Ficha.FichaTecnicaPCPRegras = (IList<FichaTecnicaPCPRegra>)(this.gcFichaTecnicaPCPRegra.DataSource);//(PersistentBag)
            this.Ficha.Produto = p;
        }

        #endregion

        #region Eventos

        #region Imagem
        private void _sbCapturarImagemProduto_Click(object sender, EventArgs e)
        {
            FormCapturaFotoBD fcf = new FormCapturaFotoBD();
            if (fcf.ShowDialog() == DialogResult.OK)
            {
                this.pbImagemProduto.Image = fcf.Imagem;
                this.pbImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void _sbSelecionarImagemProduto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Abrir Imagem";
                dlg.InitialDirectory = @"%USERPROFILE%";
                dlg.Filter = "Arquivos de Imagem|*.bmp;*.dib;*.jpg;*.jpe;*.jpeg;*.jfif;*.png;*.tif;*.tiff;*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    this.pbImagemProduto.Image = Image.FromFile(dlg.FileName);
                    this.pbImagemProduto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void _sbExcluirImagemProduto_Click(object sender, EventArgs e)
        {
            this.pbImagemProduto.Image = null;
        }
        #endregion

        #region EAN
        private void _sbEAN13_Click(object sender, EventArgs e)
        {
            if (this.BotaoEAN13Clicado != null)
                this.BotaoEAN13Clicado(new object(), new EventArgs());

        }
        #endregion

        #region Carregaficha
        private void _sbCarregaFichaTecnicaItens_Click(object sender, EventArgs e)
        {
            GridCarregaFichaTecnica grid = new GridCarregaFichaTecnica();
            try
            {
                string NomeAnterior = this.Ficha.Nome;
                FichaTecnicaPCP ft = grid.ShowForm();
                
                if (ft != null)
                {
                    this.Ficha = ft;
                    this.Ficha.ID = 0;
                    this.Ficha.Nome = NomeAnterior;
                    foreach (FichaTecnicaPCPItem item in Ficha.FichaTecnicaPCPItens)
                    {
                        item.ID = 0;
                        item.FichaTecnicaPCP = null;
                    }
                    foreach (FichaTecnicaPCPRegra item in Ficha.FichaTecnicaPCPRegras)
                    {
                        item.ID = 0;
                        item.FichaTecnicaPCP = null;
                    }
                    PreencheTab();
                    if (this.BotaoCarregaFichaClicado != null)
                    {
                        this.BotaoCarregaFichaClicado(new object(), new EventArgs());
                    }
                }
            }
            catch (Exception z)
            {

                new Aplicacao.Base.FormErro(z).ShowDialog();
                return;
            }

        }
        #endregion

        #region FichaTecnicaItem (marcos)
        private void _sbIncluiFichaTecnicaItem_Click(object sender, EventArgs e)
        {
            FormFichaTecnicaPCPItem form = new FormFichaTecnicaPCPItem(this.Ficha.Produto);
            form.Operacao = Acao.Incluir;
            form.Text = form.Text + this.Ficha.Nome;
            form.ShowDialog();
            if (form.Selecionado != null)
            {
                this.Ficha.FichaTecnicaPCPItens = (IList<FichaTecnicaPCPItem>)gcFichaTecnicaPCPItem.DataSource;
                this.Ficha.FichaTecnicaPCPItens.Add(form.Selecionado);
                gcFichaTecnicaPCPItem.DataSource = this.Ficha.FichaTecnicaPCPItens;
                gcFichaTecnicaPCPItem.RefreshDataSource();
                gvFichaTecnicaPCPItem.RefreshData();
                gcFichaTecnicaPCPItem.Refresh();
            }
        }

        private void _sbAlteraFichaTecnicaItem_Click(object sender, EventArgs e)
        {
            var fichaItem = (FichaTecnicaPCPItem)gvFichaTecnicaPCPItem.GetRow(gvFichaTecnicaPCPItem.GetSelectedRows()[0]);
            FormFichaTecnicaPCPItem form = new FormFichaTecnicaPCPItem(fichaItem);
            form.Operacao = Acao.Alterar;
            form.Text = form.Text + this.Ficha.Nome;
            form.ShowDialog();

            if (form.Selecionado != null)
            {
                this.Ficha.FichaTecnicaPCPItens = (IList<FichaTecnicaPCPItem>)gcFichaTecnicaPCPItem.DataSource;
                int index = this.Ficha.FichaTecnicaPCPItens.IndexOf(fichaItem);
                this.Ficha.FichaTecnicaPCPItens[index] = form.Selecionado;

                gcFichaTecnicaPCPItem.DataSource = this.Ficha.FichaTecnicaPCPItens;
                gcFichaTecnicaPCPItem.RefreshDataSource();
                gvFichaTecnicaPCPItem.RefreshData();
                gcFichaTecnicaPCPItem.Refresh();
            }
        }

        private void _sbExcluiFichaTecnicaItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este item ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (gvFichaTecnicaPCPItem.RowCount == 0)
                {
                    MessageBox.Show("Não há itens para excluir !","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var fichaItem = (FichaTecnicaPCPItem)gvFichaTecnicaPCPItem.GetRow(gvFichaTecnicaPCPItem.GetSelectedRows()[0]);

                if (fichaItem != null)
                {
                    this.Ficha.FichaTecnicaPCPItens = (IList<FichaTecnicaPCPItem>)gcFichaTecnicaPCPItem.DataSource;
                    this.Ficha.FichaTecnicaPCPItens.Remove(fichaItem);

                    if (fichaItem.ID != 0)
                    {
                        FichaTecnicaPCPItemController.Instancia.Salvar(fichaItem, Acao.Excluir);
                    }

                    gcFichaTecnicaPCPItem.DataSource = this.Ficha.FichaTecnicaPCPItens;

                    gcFichaTecnicaPCPItem.RefreshDataSource();
                    gvFichaTecnicaPCPItem.RefreshData();
                    gcFichaTecnicaPCPItem.Refresh();
                }
                else
                    MessageBox.Show("Nenhum registro selecionado !","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region FichaTecnicaRegra (maykon)

        IList<FichaTecnicaPCPRegra> lAux = new List<FichaTecnicaPCPRegra>();
        private int UltimoNumero(IList<FichaTecnicaPCPRegra> lista)
        {
            int maiorNumero = 1;
            if (lista!=null)
            {
                foreach (FichaTecnicaPCPRegra item in lista)
                {
                    if (maiorNumero == item.Codigo)
                        maiorNumero++;
                    if (item.Codigo > maiorNumero)
                        maiorNumero = item.Codigo;
                }
            }

            return maiorNumero;
        }

        private void _sbIncluiFichaTecnicaRegra_Click(object sender, EventArgs e)
        {

             if (gcFichaTecnicaPCPRegra.DataSource != null)
                lAux = (IList<FichaTecnicaPCPRegra>)gcFichaTecnicaPCPRegra.DataSource;
            
            FormFichaTecnicaPCPRegra form = new FormFichaTecnicaPCPRegra(UltimoNumero(lAux) , null);
            form.Text = "Incluir Regra - " + this.Ficha.Nome;
            form.ShowDialog();

            if (form.Selecionado != null)
            {
                var aux = form.Selecionado;
                lAux.Add(aux);
            }

            gcFichaTecnicaPCPRegra.DataSource = lAux;
            gcFichaTecnicaPCPRegra.RefreshDataSource();
            gcFichaTecnicaPCPRegra.Refresh();
        }

        private void _sbAlteraFichaTecnicaRegra_Click(object sender, EventArgs e)
        {
            lAux = (IList<FichaTecnicaPCPRegra>)gcFichaTecnicaPCPRegra.DataSource;
            if (_gvFichaTecnicaPCPRegra.SelectedRowsCount > 0)
            {
                FichaTecnicaPCPRegra regra = null;

                regra = (FichaTecnicaPCPRegra)_gvFichaTecnicaPCPRegra.GetRow(_gvFichaTecnicaPCPRegra.GetSelectedRows()[0]);


                FormFichaTecnicaPCPRegra form = new FormFichaTecnicaPCPRegra(UltimoNumero(lAux), regra);
                form.Text = "Alterar Regra - " + this.Ficha.Nome;
                int xx = _gvFichaTecnicaPCPRegra.GetSelectedRows()[0];
                form.ShowDialog();

                if (form.Selecionado != null)
                {
                    var aux = form.Selecionado;
                    lAux.RemoveAt(xx);
                    lAux.Add(aux);
                }

                lAux = lAux.OrderBy(x => x.Codigo).ToList();
                gcFichaTecnicaPCPRegra.DataSource = lAux;

                gcFichaTecnicaPCPRegra.RefreshDataSource();
                gcFichaTecnicaPCPRegra.Refresh();
            }
            else
            {
                MessageBox.Show ("Selecione uma regra.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void _sbExcluiFichaTecnicaRegra_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja escluir esta regra?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                FichaTecnicaPCPRegra temp = (FichaTecnicaPCPRegra)_gvFichaTecnicaPCPRegra.GetRow(_gvFichaTecnicaPCPRegra.GetSelectedRows()[0]);
                _gvFichaTecnicaPCPRegra.DeleteRow(_gvFichaTecnicaPCPRegra.GetSelectedRows()[0]);
                if (temp.ID != 0)
                {
                    FichaTecnicaPCPRegraController.Instancia.Salvar(temp, Acao.Excluir);
                }
                lAux = (IList<FichaTecnicaPCPRegra>)((NHibernate.Collection.PersistentBag)_gvFichaTecnicaPCPRegra.DataSource);
                gcFichaTecnicaPCPRegra.RefreshDataSource();
                gcFichaTecnicaPCPRegra.Refresh();           
            }            
        }

        #endregion

        #region Validadores

        public bool CamposValidos()
        {
            dxErrorProviderTab.ClearErrors();
            if (((string)txtCodigo.EditValue == "" || txtCodigo.EditValue == null))
            {
                dxErrorProviderTab.SetError(_txtCodigo, "O campo Código é obrigatório. Favor Preencher.");
            }
            if (deData.EditValue == null)
            {
                dxErrorProviderTab.SetError(deData, "O campo Data é obrigatório. Favor Preencher.");
            }
            if ((decimal)seRevisao.EditValue == 0 || seRevisao.EditValue == null)
            {
                dxErrorProviderTab.SetError(seRevisao, "O campo Código é obrigatório. Favor Preencher.");
            }
            return (!dxErrorProviderTab.HasErrors);
        }

        private void _txtCodigo_Leave(object sender, EventArgs e)
        {
            if ((string)txtCodigo.EditValue == "" || txtCodigo.EditValue == null)
            {
                dxErrorProviderTab.SetError(_txtCodigo, "O campo Código é obrigatório. Favor Preencher.");
            }
            else
            {
                dxErrorProviderTab.ClearErrors();
            }
        }

        private void _deData_Leave(object sender, EventArgs e)
        {
            if (deData.EditValue == null)
            {
                dxErrorProviderTab.SetError(deData, "O campo Data é obrigatório. Favor Preencher.");
            }
            else
            {
                dxErrorProviderTab.ClearErrors();
            }
        }

        private void _seRevisao_Leave(object sender, EventArgs e)
        {
            if ((decimal)seRevisao.EditValue == 0 || seRevisao.EditValue == null)
            {
                dxErrorProviderTab.SetError(seRevisao, "O campo Código é obrigatório. Favor Preencher.");
            }
            else
            {
                dxErrorProviderTab.ClearErrors();
            }
        }

        #endregion

        #endregion
    }

}
