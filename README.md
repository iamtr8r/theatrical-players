Imagine a company of theatrical players who go out to various events performing plays. Tipically, a customer will request a few plays and the company charges them based on the size of the audience and the kind  of play they perform. There are currently two kinds of plays that the company performs: tragedies and comedies.

## Business rules

* The plays they currently perform are 
  * hamlet (tragedy)
  * as-like (comedy)
  * othello (tragedy)
* The micro-service must process the following example data to calculate the bill
  * Customer name: <name_of_the_customer>
  * performances: 
    * Play: hamlet / Audience: 55
    * Play: as-like / Audience: 35
* The price for tragedy plays is $40,000 plus $1,000 for each additional person in the audience that surpasses 30
* The price for comedy plays is $30,000 plus $500 for each additional person in the audience that surpasses 20