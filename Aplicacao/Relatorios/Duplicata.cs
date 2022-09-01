using System;
using cwkGestao.Modelo;
using cwkGestao.Negocio;
using Relatorio;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace Aplicacao.Relatorios
{
    public class Duplicata
    {
        private Relatorio.dsDuplicata.DuplicataDataTable dt;
        private ModeloDuplicata ModeloDuplicata;

        public Duplicata(ModeloDuplicata _ModeloDuplicata)
        {
            this.ModeloDuplicata = _ModeloDuplicata;
        }

        public bool DeNota(int idNota)
        {
            Relatorio.dsDuplicata.DuplicataRow primeiroRow = null;

            var nota = NotaController.Instancia.LoadObjectById(idNota);
            
            var documentos = DocumentoController.Instancia.GetDocumentosPorNota(idNota);
            var endereco = GetEnderecoPessoa(nota.Pessoa);
            var enderecocob = GetEnderecoPessoaCobranca(nota.Pessoa);

            dt = new Relatorio.dsDuplicata.DuplicataDataTable();

            if (documentos.Count > 0)
            {
                for (int i = 0; i < documentos.Count; i++)
                {
                    var row = GetRowDocumento(documentos[i], endereco, enderecocob, nota.Filial);
                    dt.Rows.Add(row);
                    if (i == 0)
                        primeiroRow = row;
                }
                ExibirRelatorio(primeiroRow, nota.Filial.CaminhoLogoEmpresa);
                return true;
            }

            return false;
        }

        public void DeDocumento(int idDocumento)
        {
            var documento = DocumentoController.Instancia.LoadObjectById(idDocumento);
            var endereco = GetEnderecoPessoa(documento.Pessoa);
            var enderecocob = GetEnderecoPessoaCobranca(documento.Pessoa);
            dt = new Relatorio.dsDuplicata.DuplicataDataTable();

            var row = GetRowDocumento(documento, endereco, enderecocob, documento.Filial);
            dt.Rows.Add(row);

            ExibirRelatorio(row, documento.Filial.CaminhoLogoEmpresa);
        }

        private PessoaEndereco GetEnderecoPessoa(Pessoa pessoa)
        {
            return pessoa.EnderecoPrincipal();
        }

        private PessoaEndereco GetEnderecoPessoaCobranca(Pessoa pessoa)
        {
            var enderecoCobranca = pessoa.PessoaEnderecos.Where(e => e.BCobranca);
            if (enderecoCobranca.Count() > 0)
                return enderecoCobranca.First();
            else
                return pessoa.EnderecoPrincipal();
        }

        private Relatorio.dsDuplicata.DuplicataRow GetRowDocumento(Documento documento, PessoaEndereco endereco, PessoaEndereco enderecocob, Filial filial)
        {
            Relatorio.dsDuplicata.DuplicataRow row = (dsDuplicata.DuplicataRow)dt.NewRow();

            row.DataEmissao = documento.Dt.ToShortDateString();
            row.ValorFatura = String.Format("{0:c}", documento.ValorTotal);
            row.ValorDuplicata = String.Format("{0:c}", documento.Valor);
            row.NumFatura = documento.NumDocumento;

            row.Local = DocumentoController.Instancia.LoadObjectById(documento.ID).Filial.Cidade.Nome;
            row.CNPJEmpresa = "CNPJ: " + filial.CNPJ;
            row.InscricaoEstadual = "INSCR. EST: " + filial.Inscricao;

            if (ModeloDuplicata == ModeloDuplicata.Modelo0)
            {
                row.NumOrdemDuplicata = (documento.NumDocumento == null ? "" : documento.NumDocumento.ToString()) + "/" + documento.DtVencimento.Year.ToString().Substring(2) + "-" + documento.Parcela.ToString();
            }
            else
            {
                row.NumOrdemDuplicata = (documento.NumDocumento == null ? "" : documento.NumDocumento.ToString()) + "/" + documento.Parcela.ToString();
            }

            row.Vencimento = documento.DtVencimento == documento.Dt ? "CONTRA APRESENTAÇÃO" : documento.DtVencimento.ToShortDateString();

            row.NomeSacado = documento.Pessoa.Nome;
            row.EnderecoSacado = endereco.Endereco + ", " + endereco.Numero + (!(String.IsNullOrEmpty(endereco.Complemento)) ? " - " + endereco.Complemento : "") + (endereco.Bairro.Length > 0 ? " - " + endereco.Bairro : "") + " - CEP: " + endereco.CEP;
            row.CidadeSacado = endereco.Cidade.Nome;
            row.UFSacado = endereco.Cidade.UF.Sigla;

            row.PracaSacado = enderecocob.Endereco + ", " + enderecocob.Numero + (!(String.IsNullOrEmpty(enderecocob.Complemento)) ? (" - " + enderecocob.Complemento) : "") + (enderecocob.Bairro.Length > 0 ? " - " + enderecocob.Bairro : "") + (enderecocob.Cidade.Nome.Length > 0 ? (" - " + enderecocob.Cidade.Nome) : "") + " - CEP: " + enderecocob.CEP;
            row.UFPracaPagtoSacado = enderecocob.Cidade.UF.Nome;
            row.InscrEstSacado = "";

            row.InscrSacado = documento.Pessoa.Inscricao;
            row.CNPJSacado = documento.Pessoa.CNPJ_CPF;

            row.NomeEmpresa = filial.Nome;
            row.EnderecoEmpresa = filial.Endereco;
            row.NumEmpresa = filial.Numero;
            row.BairroEmpresa = filial.Bairro;
            row.CidadeEmpresa = filial.Cidade.Nome;
            row.UFEmpresa = filial.Cidade.UF.Nome;
            row.FoneEmpresa = (filial.Telefone == null ? "" : "FONE: " + filial.Telefone) + (filial.Fax == null ? "" : " - FAX: " + filial.Fax);
            row.FaxEmpresa = filial.Fax;
            row.CEPEmpresa = filial.CEP;
            row.DtAtual = DateTime.Now.ToShortDateString();
            row.ValorPorExtenso = ClsExtenso.Extenso_Valor(documento.Valor);

            return row;
        }

        private void ExibirRelatorio(dsDuplicata.DuplicataRow row, string caminho)
        {

            Relatorio.Relatorios.rptDuplicataDev rel = new Relatorio.Relatorios.rptDuplicataDev(row.Vencimento == "CONTRA APRESENTAÇÃO", caminho);
            rel.DataSource = dt;
            rel.ShowPreview();
        }
    }
}
