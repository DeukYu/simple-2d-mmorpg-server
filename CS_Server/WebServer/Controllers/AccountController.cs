using Google.Protobuf.Enum;
using Google.Protobuf.WebProtocol;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebServer.DB;

namespace WebServer;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly AccountDB _account;

    public AccountController(AccountDB context)
    {
        _account = context;
    }

    [HttpPost]
    [Route("login")]
    public async Task<LoginAccountRes> LoginAccount(LoginAccountReq req)
    {
        // TODO : ���� DB�� ���� ���¿��� ������ OK�� ������.
        // TODO : ���߿� DB �����ϸ鼭 ������ �����ؾ� �Ѵ�.
        // TODO : �α��� ������ �������� �ʴ��� ������ �����ϰ� OK ��Ŷ�� �������� ó���Ѵ�.

        var accountInfo = await _account.AccountInfo.FindByAccountNameAsync(req.AccountName);
        if (accountInfo == null)
        {
            // ������ ������ ����
            accountInfo = new AccountInfo
            {
                AccountName = req.AccountName
            };

            await _account.AccountInfo.AddAccountAsync(accountInfo);
            await _account.SaveChangesAsync();
        }


        return new LoginAccountRes
        {
            PlayerId = accountInfo.Id,
            Result = (int)ErrorType.Success
        };
    }
}
