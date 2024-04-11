Feature: Test Admin-Page
    Scenario: Login and update segment
        # Given I am on the login page
        # When I enter the correct email and password
        # And I click the login button to log in
        # Then I should be redirected to the userhomepage
        Given I am logged in
        When Admin page is clicked
        Then I should be redirected to the admin page
        When I click on segments
        Then I should be redirected to segmentpage
        When I click on edit on a specific segment
        And I click on the name input
        And I type a new segment name
        And i click on the description field
        And I type a new segment description
        And I click Update
        Then the segment should be updated successfully
    
