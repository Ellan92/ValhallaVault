Feature: "Edit button"
Scenario:"When admin clicks on edit button on subcategorypage"
  Given that i am logged in
  When I press on the admin page button 
  Then I should be redirected to admin page
  When I click Subcategories button
  Then I should be redirected to subcategorypage
  When I click on edit button it will display input fields

