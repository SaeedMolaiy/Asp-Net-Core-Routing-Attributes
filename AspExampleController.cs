using Microsoft.AspNetCore.Mvc;

namespace AspRoutingAttributes.Controllers;

public class AspExampleController : Controller
{
    [HttpGet, HttpPost, HttpPut, HttpDelete]
    public IActionResult Crud()
    {
        return Ok();
    }

    [AcceptVerbs("GET", "POST")]
    public IActionResult Verbs()
    {
        return Ok();
    }

    [Route("api/[controller]")]
    public IActionResult Route()
    {
        return Ok();
    }

    [HttpGet("/Get/{id:int}")]
    public IActionResult Index(int id)
    {
        return Ok(id);
    }

    [HttpGet("/Get/{token:length(20)}")]
    public IActionResult GetTokeN(string token)
    {
        return Ok(token);
    }

    [HttpGet(@"/Get/{token:regex(^\d{{3}})}-\d{{2}}-\d{{4}}$)}")]
    public IActionResult ValidateToken(string token)
    {
        return Ok(token);
    }

    [HttpGet(@"/Get/{name:minlength(3):maxlength(20)}")]
    public IActionResult GetUserNameBtName(string name)
    {
        return Ok(name);
    }

    [HttpGet(@"/Get/{text:alpha}")]
    public IActionResult Alpha(string text)
    {
        return Ok(text);
    }
}