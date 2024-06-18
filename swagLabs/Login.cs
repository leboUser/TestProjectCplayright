using System;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace TestProjectCplayright.Swaglabs;


class Login{

    private readonly IPage page;
     private readonly ILocator usernameTexbox;      
    private readonly ILocator passwordTexbox;       
    private readonly ILocator loginButton; 
   

    public Login(IPage page){
       this.page = page;
        usernameTexbox = page.Locator("data-test=username");
        passwordTexbox = page.Locator("data-test=password");
        loginButton = page.Locator("data-test=login-button");
    }

    public async Task<bool> accessPage(String title){

           await page.GotoAsync("https://www.saucedemo.com/");
            string title1 = await page.TitleAsync();

    
           return title1.Equals(title);
           
    }

    public async Task LoginPage(string username, string password) {
         await usernameTexbox.FillAsync("standard_user");
         await passwordTexbox.FillAsync("secret_sauce");
         await loginButton.ClickAsync();

    }

}