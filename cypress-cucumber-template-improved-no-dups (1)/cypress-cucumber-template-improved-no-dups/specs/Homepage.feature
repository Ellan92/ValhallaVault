

Feature: Hemsidans layout 

    #Scenario - beskrivning 
    Scenario: I visit the homepage
    #Given - användaren befinner sig redan på startsidan.
    Given I am on the homepage
    #When - handlingen som användaren utför (i detta fall bara att observera sidan).  
    When I look at the page 
    #Then - det förväntade resultatet av handlingen som användaren utför (ett antal element observeras). 
    Then I see the following elements:
            | Element            |
            | PageTitle          |
            | Bakgrundsbild      |
            | Logga in knapp     |
            | Registrera knapp   |
            | Välkomstmeddelande |

