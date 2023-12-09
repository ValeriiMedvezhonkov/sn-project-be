using Microsoft.AspNetCore.Mvc;

namespace sn_project_be.Controllers;

public class BaseController: ControllerBase
{
    // returns the current authenticated UserId (null if not logged in)
    public string? CurrentUserId => (string)HttpContext.Items["UserId"];
}