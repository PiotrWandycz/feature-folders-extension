using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using _PROJECT_NAME_.Infrastructure;

namespace _NAMESPACE_
{
    public interface IPageFacade : IPageFacadeMarker
    {
        Task<ViewModel> OnGetAsync(Query query);
        Task<IActionResult> OnPostAsync(Command command);
    }
}