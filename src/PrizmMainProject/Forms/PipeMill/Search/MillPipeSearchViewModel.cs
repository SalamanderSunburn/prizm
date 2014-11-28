﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizmMain.Forms.PipeMill.Search
{
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using Ninject;
    using PrizmMain.Commands;
    using System;
    using System.Windows.Forms;
    using Pipe = Domain.Entity.Mill.Pipe;

    using Data.DAL.Mill;
    using Domain.Entity.Mill;
    using PrizmMain.Common;
    using Data.DAL.Setup;
    using Domain.Entity.Setup;


    public class MillPipeSearchViewModel : ViewModelBase, IDisposable
    {

        readonly ICommand searchCommand;

        readonly IMillPipeSizeTypeRepository repoSizeType;
        readonly IPipeRepository repoPipe;

        private IList<Pipe> pipes;
        private IList<EnumWrapper<PipeMillStatus>> statusTypes;
        private IList<PipeMillSizeType> pipeTypes;
        private IList<PipeMillSizeType> checkedPipeTypes 
            = new List<PipeMillSizeType>();

        private string pipeNumber;

        private EnumWrapper<PipeMillStatus> pipeMillStatus;

        [Inject]
        public MillPipeSearchViewModel(
            IPipeRepository repoPipe,
            IMillPipeSizeTypeRepository repoSizeType)
        {
            this.repoPipe = repoPipe;
            this.repoSizeType = repoSizeType;

            searchCommand = ViewModelSource.Create<MillPipeSearchCommand>(
                () => new MillPipeSearchCommand(this, repoPipe));

            pipeTypes = repoSizeType.GetAll();
            LoadPipeMillStatuses();
        }

        public IList<Pipe> Pipes
        {
            get
            {
                return pipes;
            }
            set
            {
                if (value != pipes)
                {
                    pipes = value;
                    RaisePropertyChanged("Pipes");
                }
            }
        }

        public string PipeNumber
        {
            get
            {
                return pipeNumber;
            }
            set
            {
                if (value != pipeNumber)
                {
                    pipeNumber = value;
                    RaisePropertyChanged("PipeNumber");
                }
            }
        }

        public IList<PipeMillSizeType> PipeTypes
        {
            get { return pipeTypes; }
            set
            {
                if (value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }

        public IList<PipeMillSizeType> CheckedPipeTypes
        {
            get { return checkedPipeTypes; }
            set
            {
                if (value != checkedPipeTypes)
                {
                    checkedPipeTypes = value;
                    RaisePropertyChanged("CheckedPipeTypes");
                }
            }
        }

        public EnumWrapper<PipeMillStatus> PipeMillStatus
        {
            get
            {
                return pipeMillStatus;
            }
            set
            {
                if (value != pipeMillStatus)
                {
                    pipeMillStatus = value;
                    RaisePropertyChanged("PipeMillStatus");
                }
            }
        }

        public IList<EnumWrapper<PipeMillStatus>> StatusTypes
        {
            get { return statusTypes; }
            set
            {
                if (value != statusTypes)
                {
                    statusTypes = value;
                    RaisePropertyChanged("StatusTypes");
                }
            }
        }

        public ICommand SearchCommand
        {
            get { return searchCommand; }
        }

        public void Dispose()
        {
            repoSizeType.Dispose();
            repoPipe.Dispose();
        }

        private void LoadPipeMillStatuses()
        {
            StatusTypes = new List<EnumWrapper<PipeMillStatus>>();

            foreach (string statusTypeName in Enum.GetNames(typeof(PipeMillStatus)))
            {
                if (statusTypeName != Enum.GetName(typeof(PipeMillStatus), Domain.Entity.Mill.PipeMillStatus.Undefined))
                {
                    StatusTypes.Add(new EnumWrapper<PipeMillStatus>() { Name = statusTypeName });
                }
            }
        }

    }
}
