#WebAPI_Route_REST_Test

#Testing ASP.NET Web.API REST Service Endpoints and HTTP Methods Using Visual Studio Test Manager 

##Introduction
Microsoft ASP.NET Web API is a framework that makes it easy to build HTTP services that reach a broad range of clients, including browsers and mobile devices. ASP.NET Web API is an ideal platform for building RESTful applications on the .NET Framework. 

This blog briefly discusses how to create automated tests for the ASP.NET Web APIs. Visual Studio has a great framework for testing Web APIs and we will cover it in this blog.

When writing tests for your ASP.NET Web.API REST service, it can be beneficial to separate your tests into two types: Unit Tests and Route Tests. 

Typically, Unit Tests will test method signatures, functionality, return types, etc.; however, Route Tests can test route accuracy and HTTP method compliance.  In this article, we will be demonstrating how to create Route Tests for your ASP.NET Web.API REST service using the Visual Studio Test Manager.

##Challenge
Although REST service URIs should never change, it can happen.  New development, maintenance, or refactoring could cause a URI to change and you need to be aware when this happens.  Also, if you are trying to POST to a PUT endpoint, this could cause issues.  Route Tests mitigate these problems, and they are simple to write.

##Solution
Please download code from this GitHub repository and load “Inventory.WebAPI.sln” in Visual Studio.

## Conclusion
Visual Studio has come a long way and has evolved tremendously over the years. The web platforms and frameworks have continually been changing and will continue to change and evolve. Sometimes it is frustrating for organizations and developers to constantly change and new platforms and frameworks. A pattern that has helped many development teams become successful in maintaining a solid testing framework has been to keep a testing architecture which is simple and easy to maintain. We hope this blog has provided you with a simple-to-implement Web API testing framework. We have provided a copy of this solution on GitHub <LINK to GitHub>.

Best Regards,

Steve Yerkes, Arman Gharib

Steve: https://www.linkedin.com/in/syerkes?trk=prof-samename-name
Arman: https://www.linkedin.com/in/arman-gharib-b10a0515

