namespace Template
{
    internal class FishDish : CookingTemplate
    {
        protected override void AddIngredient()
        {
            Console.WriteLine("Added Fish");
        }
    }
}
