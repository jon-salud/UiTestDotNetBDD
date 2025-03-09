using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using TechTalk.SpecFlow;

namespace UiTestDotNet.StepDefinitions;

[Binding]
public class ExampleSteps
{
    private readonly IPage _page;

    public ExampleSteps(ScenarioContext scenarioContext)
    {
        _page = scenarioContext.Get<IPage>();
    }

    [Given(@"I navigate to the Playwright homepage")]
    public async Task GivenINavigateToThePlaywrightHomepage()
    {
        await _page.GotoAsync("https://playwright.dev");
    }

    [When(@"I click the Get started link")]
    public async Task WhenIClickOnGetStarted()
    {
        await _page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();
    }

    [Then(@"I should see the Installation page")]
    public async Task ThenIShouldSeeTheInstallationPage()
    {
        await Expect(_page.GetByRole(AriaRole.Heading, new() { Name = "Installation" }))
            .ToBeVisibleAsync();
    }
}
