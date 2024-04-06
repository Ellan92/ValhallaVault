
Feature: Validera att rätt element finns på userhomepage

    Scenario: Verify elements on the user homepage
        Given I am on the userhomepage
        Then I should see the welcome message with my username
        And I should see a header asking me to choose a category
        And I should see a list of categories to choose from