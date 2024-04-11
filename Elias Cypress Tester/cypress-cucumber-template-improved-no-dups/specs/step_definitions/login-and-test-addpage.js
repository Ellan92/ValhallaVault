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

Given("I am logged in on the homepage", () => {
  cy.login();
});

When("I click on the admin page", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should be redirected to the admin dashboard", () => {
  cy.wait(1000);
  cy.get(".display-2").contains("Admin Dashboard");
});

When("I click on AddPage", () => {
  cy.get(".justify-content-center > .col-5 > .btn").click();
});

Then("I should be redirected to AddPage", () => {
  cy.wait(1000);
  cy.get(".display-2").contains("Add Content");
});

When("I click on the name input field", () => {
  cy.get(":nth-child(2) > :nth-child(2) > :nth-child(3)").click();
});

When("I type a name", () => {
  cy.get(":nth-child(2) > :nth-child(2) > :nth-child(3)").type(
    "TestSegmentName"
  );
});

When("I click on the description input field", () => {
  cy.get(":nth-child(2) > .form-control").click();
});

When("I type a description", () => {
  cy.get(":nth-child(2) > .form-control").type("TestSegmentDescription");
});

When("I select a category from the list", () => {
  cy.get(":nth-child(2) > :nth-child(2) > select").select(
    "Cybersäkerhet för företag"
  );
});

When("I click Add segment", () => {
  cy.get(":nth-child(2) > :nth-child(2) > .btn").click();
});

Then("the segment should be added successfully", () => {
  cy.get(".text-success").contains("Segment added successfully.");
});
