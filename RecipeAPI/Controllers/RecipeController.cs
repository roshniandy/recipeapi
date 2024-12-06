using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAPI.Models;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        List<Recipe> recipes;
        public RecipeController()
        {
            recipes = new List<Recipe>() { { new Recipe { Id = 1, Title = "Sugar Cookies",
                Instructions = "In a large bowl, cream together butter and sugar until smooth. Beat in eggs and vanilla. Stir in the flour, baking powder, and salt. Cover, and chill dough for at least one hour (or overnight).\nPreheat oven to 400 degrees F (200 degrees C). Roll out dough on floured surface 1/4 to 1/2 inch thick. Cut into shapes with any cookie cutter. Place cookies 1 inch apart on ungreased cookie sheets.\nBake 6 to 8 minutes in preheated oven. Cool completely.\n",
                Ingredients = "1 1/2 cups butter, softened, 2 cups white sugar, 4 eggs, 1 teaspoon vanilla extract, 5 cups all-purpose flour, 2 teaspoons baking powder, 1 teaspoon salt"} },
            { new Recipe { Id = 2, Title = "Chewy Chocolate Chip Cookie",
                Instructions = "Preheat the oven to 325 degrees F (165 degrees C). Grease cookie sheets or line with parchment paper.\nSift together the flour, baking soda and salt; set aside.\nIn a medium bowl, cream together the melted butter, brown sugar and white sugar until well blended. Beat in the vanilla, egg, and egg yolk until light and creamy. Mix in the sifted ingredients until just blended. Stir in the chocolate chips by hand using a wooden spoon. Drop cookie dough 1/4 cup at a time onto the prepared cookie sheets. Cookies should be about 3 inches apart.\nBake for 15 to 17 minutes in the preheated oven, or until the edges are lightly toasted. Cool on baking sheets for a few minutes before transferring to wire racks to cool completely.\n",
                Ingredients = "2 cups all-purpose flour, 1/2 teaspoon baking soda, 1/2 teaspoon salt, 3/4 cup unsalted butter, melted, 1 cup packed brown sugar, 1/2 cup white sugar, 1 tablespoon vanilla extract, 1 egg, 1 egg yolk, 2 cups semisweet chocolate chips " } },
                { new Recipe { Id = 3, Title = "Cauliflower Potatoes",
                Instructions = "Preheat oven to 375 degrees F (190 degrees C).\nPlace a steamer insert into a saucepan and fill with water to just below the bottom of the steamer. Bring water to a boil. Add cauliflower, cover, and steam until tender, about 20 minutes. Transfer cauliflower to a large bowl. Add mashed potato flakes, milk, and margarine; mash with a potato masher or fork until cauliflower mixture is fluffy. Season with salt and black pepper. Pour mixture into a baking dish and sprinkle with Cheddar cheese.\nBake in preheated oven until cheese is melted, about 10 minutes.\n",
                Ingredients = "1 pound cauliflower florets, 1/4 cup mashed potato flakes, 1/4 cup low-fat milk, 2 tablespoons margarine, salt and ground black pepper to taste, 1/4 cup shredded reduced-fat Cheddar cheese " } },
                   { new Recipe { Id = 4, Title = "Ham and Potato Soup",
                Instructions = "Combine the potatoes, celery, onion, ham and water in a stockpot. Bring to a boil, then cook over medium heat until potatoes are tender, about 10 to 15 minutes. Stir in the chicken bouillon, salt and pepper.\nIn a separate saucepan, melt butter over medium-low heat. Whisk in flour with a fork, and cook, stirring constantly until thick, about 1 minute. Slowly stir in milk as not to allow lumps to form until all of the milk has been added. Continue stirring over medium-low heat until thick, 4 to 5 minutes.\nStir the milk mixture into the stockpot, and cook soup until heated through. Serve immediately.\n",
                Ingredients = "3 1/2 cups peeled and diced potatoes, 1/3 cup diced celery, 1/3 cup finely chopped onion, 3/4 cup diced cooked ham, 3 1/4 cups water, 2 tablespoons chicken bouillon granules, 1/2 teaspoon salt, or to taste, 1 teaspoon ground white or black pepper, or to taste, 5 tablespoons butter, 5 tablespoons all-purpose flour, 2 cups milk"}},
             { new Recipe { Id = 5, Title = "Pancakes",
                Instructions = "In a large bowl, sift together the flour, baking powder, salt and sugar. Make a well in the center and pour in the milk, egg and melted butter; mix until smooth.\nHeat a lightly oiled griddle or frying pan over medium high heat. Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake. Brown on both sides and serve hot.\n",
                Ingredients = "1 1/2 cups all-purpose flour, 3 1/2 teaspoons baking powder, 1 teaspoon salt, 1 tablespoon white sugar, 1 1/4 cups milk, 1 egg, 3 tablespoons butter, melted"}},
            new Recipe { Id = 6, Title = "Cream Brownies",
                Instructions = "Preheat oven to 350 degrees F (175 degrees C).\nButter the bottom of a 10 1/2x15 1/2-inch jelly roll pan.\nPlace fudge brownie mix into a large bowl; beat in 1 cup of Irish cream liqueur, vegetable oil, and eggs until the mixture forms a smooth batter.\nSpread the batter into the prepared jelly roll pan.\nBake in the preheated oven until the brownies are set and a toothpick inserted into the center comes out clean, about 20 minutes. Remove pan from oven and allow to cool completely.\nBeat unsalted butter in a large bowl until smooth; beat in 5 tablespoons Irish cream liqueur until mixture is creamy.\nSlowly beat in confectioners' sugar, 1 cup at a time, until frosting is desired stiffness; spread frosting on brownies to serve.\n",
                Ingredients = "2 (19.8 ounce) packages fudge brownie mix, 1 cup Irish cream liqueur, 2/3 cup vegetable oil, 2 eggs, 1 cup unsalted butter, softened, 5 tablespoons Irish cream liqueur, 4 cups confectioners' sugar"}};
        }


        // GET: api/<RecipeController>
        [HttpGet]
        public List<Recipe> Get()
        {
            return recipes;
        }

        // GET api/<RecipeController>/5
        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            var recipe = recipes.Find(x => x.Id == id);
            return recipe;
        }

        // GET api/<RecipeController>/GetRecipeByName?title=Cookie
        [HttpGet("GetRecipeByName")]
        public IEnumerable<Recipe> Get(string title)
        {
            var recipe = recipes.Where(x => x.Title.Contains(title));
            return recipe;
        }
    }
}
