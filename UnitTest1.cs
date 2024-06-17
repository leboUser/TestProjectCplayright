namespace TestProjectCplayright;


[TestFixture]
public class Tests : PageTest
{
    [Test]
    public async Task HomepageHasSaucedemoInTitleAndviewloginpage()
    {
        await Page.GotoAsync("https://www.saucedemo.com/");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Swag Labs"));

        // create a locator
        var usernameTexbox = Page.Locator("data-test=username");
        var passwordTexbox = Page.Locator("data-test=password");
        var loginButton = Page.Locator("data-test=login-button");

        //enter username and password
      

        // Click the login button.
        await loginButton.ClickAsync();

    }

}
