import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("that i am logged in", () => {
  cy.login("adminuser@mail.com", "Password1234!");
});

When("I press on the admin page button", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should be redirected to admin page", () => {
  cy.url().should("include", "/admindashboard");
});
