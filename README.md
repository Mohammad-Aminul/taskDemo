First the Application_Start() method of MvcApplication class in Global.aspx.cs file
In Application_Start() to  Registers all areas in an ASP.NET MVC application call method "RegisterAllAreas()"
Then call RegisterRoutes() method in "RouteConfig" class and send all the routes as parameter.
This RegisterRoutes() method maps the specified URL route and sets default route values.
