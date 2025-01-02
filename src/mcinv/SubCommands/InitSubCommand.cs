namespace mcinv.SubCommands
{
  public class InitSubCommand : ISubCommand
  {
    public string Name {
      get {
        return "init";
      }
    }

    public void Invoke()
    {
      throw new NotImplementedException();
    }
  }
}
