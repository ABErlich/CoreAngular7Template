using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Services;

namespace Organigrama.Mappers
{
    public abstract class BaseMapper<DB,VM>
    {
        
        protected IBaseService<DB> baseService;

        public VM Create(VM viewModel)
        {
            DB user = ViewModelToDomain(viewModel);
            return DomainToViewModel(baseService.Create(user));
        }

        public abstract DB ViewModelToDomain(VM viewModel);
        public abstract VM DomainToViewModel(DB domain);
        public abstract List<VM> DomainToViewModel(List<DB> domain);

    }
}
