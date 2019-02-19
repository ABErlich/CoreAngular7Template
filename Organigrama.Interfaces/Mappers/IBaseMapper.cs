using System;
using System.Collections.Generic;

namespace Organigrama.Interfaces.Mappers
{
    public interface IBaseMapper<DB, VM>
    {
        DB ViewModelToDomain(VM viewModel);
        VM DomainToViewModel(DB domain);
        List<VM> DomainToViewModel(List<DB> domain);
    }
}
