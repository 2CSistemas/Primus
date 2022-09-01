using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicacao.Base;
using cwkGestao.Modelo;
using cwkGestao.Negocio.Factory;
using Aplicacao.Interfaces;
using DevExpress.XtraEditors;

namespace Aplicacao.Util
{
    public static class LookupUtil
    {
        public delegate GridGenerica<T> ConstrutorGrid<T>(IList<T> lista, IFormManut<T> form, T selecionado) where T : cwkGestao.Modelo.ModeloBase, new();

        public static void GridLookup<T>(Cwork.Utilitarios.Componentes.Lookup lookup, Type formManutType, params object[] parametros) where T : cwkGestao.Modelo.ModeloBase, new()
        {
            object restricoes;
            try
            {
                restricoes = lookup.GetCriterion();
            }
            catch (NullReferenceException)
            {
                restricoes = null;
            }
            T selecionado = null;
            if (lookup.ID > 0)
                selecionado = ControllerFactory<T>.Produce().LoadObjectById(lookup.ID);
            GridGenerica<T> grid = new GridGenerica<T>(null, selecionado, () => ControllerFactory<T>.Produce().GetByExample(restricoes)
                                                     , false, null, null, null, formManutType, parametros);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lookup.HLocalizar(grid.Selecionado.ID);
                lookup.BeginInvoke(((Action)(() => { lookup.EditValue = lookup.Selecionado; })));
            }
            lookup.Focus();
        }

        public static void GridLookup<T>(Cwork.Utilitarios.Componentes.Lookup lookup, IFormManut<T> formManut) where T : cwkGestao.Modelo.ModeloBase, new()
        {
            object restricoes;
            try
            {
                restricoes = lookup.GetCriterion();
            }
            catch (NullReferenceException)
            {
                restricoes = null;
            }
            T selecionado = null;
            if (lookup.ID > 0)
                selecionado = ControllerFactory<T>.Produce().LoadObjectById(lookup.ID);
            GridGenerica<T> grid = new GridGenerica<T>(ControllerFactory<T>.Produce().GetByExample(restricoes)
                                                     , formManut
                                                     , selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lookup.HLocalizar(grid.Selecionado.ID);
                lookup.BeginInvoke(((Action)(() => { lookup.EditValue = lookup.Selecionado; })));
            }
            lookup.Focus();
        }

        //public static void GridLookup<T>(Cwork.Utilitarios.Componentes.Lookup lookup, IFormManut<T> formManut, ConstrutorGrid<T> construtorGrid) where T : cwkGestao.Modelo.ModeloBase, new()
        //{
        //    object restricoes;
        //    try
        //    {
        //        restricoes = lookup.GetCriterion();
        //    }
        //    catch (NullReferenceException)
        //    {
        //        restricoes = null;
        //    }
        //    T selecionado = null;
        //    if (lookup.ID > 0)
        //        selecionado = ControllerFactory<T>.Produce().LoadObjectById(lookup.ID);
        //    GridGenerica<T> grid = construtorGrid(ControllerFactory<T>.Produce().GetByExample(restricoes)
        //                                             , formManut
        //                                             , selecionado);
        //    grid.Selecionando = true;
        //    if (cwkControleUsuario.Facade.ControleAcesso(grid))
        //        grid.ShowDialog();

        //    if (grid.Selecionado != null)
        //    {
        //        lookup.Localizar(grid.Selecionado.ID);
        //    }
        //    lookup.Focus();
        //}

        public static void GridLookupPessoa(Cwork.Utilitarios.Componentes.Lookup lookup, IList<Pessoa> lista, string titulo, Type formManut, params object[] parametros)
        {
            Pessoa selecionado = null;

            if (lookup.ID > 0)
                selecionado = ControllerFactory<Pessoa>.Produce().LoadObjectById(lookup.ID);
            GridGenerica<Pessoa> grid = new GridCliente(lista
                                                     , selecionado
                                                     , titulo
                                                     , false
                                                     , formManut
                                                     , parametros);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lookup.Localizar(grid.Selecionado.ID);
            }
            lookup.Focus();
        }

        public static void GridComboLookup<T>(LookUpEdit lookup, IFormManut<T> formManut) where T : cwkGestao.Modelo.ModeloBase, new()
        {
            T selecionado = ControllerFactory<T>.Produce().LoadObjectById((int)lookup.EditValue);
            GridGenerica<T> grid = new GridGenerica<T>(ControllerFactory<T>.Produce().GetAll()
                                                     , formManut
                                                     , selecionado, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lookup.EditValue = grid.Selecionado.ID;
            }
            lookup.Focus();
        }

        public static void GridComboLookupPessoa(LookUpEdit lookup, IFormManut<Pessoa> formManut, IList<Pessoa> lista, string titulo)
        {
            Pessoa selecionado = ControllerFactory<Pessoa>.Produce().LoadObjectById((int)lookup.EditValue);
            GridGenerica<Pessoa> grid = new GridCliente(lista
                                                     , formManut
                                                     , selecionado
                                                     , titulo, false);
            grid.Selecionando = true;
            if (cwkControleUsuario.Facade.ControleAcesso(grid))
                grid.ShowDialog();

            if (grid.Selecionado != null)
            {
                lookup.EditValue = grid.Selecionado.ID;
            }
            lookup.Focus();
        }

    }
}
