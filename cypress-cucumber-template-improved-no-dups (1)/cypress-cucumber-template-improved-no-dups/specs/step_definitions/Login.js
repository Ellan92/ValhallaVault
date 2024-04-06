import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('I am on the login page', () => {
  // Besök inloggningssidan
  cy.visit("/account/login");
});

When('I enter the correct email and password', () => {
  // Ange korrekt e-post och lösenord
  cy.get('input[placeholder="name@example.com"]').type('your_email@example.com');
  cy.get('input[placeholder="password"]').type('your_password');
});

When('I click the login button', () => {
  // Klicka på inloggningsknappen
  cy.contains('Log In').click();
});

Then('I should be redirected to the userhomepage', () => {
  // Verifiera att användaren har omdirigerats till användarhemsidan
  cy.url().should('include', '/userhomepage');
});