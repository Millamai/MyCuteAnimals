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
        private readonly IAnimalRepository _repo;
       
        public IndexModel(IAnimalRepository repo)
        {
            _repo = repo;
            MyAnimals = repo.GetAll();
        }

        public void OnGet()
        {

        }

        //Handler til at håndtere sletning
        public IActionResult OnGetDelete(int id)
        {
            _repo.Delete(id);
            return Redirect("Index");
        }
    }
}
