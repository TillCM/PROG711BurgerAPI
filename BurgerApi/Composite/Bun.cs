using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;
public class Bun : IComponent
{
    public string getPart()
    {
        return "Bun";
    }
}