using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TPIntroRazor.Pages
{
    public class IndexModel : PageModel
    {
        public string MessageAccueil { get; set; } = string.Empty;
        public List<string> Modules { get; set; } = new();

        public void OnGet()
        {
            MessageAccueil = "Bienvenue dans le TP d'initiation Razor Pages";
            Modules = new List<string>
            {
                "Création d'un projet Razor Pages",
                "Syntaxe Razor",
                "Formulaires et [BindProperty]"
            };
        }
    }
}