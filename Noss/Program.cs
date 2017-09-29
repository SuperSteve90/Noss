using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace Noss
{
    public class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            _client = new DiscordSocketClient();

            await _client.LoginAsync(TokenType.Bot, "MzYzMTI4NjY3NTYxMjYzMTA1.DK8tmQ.bfA47p-pnEz2mYq2q_iK2RXcEZ0");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}
