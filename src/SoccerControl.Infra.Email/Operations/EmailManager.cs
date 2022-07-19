using SoccerControl.Domain.Adapters;

namespace SoccerControl.Infra.Email.Operations
{
    public class EmailManager : IEmailAdapter
    {
        public Task SendEmail(string from, string to, string subject, string body)
        {
            throw new NotImplementedException();
        }
    }
}
