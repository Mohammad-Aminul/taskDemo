1. First the Application_Start() method of MvcApplication class in Global.aspx.cs file
2. In Application_Start() to  Registers all areas in an ASP.NET MVC application call method "RegisterAllAreas()"
3. Then call RegisterRoutes() method in "RouteConfig" class and send all the routes as parameter.
4. This RegisterRoutes() method maps the specified URL route and sets default route values.
