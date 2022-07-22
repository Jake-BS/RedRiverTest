using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RedRiverTest.Models;

namespace RedRiverTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private HotDrinksMachine drinksMachine { get; set; }

        [BindProperty]
        public string outputText { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            drinksMachine = new HotDrinksMachine();
            outputText = "";
        }

        public void OnGet()
        {

        }

        public void OnPostTea()
        {
            var stringList = drinksMachine.LemonTeaActions();
            Steps(stringList);
        }

        public void OnPostCoffee()
        {
            var stringList = drinksMachine.CoffeeActions();
            Steps(stringList);
        }

        public void OnPostChocolate()
        {
            var stringList = drinksMachine.ChocolateActions();
            Steps(stringList);
        }

        public void Steps(List<string> stringList)
        {
            foreach (var step in stringList)
            {
                if (stringList[stringList.Count-1] == step) outputText += step + ".";
                else outputText += step + ", ";
            }
        }
    }
}