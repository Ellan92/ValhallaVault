Cypress.Commands.add("adminlogin", (email, password) => {
  cy.visit("/account/login");
  cy.get('input[placeholder="name@example.com"]').type("adminuser@mail.com");
  cy.get('input[placeholder="password"]').type("Password1234!");
  cy.get(".w-100.btn.btn-lg.btn-primary").click();
});

Cypress.Commands.add("userlogin", (email, password) => {
  cy.visit("/account/login");
  cy.get('input[placeholder="name@example.com"]').type("user@mail.com");
  cy.get('input[placeholder="password"]').type("Password1234!");
  cy.get(".w-100.btn.btn-lg.btn-primary").click();
});
