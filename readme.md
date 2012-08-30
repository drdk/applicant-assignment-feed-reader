**September 2012, optional applicant demo application**

The purpose of this repository is to create the basis for an assignment you as an applicant to a job at DR can complete in order to showcase your abilities as a software developer.

This assignment is not meant to take more than 2 hours to complete, but feel free to spend as much time as you feel is necessary to showcase your talents. *Also remember that this is not mandetory. If you've got some other code you would rather show us then simply send us a link to that instead. This is meant for you if you don't have an active show case.*

The assignment is a simple Rss Feed Reader that displays the current news from dr.dk (http://www.dr.dk/nyheder/service/feeds/allenyheder) in a reasonable design. The assignment has to be based on the code in the git repository you're currently browsing.

Feel free to simply fork it on github and commit your final solution there. Just send us the link to your fork. Alternatively you can simply download the repository as a zip file. We, however, prefer that you use git, since we use that as well.

There are no limitations to how you solve this, but observing the following guide lines would be advantageous:
* Use Inversion of Control to create the appropriate seperation of concerns. We use StructureMap and AutoMapper.
* Use HTML5 and CSS3 sementics when creating the UI
* Ensure that the application is URL Independant (e.g. use Url.Content and Url.Action when possible).

The solution already comes with a simple repository for reading DR's RSS Feed, and StructureMap is pre-wired into the DR.FeedReader.Web application. You're free to use these or write your own.