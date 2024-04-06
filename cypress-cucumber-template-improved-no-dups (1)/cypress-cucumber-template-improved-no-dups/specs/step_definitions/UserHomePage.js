import { Given, Then } from "@badeball/cypress-cucumber-preprocessor";

// Upprepa hela inloggnings-proceduren..
Given('I am on the userhomepage', () => {
     cy.visit("/account/login");
     cy.get('input[placeholder="name@example.com"]').type('user@mail.com');
     cy.get('input[placeholder="password"]').type('Password1234!');
     cy.get('.w-100.btn.btn-lg.btn-primary').click();
     cy.url().should('include', '/Homepage');
});

Then('I should see the welcome message with my username', () => {
  // Verifiera att meddelandet med användarnamnet syns
  cy.get('.font-monospace').should('be.visible').contains('Välkommen');
});

Then('I should see a header asking me to choose a category', () => {
  // Verifiera att rubriken för att välja kategori syns
  cy.get('.font-monospace').should('be.visible').contains('Välj en kategori:');
});

Then('I should see a list of categories to choose from', () => {
  // Verifiera att listan över kategorier syns
  cy.get('.btn-group-vertical').should('be.visible');
});