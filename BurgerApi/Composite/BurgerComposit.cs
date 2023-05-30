using Microsoft.AspNetCore.Mvc;

namespace BurgerApi;

public class BurgerComposit : IComponent
{


   List<IComponent> composite = new List<IComponent>();

   public void addLeaf(IComponent Leaf )
   { 
    
    composite.Add(Leaf);

   }

   public void removeLeaf (IComponent Leaf)
   {
    composite.Remove(Leaf);
   }


    public string getPart()
    {
       string part = null;
            
            for(int i =0; i < composite.Count;i++)

            {  // returnList.Add(new CustomBurger{parts=components.ElementAt(i).getBurgerPart()});
                 part += composite.ElementAt(i).getPart();

    
            }

            return part;
    }
}