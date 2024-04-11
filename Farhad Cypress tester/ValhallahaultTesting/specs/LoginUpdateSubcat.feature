Feature: Login and update subcategory

    Scenario: User logs in with correct credentials and is redirected to the userhomepage to able to update subcategory
        Given I am on the login page
        When I enter the correct email and password
        And I click the login button to log in
        Then I should be redirected to the userhomepage
        Given I am on the homepage
        When I click on Admin page
        Then I should be redirected to admindashboard
        When I click the Subcategories button
        Then I should be redirected to subcategorypage
        And I click on the first edit button
        Then I fill the information in the fields
        And I click on the update button to update
        And I click on home page
        Then i should be redirected to homepage
        When I click on the first category option
        Then I should be redirected to Categorypage
        Given I am on the CategoryPage
        When i click on segment 1 button I can then see the changes
