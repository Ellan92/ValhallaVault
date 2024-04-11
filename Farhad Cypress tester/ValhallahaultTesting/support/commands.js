Cypress.Commands.add("login", (username, password) => {
  cy.visit("/account/login");
  cy.get(":nth-child(5) > .form-control").type(username);
  cy.get(":nth-child(6) > .form-control").type(password);
  cy.get(".w-100").click();
});
