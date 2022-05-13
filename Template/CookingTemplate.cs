namespace Template
{
    internal abstract class CookingTemplate
    {
        public void Cook()
        {
            AddedOil();
            AddedSalt();
            AddIngredient();
            AdjustFire();
        }

        private void AddedOil()
        {
            Console.WriteLine("Added Oil");
        }

        private void AddedSalt()
        {
            Console.WriteLine("Added Salt");
        }

        protected abstract void AddIngredient();

        private void AdjustFire()
        {
            Console.WriteLine("Adjusted fire");
        }
    }
}
