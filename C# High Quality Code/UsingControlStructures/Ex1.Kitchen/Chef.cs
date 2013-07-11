namespace Ex1.Kitchen
{
    using System;

    class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }
    }
}
