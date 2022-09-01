using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cwkGestao.Modelo;

namespace Aplicacao.OrcamentoServico.ValueObjects
{
    public class OSAcompanhamentoEditavel
    {
        private OSAcompanhamento osAcompanhamento;

        public OSAcompanhamentoEditavel(OSAcompanhamento osAcompanhamento)
        {
            this.osAcompanhamento = osAcompanhamento;
        }

        [InformacaoExibicao(0, "Data", 70)]
        public DateTime Data
        {
            get { return osAcompanhamento.DataHora.Date; }
            set
            {
                if (value.Year < 1950 || value.Year > 2200)
                {
                    throw new Exception("Data inválida.");
                }
                else
                {
                    DateTime novoDateTime = value;
                    novoDateTime = novoDateTime.AddHours(osAcompanhamento.DataHora.Hour);
                    novoDateTime = novoDateTime.AddMinutes(osAcompanhamento.DataHora.Minute);

                    osAcompanhamento.DataHora = novoDateTime;
                }
            }
        }

        [InformacaoExibicao(1, "Hora", 30)]
        public string Hora
        {
            get { return osAcompanhamento.DataHora.ToShortTimeString(); }
            set
            {
                string[] splitHora = value.Split(':');
                int horas = Convert.ToInt32(splitHora[0]);
                int minutos = Convert.ToInt32(splitHora[1]);

                osAcompanhamento.DataHora = osAcompanhamento.DataHora.Date;
                osAcompanhamento.DataHora = osAcompanhamento.DataHora.AddHours(horas);
                osAcompanhamento.DataHora = osAcompanhamento.DataHora.AddMinutes(minutos);
            }
        }

        [InformacaoExibicao(2, "Ocorrência", 400)]
        public string Ocorrencia
        {
            get { return osAcompanhamento.Ocorrencia; }
            set { osAcompanhamento.Ocorrencia = value; }
        }

        [InformacaoExibicao(3, "Usuário", 100)]
        public string Usuario
        {
            get { return osAcompanhamento.Usuario; }
            set { osAcompanhamento.Usuario = value; }
        }
    }
}
