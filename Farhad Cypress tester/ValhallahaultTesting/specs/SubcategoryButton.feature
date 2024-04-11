Feature: "Subcategory button on admin page"

Scenario: Admin clicks on Subcategory button so it redirects to desired page
  Given that i am logged in
  When I press on the admin page button 
  Then I should be redirected to admin page
  When I click Subcategories button
  Then I should be redirected to subcategorypage

        