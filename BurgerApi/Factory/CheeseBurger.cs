using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class CheeseBurger : IBurger
{
    public string getBun()
    {
        return "Rice Bun";
    }

    public string getPatty()
    {
        return  "Beef Patty";
    }

    public string getToppings()
    {
       return  "Cheese and Tomato";
    }
}