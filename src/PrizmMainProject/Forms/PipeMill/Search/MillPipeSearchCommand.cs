﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PrizmMain.Commands;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Data.DAL.Mill;
using NHibernate.Criterion;

namespace PrizmMain.Forms.PipeMill.Search
{
    public class MillPipeSearchCommand : ICommand
    {
        readonly IPipeRepository repo;
        readonly MillPipeSearchViewModel viewModel;

        public MillPipeSearchCommand(MillPipeSearchViewModel viewModel, IPipeRepository repo)
        {
            this.viewModel = viewModel;
            this.repo = repo;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            var criteria = NHibernate.Criterion.DetachedCriteria
                .For<Domain.Entity.Mill.Pipe>()
                .Add(Restrictions.Like("Number", viewModel.PipeNumber, MatchMode.Anywhere))
                .Add(Restrictions.Like("Status", viewModel.PipeMillStatus, MatchMode.Anywhere));
   
            viewModel.Pipes = repo.GetByCriteria(criteria);
            
        }

        public bool CanExecute()
        {
            return true;
        }

    }
}