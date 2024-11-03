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
    public LoginAccountRes LoginAccount(LoginAccountReq req)
    {
        // TODO : ���� DB�� ���� ���¿��� ������ OK�� ������.
        // TODO : ���߿� DB �����ϸ鼭 ������ �����ؾ� �Ѵ�.
        // TODO : �α��� ������ �������� �ʴ��� ������ �����ϰ� OK ��Ŷ�� �������� ó���Ѵ�.
        return new LoginAccountRes
        {
            Result = (int)ErrorType.Success
        };
    }
}
