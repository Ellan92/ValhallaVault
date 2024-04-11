Feature: Test Admin-Page
    Scenario: Login and add segment
        # Given I am on the login page
        # When I enter the correct email and password
        # And I click the login button to log in
        # Then I should be redirected to the userhomepage
        Given I am logged in on the homepage
        When I click on the admin page
        Then I should be redirected to the admin dashboard
        When I click on AddPage
        Then I should be redirected to AddPage
        When I click on the name input field
        And I type a name
        And I click on the description input field
        And I type a description
        And I select a category from the list
        And I click Add segment
        Then the segment should be added successfully