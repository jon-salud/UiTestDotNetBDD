Feature: Example Feature
  To verify Playwright documentation website is accessible
  As a user
  I want to navigate and verify pages

  Scenario: Verify the Playwright homepage has correct title
    Given I navigate to the Playwright homepage
    When I click the Get started link
    Then I should see the Installation page
