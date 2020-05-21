using System;

namespace LearningCSharp
{
    class BasicChef
    {
        // The "super" class
        public void MakeChicken()
        {
            Console.WriteLine("The Chef cooks chicken");
        }

        // This method can be redefined by subclasses
        public virtual void MakeSalad()
        {
            Console.WriteLine("The Chef prepares a salad");
        }

        // Optional "virtual" means that sub classes can overwrite this method
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef cooks special dish: Coq an Vin");
        }
    }
}
