import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

/* No duplicate steps, this one already in AdminButton.js
Given('that i am logged in', () => {});*/

/* No duplicate steps, this one already in AdminButton.js
When('I press on the admin page button', () => {});*/

/* No duplicate steps, this one already in AdminButton.js
Then('I should be redirected to admin page', () => {});*/

When("I click Subcategories button", () => {
  cy.wait(500);
  cy.get(":nth-child(3) > :nth-child(1) > .btn").click({ force: true });
});

/* No duplicate steps, this one already in Login.js
Then('I should be redirected to subcategorypage', () => {});*/
