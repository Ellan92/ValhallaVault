import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("that I am on the login page", () => {
  cy.visit("/account/login");
});

When("I enter the correct email and password for user", () => {
  cy.get('input[placeholder="name@example.com"]').type("user@mail.com");
  cy.get('input[placeholder="password"]').type("Password1234!");
});

When("I click the login button to log in for user", () => {
  cy.get(".w-100.btn.btn-lg.btn-primary").click();
});

Then("I should be redirected to the userhomepage as userr", () => {
  cy.url().should("include", "/Homepage");
});
