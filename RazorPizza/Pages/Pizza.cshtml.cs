using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB=new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita",PizzaName="Margerita",BasicPrice=2,Tomatosauce=true,Cheese=true,FinalPrice=4},
            new PizzasModel(){ImageTitle="Bolognese",PizzaName="Bolognese",BasicPrice=2,Tomatosauce=true,Cheese=true,Beef=true,FinalPrice=5},
            new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawaiian",BasicPrice=2,Tomatosauce=true,Ham=true,Pineapple=true,FinalPrice=15},
            new PizzasModel(){ImageTitle="Carbonara",PizzaName="Carbonara",BasicPrice=2,Tomatosauce=true,Cheese=true,Ham=true,Mashroom=true,FinalPrice=6},
            new PizzasModel(){ImageTitle="MeatFeast",PizzaName="MeatFeast",BasicPrice=2,Tomatosauce=true,Cheese=true,Beef=true,Ham=true,FinalPrice=6},
            new PizzasModel(){ImageTitle="Mushroom",PizzaName="Mushroom",BasicPrice=2,Tomatosauce=true,Cheese=true,Mashroom=true,FinalPrice=5},
            new PizzasModel(){ImageTitle="Pepperoni",PizzaName="Pepperoni",BasicPrice=2,Tomatosauce=true,Cheese=true,Peperoni=true,FinalPrice=5},
            new PizzasModel(){ImageTitle="Seafood",PizzaName="Seafood",BasicPrice=2,Tomatosauce=true,Cheese=true,Tuna=true,FinalPrice=5},
            new PizzasModel(){ImageTitle="Vegetarian",PizzaName="Vegetarian",BasicPrice=2,Tomatosauce=true,Cheese=true,Mashroom=true,Pineapple=true,FinalPrice=12},

        };
        public void OnGet()
        {
        }
    }
}
