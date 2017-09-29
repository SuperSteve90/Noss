using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace Super_Bot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task test()
        {
            await Context.Channel.SendMessageAsync("Testing!");
        }
    }
}