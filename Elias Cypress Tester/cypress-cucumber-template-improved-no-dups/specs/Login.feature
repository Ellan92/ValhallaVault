# Feature: Login

#     Scenario: Go to login page
#         Given I am on the home page
#         When I click the login button
#         Then I should be redirected to the login page

#     Scenario: Login
#         When I click on the email field
#         And I write "adminuser@mail.com"
#         And I click on the password field
#         And I Write "Password1234!"
#         And I click login
#         Then I should be redirected to the homepage

Feature: Login-funktion

    Scenario: User logs in with correct credentials and is redirected to the userhomepage
        Given I am on the login page
        When I enter the correct email and password
        And I click the login button to log in
        Then I should be redirected to the userhomepage