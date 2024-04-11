Feature: UserLogin-funktion

    Scenario: User logs in with correct credentials and is redirected to the userhomepage
        Given that I am on the login page
        When I enter the correct email and password for user
        And I click the login button to log in for user
        Then I should be redirected to the userhomepage as userr