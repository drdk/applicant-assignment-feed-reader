# Optional applicant demo application, September 2012

The purpose of this repository is to create the basis for an assignment that you as an applicant to a job at DR can complete in order to showcase your abilities as a software developer.

This assignment is not meant to take more than 2 hours to complete, but feel free to spend as much time as you feel is necessary to showcase your talents. *Also remember that this is not mandatory. If you've got some other code you would rather show us then simply send us a link to that instead. This is meant for you if you don't have an active show case.*

## The Assignment

The assignment is to create a simple News Feed Reader that displays the current news from dr.dk. in a reasonable design.

The assignment has both a frontend and a backend part. You can choose to solve only one part if you don't feel you've the skill set to complete the other. Please hand in your solution no later than 09:00 on the day of your interview.

_PLEASE BE AWARE THAT FORKING ON GITHUB IS VISIBLE TO THE PUBLIC. IF YOU WISH TO REMAIN ANONYMOUS YOU CAN FORK MANUALLY OR SUBMIT YOUR SOLUTION AS A ZIP FILE TO US_

### .NET solution

The assignment has to be based on the code in the git repository you're currently browsing. Feel free to simply fork it on github and commit your final solution there. Just send us the link to your fork. Alternatively you can simply download the repository as a zip file and email is your solution as a zip in return. We, however, prefer that you use git as we use this as well. 

There are no limitations to how you solve this, but observing the following guidelines would be advantageous:

* Use Inversion of Control to create the appropriate seperation of concerns. We use StructureMap and AutoMapper.
* Use semantic HTML5 and CSS3 when creating the UI
* Ensure that the application is URL independant (e.g. use Url.Content and Url.Action when possible).

The solution already comes with a simple repository for reading DR's RSS Feed, and StructureMap is pre-wired into the DR.FeedReader.Web application. You're free to use these or write your own.

### JavaScript solution

The assignment can be solved using front-end technologies only. MooTools (http://mootools.net/) is the primary JavaScript framework used on dr.dk so we would prefer if you used that as well.

There are many ways to solve the assignment, but observing the following guidelines would be advantageous:
* Use a templating engine for client-side HTML rendering
* Write well-structured semantic HTML5 and use CSS3 where it makes sense

You're allowed to keep a static copy of the data feed in your solution to avoid cross-domain issues. Upload your solution to somewhere of your choice and send us a link.

### News feeds
* XML:  http://www.dr.dk/nyheder/service/feeds/allenyheder
* JSON: http://www.dr.dk/php/drmu/mobildrdk/leproxy2.php?f=news
