using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCuteAnimals.Models;
using System.Diagnostics;

namespace MyCuteAnimals.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Animal> MyAnimals { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            MyAnimals = new AnimalRepository().Animals;
        }

        public void OnGet()
        {

        }

    //Handler til at håndtere sletning
        public IActionResult OnGetDelete(int id)
        {
            new AnimalRepository().Delete(id);
            return Redirect("Index");
        }
    }
}
