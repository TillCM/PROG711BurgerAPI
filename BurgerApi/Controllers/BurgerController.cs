using Microsoft.AspNetCore.Mvc;

namespace BurgerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BurgerController : ControllerBase
{

    [HttpGet(Name = "GetBurger")]

    public List<BurgerModel> getBurger(string burgerType ="Plain")
    {

        List<BurgerModel> returnedBurger = new List<BurgerModel>();

        BurgerFactory factory  = new BurgerFactory();
        IBurger burger  = factory.GetBurger(burgerType);
        returnedBurger.Add(new BurgerModel{Bun = burger.getBun(), Patty= burger.getPatty(), Toppings = burger.getToppings()});

        return returnedBurger;

        






    }
   
  

}
