using System;
using cwkGestao.Modelo;
using cwkGestao.Modelo.Util;

namespace Aplicacao.Util
{
    public class ModeloFiltroUtil
    {
        #region Propriedades

        private readonly ModeloFiltro _modeloFiltro;

        #endregion

        #region Construtores

        public ModeloFiltroUtil(ModeloFiltro modelo)
        {
            _modeloFiltro = modelo;
        }

        #endregion

        #region Métodos Públicos

        public DateTime ObterDataInicial()
        {
            var data = DateTime.Now;
            switch (_modeloFiltro)
            {
                case ModeloFiltro.Todos:
                    return new DateTime(2000, 1, 1);
                case ModeloFiltro.DiaAtual:
                    return data;
                case ModeloFiltro.MesAtual:
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.AnoAtual:
                    return new DateTime(data.Year, 1, 1);
                case ModeloFiltro.UmMesAntesDepois:
                    data = data.AddMonths(-1);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.TresMesesAntesDepois:
                    data = data.AddMonths(-3);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.SeisMesesAntesDepois:
                    data = data.AddMonths(-6);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.DozeMesesAntesDepois:
                    data = data.AddYears(-1);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.DoisAnosAnterior:
                    data = data.AddYears(-2);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.TresAnosAnterior:
                    data = data.AddYears(-3);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.QuatroAnosAnterior:
                    data = data.AddYears(-4);
                    return new DateTime(data.Year, data.Month, 1);
                case ModeloFiltro.CincoAnosAnterior:
                    data = data.AddYears(-5);
                    return new DateTime(data.Year, data.Month, 1);
                default:
                    return data;
            }
        }

        public DateTime ObterDataFinal()
        {
            var data = DateTime.Now;
            switch (_modeloFiltro)
            {
                case ModeloFiltro.Todos:
                    return data.AddMonths(6);
                case ModeloFiltro.DiaAtual:
                    return data;
                case ModeloFiltro.MesAtual:
                    return new DateTime(data.Year, data.Month, data.DaysInMonth());
                case ModeloFiltro.AnoAtual:
                    return new DateTime(data.Year, 12, 31);
                case ModeloFiltro.UmMesAntesDepois:
                    data = data.AddMonths(1);
                    return new DateTime(data.Year, data.Month, data.DaysInMonth());
                case ModeloFiltro.TresMesesAntesDepois:
                    data = data.AddMonths(3);
                    return new DateTime(data.Year, data.Month, data.DaysInMonth());
                case ModeloFiltro.SeisMesesAntesDepois:
                    data = data.AddMonths(6);
                    return new DateTime(data.Year, data.Month, data.DaysInMonth());
                case ModeloFiltro.DozeMesesAntesDepois:
                    data = data.AddYears(1);
                    return new DateTime(data.Year, data.Month, data.DaysInMonth());
                case ModeloFiltro.DoisAnosAnterior:
                case ModeloFiltro.TresAnosAnterior:
                case ModeloFiltro.QuatroAnosAnterior:
                case ModeloFiltro.CincoAnosAnterior:
                default:
                    return data;
            }

            #endregion
        }
    }
}