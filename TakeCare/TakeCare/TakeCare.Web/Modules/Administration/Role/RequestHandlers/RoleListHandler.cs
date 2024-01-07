﻿using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<TakeCare.Administration.RoleRow>;
using MyRow = TakeCare.Administration.RoleRow;


namespace TakeCare.Administration;
public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
{
    public RoleListHandler(IRequestContext context)
         : base(context)
    {
    }
}