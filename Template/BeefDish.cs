namespace Template
{
    internal class BeefDish : CookingTemplate
    {
        protected override void AddIngredient()
        {
            Console.WriteLine("Added Beef");
        }
    }
}
