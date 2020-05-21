using System;

namespace LearningCSharp
{
    // Inherit all functionality from the "Chef" class
    // This is the "sub" class
    class ItalianChef : BasicChef
    {
        public void MakeLasagne()
        {
            Console.WriteLine("The Chef cooks Lasagne");
        }

        // Optional modifier "override" used to indicate basic chef method overwritten
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef cooks special dish: Tiramisu");
        }
    }
}
