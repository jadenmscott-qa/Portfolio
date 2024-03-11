# Test Cases
These 5 test cases will be used across both Selenium Projects. These Test cases can also be found on [this project board.](https://umami-panduh.atlassian.net/jira/core/projects/JE/board#/rule-list?systemLabelId=project&page=1&pageSize=20&sortKey=name&sortOrder=ASC)

## 1. Go to Website

| Title | Input | Steps | Expected Result | Actual Result | Notes |
| --- | --- | --- | --- | --- | --- |
| Site navigation | [Home Page](https://magento.softwaretestingboard.com/) | 1. Click URL Bar, 2. Input provided link, 3. Press Enter key | Pass | Pass |  |
## 2. Looking For Item
| Title | Input | Steps | Expected Result | Actual Result | Notes |
| --- | --- | --- | --- | --- | --- |
| Searching Item | "shirt" | Navigate to the home page, Locate the search bar in the top right corner of the page, Input “shirt” into the search bar, Hit enter or click the magnifying glass to start the search function | Pass | Pass |  |
## 3. Adding Item To Cart
| Title | Input | Steps | Expected Result | Actual Result | Notes |
| --- | --- | --- | --- | --- | --- |
| Adding Item To Cart |  | Navigate to the page, Scroll down page, Locate on the page any item of choosing, Click the item, Select size, color, or any other necessary options, Ensure Quantity field is not empty, Click the “Add to Cart” button | Pass | Fail | Page reloaded with a pop-up that contained the following message “The requested qty is unavailable” |
## 4. Removing Item From Cart 
| Title | Input | Steps | Expected Result | Actual Result | Notes |
| --- | --- | --- | --- | --- | --- |
|  | [Shorts](https://magento.softwaretestingboard.com/apollo-running-short.html), [Water Bottle](https://magento.softwaretestingboard.com/affirm-water-bottle.html), [Hoodie](https://magento.softwaretestingboard.com/eos-v-neck-hoodie.html) | Navigate to homepage, Add items to cart if not already present, Click Shopping cart icon, Click “View or Edit cart” hyperlink at bottom of pop-up menu, Click trashcan icon of any item of choosing to remove the item | Pass | Pass |  |
## 5. Checking Out
| Title | Input | Steps | Expected Result | Actual Result | Notes |
| --- | --- | --- | --- | --- | --- |
| Purchasing | Item ~ (“Voyage Yoga Bag”), Customer information ~ (Name : Test Tester, Street Adress : 123 Tester Ln, City : , Testerville, State/ Province : Tennessee, Zip Code : 00000, Country : USA), Email ~ (test@test.com), Phone Number ~ (1234567890) | Navigate to the home page, Locate the search bar in the top right, Input ”Voyage Yoga Bag”, Hit Enter or click the magnifying glass to begin the search, Locate the Voyage Yoga Bag in the list of items, Hover over the item with mouse, CLick “Add to Cart”, Locate and click the shopping cart icon in the top right hand corner, “Click Proceed to Checkout” button, Input customer information, Click the “Fixed” Shipping method for $15, Click “Next” button, Click “Place Order” button | Pass | Pass |  |