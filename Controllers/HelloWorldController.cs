using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
  public class HelloWorldController
  {
    public string Index()
    {
      return "This is my default action...";
    }

    public string Welcome(string name, int numTimes = 1)
    {
      return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
  }
}