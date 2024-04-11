Feature: User tries to go to admin page  

    Scenario: User goes to the admin page and gets access denied
    Given I am logged in as a user
    When I click the admin page
    Then I should be redirected to access denied
    And I should see Access Denied text