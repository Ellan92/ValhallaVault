import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

// Given("I am on the login page", () => {
//   cy.visit("/account/login");
// });

// When("I enter the correct email and password", () => {
//   cy.get('input[placeholder="name@example.com"]').type("adminuser@mail.com");
//   cy.get('input[placeholder="password"]').type("Password1234!");
// });

// When("I click the login button to log in", () => {
//   cy.get(".w-100.btn.btn-lg.btn-primary").click();
// });

// Then("I should be redirected to the userhomepage", () => {
//   cy.url().should("include", "/Homepage");
// });

Given("I am logged in", () => {
  cy.login();
});

When("Admin page is clicked", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should be redirected to the admin page", () => {
  // cy.visit("/admindashboard");
  cy.get(".display-2").contains("Admin Dashboard");
});

When("I click on segments", () => {
  cy.wait(1000);
  cy.get(":nth-child(2) > :nth-child(2) > .btn").click();
});

Then("I should be redirected to segmentpage", () => {
  // cy.visit("/segmentpage");
  cy.wait(1000);
  cy.get(".display-2").contains("Segments");
});

When("I click on edit on a specific segment", () => {
  cy.wait(1000);
  cy.get(".list-unstyled > :nth-child(2)").click();
});

When("I click on the name input", () => {
  cy.get(".segmentNameInput").click();
});

When("I type a new segment name", () => {
  cy.get(".segmentNameInput").type("NewSegmentName");
});

When("i click on the description field", () => {
  cy.get(".segmentDescriptionInput").click();
});

When("I type a new segment description", () => {
  cy.get(".segmentDescriptionInput").type("NewSegmentDescription");
});

When("I click Update", () => {
  cy.get("div > :nth-child(7)").click();
});

Then("the segment should be updated successfully", () => {
  // TODO: implement step
  cy.get(".list-unstyled > :nth-child(1)").contains("NewSegmentName");
});
