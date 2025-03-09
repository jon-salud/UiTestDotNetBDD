using System.Threading.Tasks;
using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace UiTestDotNet.Hooks;

[Binding]
public sealed class Hooks
{
    private readonly ScenarioContext _scenarioContext;
    private IBrowser? _browser;
    private IPlaywright? _playwright;
    private IPage? _page;

    public Hooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public async Task BeforeScenarioAsync()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
        _page = await _browser.NewPageAsync();

        // Store page object in scenario context for DI
        _scenarioContext.Set(_page);
    }

    [AfterScenario]
    public async Task AfterScenarioAsync()
    {
        if (_browser != null)
        {
            await _browser.CloseAsync();
        }
        _playwright?.Dispose();
    }
}
