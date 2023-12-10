using Demo2.UserModels;

namespace Demo2.WorkerService
{
    public class GreetingService : BackgroundService
    {
        private readonly ILogger<GreetingService> _logger;

        public GreetingService(ILogger<GreetingService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            UserService userService = new();
            while (!cancellationToken.IsCancellationRequested)
            {
                foreach (User user in userService.GetUsers())
                {
                    MailService mail = new();
                    mail.SendMail(user);
                    Console.WriteLine("This is a background running service" + user.Name);
                }
                // _logger.LogInformation("Worker sercice running at : {time}", DateTimeOffset.Now);
                await Task.Delay(2000, cancellationToken);
            }
        }
    }
}