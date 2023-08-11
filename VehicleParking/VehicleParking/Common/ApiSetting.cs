using Microsoft.Extensions.Configuration;

namespace VehicleParking.Common
{
    public class ApiSetting : IApiSetting
    {
        readonly IConfiguration _configuration;
        public ApiSetting(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string SqlConnectionString
        {
            get
            {
              return _configuration["ConnectionStrings:DataBase"];
            }
        }
    }
}
