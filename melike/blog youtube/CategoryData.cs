namespace YoutubeDersleri.Data
{
    using Microsoft.Extensions.Options;
    using YoutubeDersleri.Data.Infrastructure;
    using YoutubeDersleri.Data.Infrastructure.Entities;

    public class CategoryData : EntityBaseData<Model.Category>
    {
        public CategoryData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
