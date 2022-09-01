using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cwkGestao.Modelo;

namespace Aplicacao.Util
{
    public class UtilitarioPacoteTransporte
    {
        public static bool VerificaDimensoes(CorreiosPrecoPrazo cpp)
        {
            int comprimentoMinimo = cpp.FormatoPacoteTransporte.ComprimentoMinimo;
            int comprimentoMaximo = cpp.FormatoPacoteTransporte.ComprimentoMaximo;
            int larguraMinima = cpp.FormatoPacoteTransporte.LarguraMinima;
            int larguraMaxima = cpp.FormatoPacoteTransporte.LarguraMaxima;
            int alturaMinima = cpp.FormatoPacoteTransporte.AlturaMinima;
            int alturaMaximo = cpp.FormatoPacoteTransporte.AlturaMaxima;
            int diametroMinimo = cpp.FormatoPacoteTransporte.DiametroMinimo;
            int diametroMaximo = cpp.FormatoPacoteTransporte.DiametroMaximo;
            int somaDimensoes = cpp.FormatoPacoteTransporte.SomaMaximaDimensoes;

            bool sucesso = true;

            if ((comprimentoMaximo < cpp.NVlComprimento) ||
                (comprimentoMinimo > cpp.NVlComprimento))
            {
                MessageBox.Show("O comprimento da encomenda na linha não pode ser maior do que " + comprimentoMaximo + " e menor do que " + comprimentoMinimo);
                sucesso = false;
            }
            else if ((larguraMaxima < cpp.NVlLargura) ||
                     (larguraMinima > cpp.NVlLargura))
            {
                MessageBox.Show("A largura da encomenda na linha não pode ser maior do que " + larguraMaxima + " e menor do que " + larguraMinima);
                sucesso = false;
            }
            else if ((alturaMaximo < cpp.NVlAltura) ||
                     (alturaMinima > cpp.NVlAltura))
            {
                MessageBox.Show("A altura da encomenda na linha não pode ser maior do que " + alturaMaximo + " e menor do que " + alturaMinima);
                sucesso = false;
            }
            else if ((diametroMaximo < cpp.NVlDiametro) ||
                     (diametroMinimo > cpp.NVlDiametro))
            {
                MessageBox.Show("O diâmetro da encomenda na linha não pode ser maior do que " + diametroMaximo + " e menor do que " + diametroMinimo);
                sucesso = false;
            }
            else if (cpp.FormatoPacoteTransporte.Descricao.Contains("Rolo/Prisma"))
            {
                if (somaDimensoes < (cpp.NVlComprimento + (cpp.NVlDiametro * 2)))
                {
                    MessageBox.Show("A soma máxima das dimensões da encomenda na linha não pode ser maior do que " + somaDimensoes);
                    sucesso = false;
                }
            }
            else if (somaDimensoes < (cpp.NVlComprimento + cpp.NVlLargura + cpp.NVlAltura))
            {
                MessageBox.Show("A soma máxima das dimensões da encomenda na linha não pode ser maior do que " + somaDimensoes);
                sucesso = false;
            }
               
            return sucesso;
        }

        public static string VerificaDimensoesString(CorreiosPrecoPrazo cpp)
        {
            int comprimentoMinimo = cpp.FormatoPacoteTransporte.ComprimentoMinimo;
            int comprimentoMaximo = cpp.FormatoPacoteTransporte.ComprimentoMaximo;
            int larguraMinima = cpp.FormatoPacoteTransporte.LarguraMinima;
            int larguraMaxima = cpp.FormatoPacoteTransporte.LarguraMaxima;
            int alturaMinima = cpp.FormatoPacoteTransporte.AlturaMinima;
            int alturaMaximo = cpp.FormatoPacoteTransporte.AlturaMaxima;
            int diametroMinimo = cpp.FormatoPacoteTransporte.DiametroMinimo;
            int diametroMaximo = cpp.FormatoPacoteTransporte.DiametroMaximo;
            int somaDimensoes = cpp.FormatoPacoteTransporte.SomaMaximaDimensoes;

            StringBuilder sb = new StringBuilder();

            if ((comprimentoMaximo < cpp.NVlComprimento) ||
                (comprimentoMinimo > cpp.NVlComprimento))
            {
                sb.AppendLine("O comprimento da encomenda na linha não pode ser maior do que " + comprimentoMaximo + " e menor do que " + comprimentoMinimo);
            }
            if ((larguraMaxima < cpp.NVlLargura) ||
                     (larguraMinima > cpp.NVlLargura))
            {
                sb.AppendLine("A largura da encomenda na linha não pode ser maior do que " + larguraMaxima + " e menor do que " + larguraMinima);
            }
            if ((alturaMaximo < cpp.NVlAltura) ||
                     (alturaMinima > cpp.NVlAltura))
            {
                sb.AppendLine("A altura da encomenda na linha não pode ser maior do que " + alturaMaximo + " e menor do que " + alturaMinima);
            }
            if ((diametroMaximo < cpp.NVlDiametro) ||
                     (diametroMinimo > cpp.NVlDiametro))
            {
                sb.AppendLine("O diâmetro da encomenda na linha não pode ser maior do que " + diametroMaximo + " e menor do que " + diametroMinimo);
            }
            if (cpp.FormatoPacoteTransporte.Descricao.Contains("Rolo/Prisma"))
            {
                if (somaDimensoes < (cpp.NVlComprimento + (cpp.NVlDiametro * 2)))
                {
                    sb.AppendLine("A soma máxima das dimensões da encomenda na linha não pode ser maior do que " + somaDimensoes);
                }
            }
            if (somaDimensoes < (cpp.NVlComprimento + cpp.NVlLargura + cpp.NVlAltura))
            {
                sb.AppendLine("A soma máxima das dimensões da encomenda na linha não pode ser maior do que " + somaDimensoes);
            }
            return sb.ToString();
        }
    }
}
