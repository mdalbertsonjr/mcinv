using mcinv.SubCommands;

namespace mcinv
{
  public class CommandLineArgParser
  {
    private readonly ISubCommand[] subCommands;

    public CommandLineArgParser(
        ISubCommand[] subCommands
        )
    {
      this.subCommands = subCommands;
    }

    public ISubCommand Parse(string[] args)
    {
      foreach(var subCommand in subCommands){
        if (args.Length >= 1) {
          if (args[0] == subCommand.Name) {
            return subCommand;
          }
        }
      }

      throw new NotImplementedException();
    }
  }
}
