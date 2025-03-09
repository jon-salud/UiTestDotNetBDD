# UI Test .NET Project

This project demonstrates UI testing using Playwright with .NET and SpecFlow for behavior-driven development (BDD).

## Project Structure

```text
UiTestDotNet/
├── Features/              # SpecFlow feature files
│   └── Example.feature    # Example test scenarios
├── StepDefinitions/       # Test step implementations
└── bin/                   # Compiled binaries
```

## Features

- BDD testing using SpecFlow and Gherkin syntax
- UI automation with Playwright for .NET
- Example scenarios for testing web applications

## Example Scenario

The project includes an example feature for testing the Playwright documentation website:

```gherkin
Feature: Example Feature
  To verify Playwright documentation website is accessible
  As a user
  I want to navigate and verify pages

  Scenario: Verify the Playwright homepage has correct title
    Given I navigate to the Playwright homepage
    When I click the Get started link
    Then I should see the Installation page
```

## Getting Started

1. Prerequisites:
   - .NET SDK
   - Visual Studio or Visual Studio Code
   - Playwright for .NET

2. Installation:

   ```bash
   dotnet restore
   ```

3. Running Tests:

   ```bash
   dotnet test
   ```

## Technology Stack

- .NET
- Playwright
- SpecFlow
- Gherkin

## Best Practices

- Write features in Gherkin syntax
- Follow BDD principles
- Maintain clear and descriptive scenario steps
- Use page object pattern for UI interactions

## Contributing

1. Create feature branches for new tests
2. Follow BDD guidelines when writing scenarios
3. Ensure proper documentation for new features
4. Submit pull requests for review

## License

This project is licensed under the MIT License.
