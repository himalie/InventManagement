using AutoMapper;
using InventManagement.Client.Web.ViewModels.InventoryPart;
using InventManagement.Domain.Models;

namespace InventManagement.Client.Web.Mapping
{
    public class InventoryPartMappingProfile : Profile
    {
        protected override void Configure()
        {
            //base.Configure();
           // base.Configure();

            CreateMap<InventoryPart, InventoryPartViewModel>();
            // We don't save cars - let's not map viewmodel to domain model then.
        }
    }
}