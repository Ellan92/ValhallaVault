Feature: Visa rätt element på välkomstsidan och dirigera användaren till login-sidan

    Scenario: User clicks on the login button and is redirected to the login page
        Given I am on the welcomepage
        Then I see the following elements:
            | Element                                 |
            | .card                                   |
            | .card-img                               |
            | .btn-primary                            |
            | .btn-light                              |
            | Welcome to ValhallaVault Cyber Security |
        When I click the login button
        Then I should be redirected to the login page