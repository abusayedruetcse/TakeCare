using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<TakeCare.Administration.LanguageRow>;
using MyRow = TakeCare.Administration.LanguageRow;


namespace TakeCare.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}