using Google.Protobuf.Enum;
using Google.Protobuf.WebProtocol;
using Microsoft.AspNetCore.Mvc;

namespace WebServer;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    [HttpGet]
    [Route("login")]
    public LoginAccountRes LoginAccount(LoginAccountReq id)
    {
        // TODO : ���� DB�� ���� ���¿��� ������ OK�� ������.
        return new LoginAccountRes
        {
            Result = (int)ErrorType.Success
        };
    }
}
