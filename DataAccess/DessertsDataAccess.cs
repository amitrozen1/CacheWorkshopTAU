
namespace DataAccess
{
    public class DessertsDataAccess
    {
        public async Task<List<Dessert>> GetDesserts() 
        {
            List<Dessert> desserts = [];

            desserts.Add(new Dessert { DessertName = "Chocolate Chip Cookies", NumberOfIngredients = 9 });
            desserts.Add(new Dessert { DessertName = "Cheesecake", NumberOfIngredients = 11 });
            desserts.Add(new Dessert { DessertName = "Brownies", NumberOfIngredients = 8 });
            desserts.Add(new Dessert { DessertName = "Apple Pie", NumberOfIngredients = 11 });
            desserts.Add(new Dessert { DessertName = "Tiramisu", NumberOfIngredients = 7 });

            desserts.Add(new Dessert { DessertName = "Pumpkin Pie", NumberOfIngredients = 9 });
            desserts.Add(new Dessert { DessertName = "Chocolate Mousse", NumberOfIngredients = 6 });
            desserts.Add(new Dessert { DessertName = "Strawberry Shortcake", NumberOfIngredients = 8 });
            desserts.Add(new Dessert { DessertName = "Creme Brulee", NumberOfIngredients = 4 });
            desserts.Add(new Dessert { DessertName = "Molten Lava Cake", NumberOfIngredients = 7 });

            await Task.Delay(3000);

            return desserts;
        }
    }
}
