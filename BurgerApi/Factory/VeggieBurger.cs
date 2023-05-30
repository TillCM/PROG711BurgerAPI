using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class VeggieBurger : IBurger
{
    public string getBun()
    {
        return "Rye Bun";
    }

    public string getPatty()
    {
        return "Miracle burger patty";
    }

    public string getToppings()
    {
        return "Tomato";
    }
}