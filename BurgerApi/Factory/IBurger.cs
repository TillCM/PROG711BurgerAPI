using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public interface IBurger
{
    string getBun();

    string getPatty();

    string getToppings();

}