import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";


// Utförs som en del av testets förberedelse, och det är inte i sig ett test. 
// Detta är endast en instruktion till Cypress att öppna webbläsaren och navigera till en specifik URL.
Given('I am on the welcomepage', () => {
  cy.visit("/"); 
});

  // Verifierar synligheten av elementen
Then('I see the following elements:', () => {
  cy.get('.card').should('be.visible');
  cy.get('.card-img').should('be.visible');
  cy.get('.btn-primary').should('be.visible');
  cy.get('.btn-light').should('be.visible');
  cy.contains('Welcome to ValhallaVault Cyber Security').should('be.visible');
});

  // leta efter texten "Log In" och klicka sedan på den.
When('I click the login button', () => {
  cy.contains('Log In').click();
});

  // Verifiera att användaren har omdirigerats till inloggningssidan
Then('I should be redirected to the login page', () => {
  cy.url().should('include', '/account/login');
});