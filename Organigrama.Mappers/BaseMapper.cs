using System;
using System.Collections.Generic;
using Organigrama.Interfaces.Mappers;
using Organigrama.Interfaces.Services;

namespace Organigrama.Mappers
{
    public abstract class BaseMapper<DB,VM>: IBaseMapper<DB,VM>
    {
        
        protected IBaseService<DB> baseService;

        public abstract DB ViewModelToDomain(VM viewModel);
        public abstract VM DomainToViewModel(DB domain);

        public List<VM> DomainToViewModel(List<DB> domain)
        {
            List<VM> model = new List<VM>();

            foreach (DB user in domain)
            {
                model.Add(DomainToViewModel(user));
            }

            return model;
        }
    }
}
