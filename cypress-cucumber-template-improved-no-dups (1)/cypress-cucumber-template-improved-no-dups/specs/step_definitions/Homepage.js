import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('I am on the homepage', () => {
  // Besök startsidan
  cy.visit("/");
});

When('I look at the page', () => {
  // Behöver ingen kod 
});

Then('I see the following elements:', () => {
  // Verifierar synligheten av elementen
  cy.get('.card').should('be.visible');
  cy.get('.card-img').should('be.visible');
  cy.get('.btn-primary').should('be.visible');
  cy.get('.btn-light').should('be.visible');
  cy.contains('Welcome to ValhallaVault Cyber Security').should('be.visible');
});