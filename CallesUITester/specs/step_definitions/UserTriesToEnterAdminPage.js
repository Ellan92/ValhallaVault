import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am logged in as a user", () => {
  cy.userlogin();
});

When("I click the admin page", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should be redirected to access denied", () => {
  cy.url().should(
    "eq",
    "https://localhost:7214/Account/AccessDenied?ReturnUrl=%2Fadmindashboard"
  );
});

Then("I should see Access Denied text", () => {
  // TODO: implement step
  cy.get(".display-2").should("be.visible");
});
