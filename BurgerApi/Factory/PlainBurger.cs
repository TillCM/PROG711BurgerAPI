using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class PlainBurger : IBurger
{
    public string getBun()
    {
       return "Wheat Bun";
    }

    public string getPatty()
    {
        return "Beef Patty";
    }

    public string getToppings()
    {
        return "Tomatoes";
    }
}