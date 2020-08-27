using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.Security;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Tenants
{
    public class CreateTenantViewModel
    {
        public IReadOnlyList<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public CreateTenantViewModel(IReadOnlyList<SubscribableEditionComboboxItemDto> editionItems)
        {
            EditionItems = editionItems;
        }
    }
}