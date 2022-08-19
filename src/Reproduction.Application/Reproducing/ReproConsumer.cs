using MassTransit;
using Microsoft.Extensions.Logging;
using Reproduction.Reproducing.Dto;
using Reproduction.Users;
using System.Threading.Tasks;

namespace Reproduction.Reproducing
{
    public class ReproConsumer : IConsumer<ReproDto>
    {
        private readonly IUserAppService _userAppService;
        private readonly ILogger<ReproConsumer> _logger;
        public ReproConsumer(IUserAppService userAppService, ILogger<ReproConsumer> logger)
        {
            _userAppService = userAppService;
            _logger = logger;
        }
        public async Task Consume(ConsumeContext<ReproDto> context)
        {
            _logger.LogInformation("Receiving code {code}", context.Message.Code);

            await Task.CompletedTask;
        }
    }
}
