using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Negocio;
using cwkGestao.Modelo;
using Aplicacao.Util;
using cwkGestao.Modelo.Proxy;
using Cwork.Utilitarios;

namespace Aplicacao.Modulos.Comercial
{
    public partial class FormConsultaPreco : Form
    {
        private Panel xtraTabControl2;
        private DevExpress.XtraEditors.SimpleButton sbOK;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private Cwork.Utilitarios.Componentes.CwkBaseEditor txtPreco;
        private Cwork.Utilitarios.Componentes.DevTextEdit txtNomeProduto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Cwork.Utilitarios.Componentes.DevTextEdit lkpProduto;
        private Configuracao objConfiguracao; 
        private Produto objProduto;
        private Produto objProduto2;
        private TabelaPreco objTabelaPreco;
        private DataTable objListProds = new DataTable();


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPreco));
            this.xtraTabControl2 = new System.Windows.Forms.Panel();
            this.lkpProduto = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPreco = new Cwork.Utilitarios.Componentes.CwkBaseEditor();
            this.txtNomeProduto = new Cwork.Utilitarios.Componentes.DevTextEdit();
            this.sbOK = new DevExpress.XtraEditors.SimpleButton();
            this.gcTabelaPreco = new DevExpress.XtraGrid.GridControl();
            this.gvTabelaPreco = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Preco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.xtraTabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.BackColor = System.Drawing.Color.White;
            this.xtraTabControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xtraTabControl2.Controls.Add(this.lkpProduto);
            this.xtraTabControl2.Controls.Add(this.labelControl1);
            this.xtraTabControl2.Controls.Add(this.labelControl2);
            this.xtraTabControl2.Controls.Add(this.labelControl4);
            this.xtraTabControl2.Controls.Add(this.txtPreco);
            this.xtraTabControl2.Controls.Add(this.txtNomeProduto);
            this.xtraTabControl2.Controls.Add(this.sbOK);
            this.xtraTabControl2.Location = new System.Drawing.Point(12, 12);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.Size = new System.Drawing.Size(562, 245);
            this.xtraTabControl2.TabIndex = 0;
            // 
            // lkpProduto
            // 
            this.lkpProduto.CwkFuncaoValidacao = null;
            this.lkpProduto.CwkMascara = null;
            this.lkpProduto.CwkValidacao = null;
            this.lkpProduto.EnterMoveNextControl = true;
            this.lkpProduto.Location = new System.Drawing.Point(6, 32);
            this.lkpProduto.Name = "lkpProduto";
            this.lkpProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lkpProduto.Properties.Appearance.Options.UseFont = true;
            this.lkpProduto.SelecionarTextoOnEnter = false;
            this.lkpProduto.Size = new System.Drawing.Size(551, 30);
            this.lkpProduto.TabIndex = 1;
            this.lkpProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaPreco_KeyDown);
            this.lkpProduto.Leave += new System.EventHandler(this.lkpProduto_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseImageAlign = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Produto:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseImageAlign = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Descrição:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.labelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseImageAlign = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 18);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.CwkFuncaoValidacao = null;
            this.txtPreco.CwkMascara = Cwork.Utilitarios.Componentes.Mascaras.Mascara.MONETARIO;
            this.txtPreco.CwkValidacao = null;
            this.txtPreco.EnterMoveNextControl = true;
            this.txtPreco.Location = new System.Drawing.Point(6, 158);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(164)))), ((int)(((byte)(194)))));
            this.txtPreco.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.txtPreco.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Properties.Appearance.Options.UseBackColor = true;
            this.txtPreco.Properties.Appearance.Options.UseFont = true;
            this.txtPreco.Properties.Appearance.Options.UseForeColor = true;
            this.txtPreco.Properties.Appearance.Options.UseTextOptions = true;
            this.txtPreco.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtPreco.Properties.Mask.EditMask = "c2";
            this.txtPreco.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPreco.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPreco.SelecionarTextoOnEnter = false;
            this.txtPreco.Size = new System.Drawing.Size(551, 36);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TabStop = false;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.CwkFuncaoValidacao = null;
            this.txtNomeProduto.CwkMascara = null;
            this.txtNomeProduto.CwkValidacao = null;
            this.txtNomeProduto.Location = new System.Drawing.Point(6, 93);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtNomeProduto.Properties.Appearance.Options.UseFont = true;
            this.txtNomeProduto.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtNomeProduto.Properties.ReadOnly = true;
            this.txtNomeProduto.SelecionarTextoOnEnter = false;
            this.txtNomeProduto.Size = new System.Drawing.Size(551, 30);
            this.txtNomeProduto.TabIndex = 3;
            this.txtNomeProduto.TabStop = false;
            // 
            // sbOK
            // 
            this.sbOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbOK.ImageOptions.Image = global::Aplicacao.Properties.Resources.Selecionar_copy;
            this.sbOK.Location = new System.Drawing.Point(238, 217);
            this.sbOK.Name = "sbOK";
            this.sbOK.Size = new System.Drawing.Size(85, 23);
            this.sbOK.TabIndex = 8;
            this.sbOK.Text = "&OK";
            this.sbOK.Click += new System.EventHandler(this.sbOK_Click);
            this.sbOK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaPreco_KeyDown);
            // 
            // gcTabelaPreco
            // 
            this.gcTabelaPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.First.Hint = "Primeiro registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Last.Hint = "Último registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Next.Hint = "Próximo registro";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.NextPage.Hint = "Próxima página";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Prev.Hint = "Registro anterior";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.PrevPage.Hint = "Página anterior";
            this.gcTabelaPreco.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcTabelaPreco.EmbeddedNavigator.TextStringFormat = "Registro {0} de {1}";
            this.gcTabelaPreco.Location = new System.Drawing.Point(0, 263);
            this.gcTabelaPreco.MainView = this.gvTabelaPreco;
            this.gcTabelaPreco.Name = "gcTabelaPreco";
            this.gcTabelaPreco.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gcTabelaPreco.Size = new System.Drawing.Size(586, 211);
            this.gcTabelaPreco.TabIndex = 9;
            this.gcTabelaPreco.UseEmbeddedNavigator = true;
            this.gcTabelaPreco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTabelaPreco});
            this.gcTabelaPreco.Click += new System.EventHandler(this.gcTabelaPreco_Click);
            // 
            // gvTabelaPreco
            // 
            this.gvTabelaPreco.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.Empty.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPreco.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvTabelaPreco.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPreco.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvTabelaPreco.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPreco.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvTabelaPreco.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.OddRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvTabelaPreco.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Preview.Options.UseFont = true;
            this.gvTabelaPreco.Appearance.Preview.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(229)))), ((int)(((byte)(231)))));
            this.gvTabelaPreco.Appearance.Row.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.RowSeparator.BackColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.SelectedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(206)))), ((int)(((byte)(57)))));
            this.gvTabelaPreco.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvTabelaPreco.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.gvTabelaPreco.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvTabelaPreco.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvTabelaPreco.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvTabelaPreco.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nome,
            this.Preco,
            this.Codigo});
            this.gvTabelaPreco.GridControl = this.gcTabelaPreco;
            this.gvTabelaPreco.Name = "gvTabelaPreco";
            this.gvTabelaPreco.OptionsBehavior.Editable = false;
            this.gvTabelaPreco.OptionsBehavior.FocusLeaveOnTab = true;
            this.gvTabelaPreco.OptionsSelection.MultiSelect = true;
            this.gvTabelaPreco.OptionsSelection.UseIndicatorForSelection = false;
            this.gvTabelaPreco.OptionsView.EnableAppearanceEvenRow = true;
            this.gvTabelaPreco.OptionsView.EnableAppearanceOddRow = true;
            this.gvTabelaPreco.OptionsView.ShowGroupPanel = false;
            // 
            // Nome
            // 
            this.Nome.Caption = "Nome";
            this.Nome.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Nome.FieldName = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Visible = true;
            this.Nome.VisibleIndex = 0;
            this.Nome.Width = 274;
            // 
            // Preco
            // 
            this.Preco.Caption = "Preco";
            this.Preco.FieldName = "Preco";
            this.Preco.Name = "Preco";
            this.Preco.Visible = true;
            this.Preco.VisibleIndex = 1;
            this.Preco.Width = 80;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 2;
            this.Codigo.Width = 50;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // FormConsultaPreco
            // 
            this.ClientSize = new System.Drawing.Size(586, 474);
            this.Controls.Add(this.gcTabelaPreco);
            this.Controls.Add(this.xtraTabControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Preço";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormConsultaPreco_KeyDown);
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPreco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTabelaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTabelaPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        //Iniciar Tela:

        public FormConsultaPreco()
        {

            InitializeComponent();
            objListProds.Columns.Add("Nome", typeof(string));
            objListProds.Columns.Add("Preco", typeof(decimal));
            objListProds.Columns.Add("Codigo", typeof(string));
            IniciarConsulta();
        }
        private void IniciarConsulta()
        {
            objConfiguracao = ConfiguracaoController.Instancia.GetConfiguracao();
            objTabelaPreco = objConfiguracao.TabelaPrecoFrenteCaixa;
        }


        private void InicializarCampos()
        {

            txtPreco.EditValue = 0.00;

        }
        private void IncluirProdutoEAtualizarTela(Produto produto)
        {
            if (produto != null)
            {
                objProduto = produto;
                AtualizarDadosTela();
            }
            else
                SetFocusProduto();
        }
        private void AtualizarDadosTela()
        {
            txtNomeProduto.EditValue = objProduto.Nome ?? String.Empty;
            lkpProduto.EditValue = objProduto.Barra ?? String.Empty;
            objProduto = ProdutoController.Instancia.LoadObjectById(objProduto.ID);
            txtPreco.EditValue = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal);

        }
        private void SetFocusProduto()
        {
            objProduto = null;
            lkpProduto.EditValue = string.Empty;
            lkpProduto.Focus();
        }
        private void FormConsultaPreco_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    CarregarProdutos();
                    break;

                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void lkpProduto_Leave(object sender, EventArgs e)
        {

            try
            {
                if (!String.IsNullOrEmpty(lkpProduto.Text))
                {
                    //Tenta buscar o produto pelo código
                    objProduto = ProdutoController.Instancia.FindByCodigoBarraOuCodigo(lkpProduto.Text, true);
                    //Tenta buscar o produto pelo nome
                    objProduto2 = ProdutoController.Instancia.FindByDescricao(lkpProduto.Text);
                    //Lista de todos os produtos
                    IList<Produto> prod = new List<Produto>();
                    prod = ProdutoController.Instancia.GetAll();
                    if (objProduto2 == null && objProduto == null)
                    {
                        for (int i = 0; i < prod.AsEnumerable().Count(); i++)
                        {
                            if (prod[i].Nome.ToString().ToUpper().Contains(lkpProduto.Text.ToUpper()) && !prod[i].Inativo)
                            {
                                objProduto = ProdutoController.Instancia.LoadObjectById(prod[i].ID);
                                decimal preco = ProdutoController.Instancia.getPreco(objProduto, objTabelaPreco, TipoPrecoType.Normal);
                                DataRow dr = objListProds.NewRow();
                                dr["Nome"] = prod[i].Nome;
                                dr["Preco"] = preco;
                                dr["Codigo"] = prod[i].Codigo;
                                objListProds.Rows.Add(dr);
                            }
                        }
                        if(objListProds.Rows != null)
                        {
                            gcTabelaPreco.DataSource = objListProds;
                            return;
                        }
                    }
                    

                    if ((objProduto == null) || (objProduto == new Produto()))
                    {
                        if (objProduto2 != null && !objProduto2.Inativo)
                        {
                            IncluirProdutoEAtualizarTela(objProduto2);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Produto inexistente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lkpProduto.EditValue = null;
                            lkpProduto.Focus();

                            return;

                        }
                    }

                    if (objProduto.Inativo)
                    {
                        MessageBox.Show("Este produto está inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lkpProduto.EditValue = null;
                        lkpProduto.Focus();

                        return;
                    }

                    IncluirProdutoEAtualizarTela(objProduto);
                }
                else
                {
                    objProduto = null;
                    return;
                }
            }
            catch (ApplicationException)
            {

            }
        }
        private void CarregarProdutos()
        {
            IList<Produto> produtos = ProdutoController.Instancia.GetAll().OrderBy(prod => prod.NomeOrdenado).ToList();
            GridProdutoGen grid = new GridProdutoGen(produtos, null, true, false, typeof(FormProduto));
            grid.Selecionando = true;

            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                objProduto = ProdutoController.Instancia.LoadObjectById(grid.Selecionado.ID);
                IncluirProdutoEAtualizarTela(objProduto);
            }
        }

        private void sbOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DevExpress.XtraGrid.GridControl gcTabelaPreco;
        public DevExpress.XtraGrid.Views.Grid.GridView gvTabelaPreco;
        private DevExpress.XtraGrid.Columns.GridColumn Nome;
        private DevExpress.XtraGrid.Columns.GridColumn Preco;

        private void gcTabelaPreco_Click(object sender, EventArgs e)
        {

        }

        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}