namespace YoutubeDersleri.Data
{
    using Microsoft.Extensions.Options;
    using YoutubeDersleri.Data.Infrastructure;
    using YoutubeDersleri.Data.Infrastructure.Entities;

    public class AuthorData : EntityBaseData<Model.Author>
    {
        public AuthorData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
