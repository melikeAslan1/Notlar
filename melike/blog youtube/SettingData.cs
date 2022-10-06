namespace YoutubeDersleri.Data
{
    using Microsoft.Extensions.Options;
    using YoutubeDersleri.Data.Infrastructure;
    using YoutubeDersleri.Data.Infrastructure.Entities;

    public class SettingData : EntityBaseData<Model.Setting>
    {
        public SettingData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
