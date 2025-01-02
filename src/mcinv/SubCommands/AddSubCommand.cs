namespace mcinv.SubCommands
{
  public class AddSubCommand : ISubCommand
  {
    public string Name {
      get {
        return "add";
      }
    }

    public void Invoke()
    {
      throw new NotImplementedException();
    }
  }
}
