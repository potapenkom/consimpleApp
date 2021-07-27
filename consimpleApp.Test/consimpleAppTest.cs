using System.Threading.Tasks;
using consimpleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace consimpleApp.Test
{
    public class consimpleAppTest
    {
        [Fact]
        public async Task Get_All_Todos()
        {
            var services = new ServiceCollection();
            services.UseServices();
            var serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetRequiredService<IRootobjectService>();

            var tasks = await service.GetAllAsync();
            Assert.NotNull(tasks);
           
        }
    }
}
