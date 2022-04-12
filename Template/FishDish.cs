namespace Template
{
    internal class FishDish : CookingTemplate
    {
        protected internal override void AddIngrediant()
        {
            Console.WriteLine("Added Fish");
        }
    }
}
