using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class Cheese : IComponent
{
    public string getPart()
    {
        return "Cheese";
    }
}