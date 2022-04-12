namespace Template
{
    internal abstract class CookingTemplate
    {
        public void Cook()
        {
            AddedOil();
            AddedSalt();
            AddIngrediant();
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

        protected internal abstract void AddIngrediant();

        private void AdjustFire()
        {
            Console.WriteLine("Adjusted fire");
        }
    }
}
