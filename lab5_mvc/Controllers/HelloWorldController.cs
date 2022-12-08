
using Microsoft.AspNetCore.Mvc;

namespace lab5_mvc.Controllers;
public class HelloWorldController : Controller
{
    public string Index()
    {
        return "Index是預設的, 會採用Controller的名字";
    }
    public string Welcome()
    {
        return "會接在後面的Welcome";
    }
}