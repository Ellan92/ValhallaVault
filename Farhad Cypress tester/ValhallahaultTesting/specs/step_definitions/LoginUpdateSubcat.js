import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given("I am on the login page", () => {
  cy.visit("/account/login");
});

When("I enter the correct email and password", () => {
  // Ange korrekt e-post och lösenord
  cy.get('input[placeholder="name@example.com"]').type("adminuser@mail.com");
  cy.get('input[placeholder="password"]').type("Password1234!");
});

When("I click the login button to log in", () => {
  // Klicka på inloggningsknappen
  cy.get(".w-100.btn.btn-lg.btn-primary").click();
});

Then("I should be redirected to the userhomepage", () => {
  // Verifiera att användaren har omdirigerats till användarhemsidan
  cy.url().should("include", "/Homepage");
});

Given("I am on the homepage", () => {
  cy.visit("/Homepage");
});

When("I click on Admin page", () => {
  cy.get('[href="admindashboard"]').click();
});

Then("I should be redirected to admindashboard", () => {
  cy.url().should("include", "/admindashboard");
});

Given("I am on the adminpage", () => {
  cy.visit("/admindashboard");
});

When("I click the Subcategories button", () => {
  cy.wait(500);
  cy.get(":nth-child(3) > :nth-child(1) > .btn").click({ force: true });
  //cy.get("#btnSubcategory").click();

  /*
  cy.log("Before clicking the button");
  cy.get(":nth-child(3) > :nth-child(1) > .btn").click();
  cy.contains("Subcategories").click();
  cy.log("After clicking the button");
  cy.contains("Subcategories").click();
  */
});

Then("I should be redirected to subcategorypage", () => {
  // Wait for the URL to include "/subcategorypage"
  //cy.location("/subcategorypage").should("eq", "/subcategorypage");
  cy.url().should("include", "/subcategorypage");
});

Given("I am on the subcategorypage", () => {
  cy.visit("/subcategorypage");
});

Then("I click on the first edit button", () => {
  cy.wait(500);
  cy.get(".list-unstyled > :nth-child(2)").click({ force: true });
});

Then("I fill the information in the fields", () => {
  cy.wait(1000);
  cy.get('[placeholder="NewSubcategoryName"]').type("NewSubcategoryName", {
    force: true,
  });
  cy.wait(1000);
  cy.get('[placeholder="OldDescription"]').type("OldDescription", {
    force: true,
  });
});

Then("I click on the update button to update", () => {
  cy.get("div > :nth-child(7)").click({ force: true });
});

Then("I click on home page", () => {
  cy.get('.navbar > [href="Homepage"]').click();
});

Then("i should be redirected to homepage", () => {
  cy.url().should("include", "/Homepage");
});

When("I click on the first category option", () => {
  cy.wait(1000);
  cy.get('[href="CategoryPage/1"]').click();
});

Then("I should be redirected to Categorypage", () => {
  cy.wait(1000);
  cy.url().should("include", "/CategoryPage/1");
});

Given("I am on the CategoryPage", () => {
  cy.visit("/Categorypage/1");
});

When("i click on segment 1 button I can then see the changes", () => {
  cy.wait(500);
  cy.get(".card-link").click();
});
