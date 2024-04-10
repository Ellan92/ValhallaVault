

Cypress.Commands.add('login', (email, password) => {
  cy.get('input[placeholder="name@example.com"]').type(email);
  cy.get('input[placeholder="password"]').type(password);
 
});
