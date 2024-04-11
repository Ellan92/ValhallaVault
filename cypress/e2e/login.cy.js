describe('template spec', () => {
  it('passes', () => {
      cy.visit('https://localhost:7214')

      /*Given("I am on the home page", () => {*/
          /*cy.visit("/");*/
          // cy.url().should("include", "myh.se");
      /*});*/

      /*When("I click the login button", () => {*/
          cy.get(".btn-primary").click();
          // TODO: implement step
      /*});*/

      /*Then("I should be redirected to the login page", () => {*/
          /*cy.visit("/account/login");*/
      /*});*/

      /*When("I click on the email field", () => {*/
          cy.get(":nth-child(5) > .form-control");
      /*});*/

/*      When("I write {string}", (str) => {*/
          cy.get(":nth-child(5) > .form-control").type("adminuser@mail.com");
      /*});*/

/*      When("I click on the password field", () => {*/
          cy.get(":nth-child(6) > .form-control");
      /*});*/

/*      When("I Write {string}", (str) => {*/
          cy.get(":nth-child(6) > .form-control").type("Password1234!");
      /*});*/

      /*When("I click login", () => {*/
          cy.get(".w-100").click();
      /*});*/

      /*Then("I should be redirected to the homepage", () => {*/
          // cy.visit("/Homepage");
      /*});*/

  })
})