
Feature: Login to Admin and create a category    

    Scenario: Login and create a category with the admin user
    Given that I am logged in
    And I see the homepage as a logged in user
    And I see the admin dashboard button
    
    When I click the admin dashboard button

    Then I should see the admin dashboard

    Given that I am on the admin dashboard
    And I see the Add Page button

    When I press the Add Page button

    Then I should see the Add page

    Given that I am on the Add page
    And I see the Category name field
    And I see the Category description field


    When I enter the Category name
    And I enter the Category description
    And I click the Add Category button

    Then I should see Category added sucessfully
    And the Category name field should be empty
    And the Category description field should be empty
    