Feature: AdminLogin-funktion

    Scenario: Admin logs in with correct credentials and is redirected to the userhomepage
        Given I am on the login page
        When I enter the correct email and password
        And I click the login button to log in
        Then I should be redirected to the userhomepage