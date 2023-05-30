using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class VeggiePatty : IComponent
{
    public string getPart()
    {
        return "VeggieBurger Patty ";
    }
}

