using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace TestProjectCplayright.Swaglabs;


class Dashboard{

    private readonly IPage page;
    private readonly ILocator addBackPackCart;      
    private readonly ILocator addBikeLightCart;       
    private readonly ILocator menuButton; 
    private readonly ILocator cartnumber;

    private readonly ILocator cartButton;
   

    public Dashboard(IPage page){
       this.page = page;
        addBackPackCart = page.Locator("data-test=add-to-cart-sauce-labs-backpack");
        addBikeLightCart = page.Locator("data-test=add-to-cart-sauce-labs-bike-light");
        cartButton = page.Locator("data-test=shopping-cart-link");
        cartnumber = page.Locator("data-test=shopping-cart-badge");
        menuButton = page.Locator("id=react-burger-menu-btn");
    }


    public  async Task<bool> addCart(int number) {
    
         await addBackPackCart.ClickAsync();
         await addBikeLightCart.ClickAsync();
        string numberCart = await  cartnumber.InnerTextAsync();
        return numberCart.Equals(number.ToString());

    }

}