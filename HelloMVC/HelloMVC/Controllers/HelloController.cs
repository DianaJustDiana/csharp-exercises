using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        //added (string name) after Index so it will accept a name given in the query string
        // after string name, the '= "World" sets "World" as the default name in case the user doesn't enter a name
        //default name here takes the place of the if block noted out below
        //public IActionResult Index(string name = "World")

        //this method responds to get requests
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form action='/hello' method='post' >" +
                "<input type='text' name='name' />" +
                "<select type='text' name='language'>" +
                "<option value='English' selected>English</option>" +
                "<option value='Florida'>Florida</option>" +
                "<option value='French'>French</option>" +
                "<option value='Pig Latin'>Pig Latin</option>" +
                "<option value='Spanish'>Spanish</option>" +
                "</select>" +
                "<input type='submit' value='Greet me!' />" +
                "</form>";
            //return Redirect("/Hello/Goodbye");
            return Content(CreateMessage(html), "text/html");

            //return Content("<h1>Hello, World</h1>", "text/html");

            //checks query string and offers default in case there is no name
            //if (string.IsNullOrEmpty(name))
            //{
            //    name = "World";
            //}
            //in Content this is Hello, name from query string, parameter that displays the HTML properly
            //return Content(string.Format("<h1>Hello, {0}</h1>", name), "text/html");
        }
        public static string CreateMessage(string value)
        {
            string message = "";
            if (value.Equals("English") )
            {
                message = "Hello";
            }
            else if (value.Equals("Florida") )
            {
                message = "Hey, y'all";
            }
            else if (value.Equals("French") )
            {
                message = "Bonjour";   
            }
            else if (value.Equals("Pig Latin") )
            {
                message = "Ellohay";
            }
            else if (value.Equals("Spanish") )
            {
                message = "Hola";
            }
            return message;
        }

        // to get form data posted to this url to display at same url:
        // to get post requests to /hello to end up at this controller:
        //add route attribute
        //Hello
        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language)
        {
            return Content(string.Format("<h1>{0}, {1}</h1>", language, name), "text/html");
        }

        //handle requests to/Hello/namegoeshere (URL segment)
        [Route("/Hello/{name}")]
        public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello, {0}</h1>", name), "text/html");
        }




        //Hello/Goodbye
        //alter the route to this controller to be /Hello/Aloha
        //add [Route("/newroute/path"]
        //now /hello/goodbye won't work any longer
        //[Route("/Hello/Aloha")]
        public IActionResult Goodbye()
        {
            return Content("Goodbye"); 
;        }
    }
}
