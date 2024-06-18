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

}
