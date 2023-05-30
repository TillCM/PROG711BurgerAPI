using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class BurgerFactory
{

 public IBurger returnedBurger;

 public IBurger GetBurger(string burgerType)
 {
    
    switch(burgerType)
    {
        case "Plain":
            returnedBurger = new PlainBurger();
            break;
        case "Cheese":
            returnedBurger = new CheeseBurger();
            break;
        
        case "Veggie":
            returnedBurger = new VeggieBurger();
            break;

    }


    return returnedBurger;
 }



}