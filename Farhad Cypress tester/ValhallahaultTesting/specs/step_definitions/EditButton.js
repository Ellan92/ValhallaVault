import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

When("I click on edit button it will display input fields", () => {
  cy.wait(500);
  cy.get(".list-unstyled > :nth-child(2)").click({ force: true });
});
