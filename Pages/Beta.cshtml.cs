using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.FeatureManagement.Mvc;

namespace TestFeatureFlags.Pages
{
    [FeatureGate("Beta")]
    public class BetaModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}  