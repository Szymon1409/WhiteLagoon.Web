using Microsoft.AspNetCore.Mvc.Rendering;  
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using WhiteLagoon.Domain.Entities;
namespace WhiteLagoon.Web.ViewModels
{
    public class VillaNumberVM
    {
        public VillaNumber? VillaNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? VillaList { get; set; }
    }
}
