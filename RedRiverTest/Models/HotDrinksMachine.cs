namespace RedRiverTest.Models
{
    public class HotDrinksMachine : IChocolateMachine, ICoffeeMachine, ILemonTeaMachine
    {
        public List<string> LemonTeaActions()
        {
            var actionList = new List<string>() {"Boil some water", "Steep the water in the tea", "Pour tea in the cup", "Add lemon"};
            return actionList;
        }

        public List<string> CoffeeActions()
        {
            var actionList = new List<string>() { "Boil some water", "Brew the coffee grounds", "Pour coffee in the cup", "Add sugar and milk" };
            return actionList;
        }

        public List<string> ChocolateActions()
        {
            var actionList = new List<string>() { "Boil some water", "Add drinking powder to the water", "Pour chocolate in the cup"};
            return actionList;
        }
    }
}
