using Microsoft.VisualBasic;
using System.Threading.Channels;

namespace AMSEROIL.Service
{
    public interface IMessageChannel
    {
        IAsyncEnumerable<SMSNotification> ReadAllAsync();
        ValueTask WriteAsync(SMSNotification request);
    }

    public class MessageChannel : IMessageChannel
    {
        private readonly Channel<SMSNotification> Requests = Channel.CreateUnbounded<SMSNotification>();

        public async ValueTask WriteAsync(SMSNotification request)
        {
            await Requests.Writer.WriteAsync(request);
        }

        public IAsyncEnumerable<SMSNotification> ReadAllAsync()
        {
            return Requests.Reader.ReadAllAsync();
        }
    }
}
