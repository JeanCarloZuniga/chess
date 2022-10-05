using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace chess.Views.Shared.Components.Board
{
    public class BoardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View("Board"));
        }
    }
}
