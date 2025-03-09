using Microsoft.Playwright;

namespace UiTestDotNet.Pages;

public class HomePage
{

    public async Task ClickGetStartedAsync()
    {
        await _page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();
    }

    public async Task NavigateAsync()
    {
        await _page.GotoAsync("https://playwright.dev");
    }

    private readonly IPage _page;

    public HomePage(IPage page)
    {
        _page = page;
    }
}
