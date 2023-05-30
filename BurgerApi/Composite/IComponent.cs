using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public interface  IComponent 
{
    string getPart();
}