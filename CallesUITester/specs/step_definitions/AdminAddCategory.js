import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("that I am logged in", () => {
  cy.adminlogin();
});

Given("I see the homepage as a logged in user", () => {
  cy.get(".logo").should("be.visible");
});

Given("I see the admin dashboard button", () => {
  cy.get('[href="admindashboard"]').should("be.visible");
});

When("I click the admin dashboard button", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should see the admin dashboard", () => {
  cy.get(".display-2").should("contain.text", "Admin");
});

Given("that I am on the admin dashboard", () => {
  cy.url().should("eq", "https://localhost:7214/admindashboard");
});

Given("I see the Add Page button", () => {
  cy.get(".justify-content-center > .col-5 > .btn").should("be.visible");
});

When("I press the Add Page button", () => {
  cy.wait(1000);
  cy.get(".justify-content-center > .col-5 > .btn").click();
});

Then("I should see the Add page", () => {
  cy.get(".display-2").should("be.visible");
});

Given("that I am on the Add page", () => {
  cy.url().should("eq", "https://localhost:7214/addpage");
});

Given("I see the Category name field", () => {
  cy.get(".categoryinput").should("be.visible");
});

Given("I see the Category description field", () => {
  cy.get(":nth-child(2) > :nth-child(1) > .form-control").should("be.visible");
});

When("I enter the Category name", () => {
  cy.get(".categoryinput").type("Test Category");
});

When("I enter the Category description", () => {
  cy.get(":nth-child(2) > :nth-child(1) > .form-control").type(
    "Test Category Desc"
  );
});

When("I click the Add Category button", () => {
  cy.get(":nth-child(2) > :nth-child(1) > .btn").click();
});

Then("I should see Category added sucessfully", () => {
  cy.get(".text-success").should("be.visible");
});

Then("the Category name field should be empty", () => {
  cy.get(".categoryinput").should("be.empty");
});

Then("the Category description field should be empty", () => {
  cy.get(":nth-child(2) > :nth-child(1) > .form-control").should("be.empty");
});
