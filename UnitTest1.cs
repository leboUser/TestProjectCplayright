using TestProjectCplayright.Swaglabs;

namespace TestProjectCplayright;


[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HomepageHasSaucedemoInTitleAndviewloginpage()
    {
     

        var login = new Login(Page);
         Assert.IsTrue(await login.accessPage("Swag Labs"));
        await login.LoginPage("standard_user", "secret_sauce");

    }

     [Test]
    public async Task AddTwoItems()
    {
     
        var login = new Login(Page);
        Assert.IsTrue(await login.accessPage("Swag Labs"));
        await login.LoginPage("standard_user", "secret_sauce");
        var dashboard = new Dashboard(login.page);
        Assert.IsTrue(await dashboard.addCart(2));


    }

}
