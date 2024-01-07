using MyRequest = Serenity.Services.SaveRequest<TakeCare.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = TakeCare.Administration.LanguageRow;


namespace TakeCare.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}