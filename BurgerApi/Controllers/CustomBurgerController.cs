using Microsoft.AspNetCore.Mvc;

namespace BurgerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomBurgerController : ControllerBase
{

    [HttpGet(Name = "GetCustomBurger")]

   public string getCustomBurger(bool cheese, bool bun, bool patty, bool veggiePatty)
   {
        BeefPatty beefPatty = new BeefPatty();
        Bun Bun = new Bun();
        Cheese Cheese = new Cheese();
        VeggiePatty VeggiePatty = new VeggiePatty();

     
        
        BurgerComposit composit = new BurgerComposit();

    composit.addLeaf(Bun);
    composit.addLeaf(VeggiePatty);
    composit.addLeaf(Cheese);
    composit.addLeaf(beefPatty);

    if(!cheese)
    {
        composit.removeLeaf(Cheese);
    }

    if(!patty)
    {
        composit.removeLeaf(beefPatty);
    }

    if(!veggiePatty)
    {
        composit.removeLeaf(VeggiePatty);
    }

    
    if (!bun)
    {
        composit.removeLeaf(Bun);
    }



        return composit.getPart();


   }
   
  

}
