using MyRequest = TakeCare.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<TakeCare.Administration.UserRow>;
using MyRow = TakeCare.Administration.UserRow;

namespace TakeCare.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}