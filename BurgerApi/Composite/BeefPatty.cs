using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class BeefPatty : IComponent
{
    public string getPart()
    {
        return "Beef Patty";
    }
}