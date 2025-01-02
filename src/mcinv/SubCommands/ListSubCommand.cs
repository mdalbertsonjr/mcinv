namespace mcinv.SubCommands
{
  public class ListSubCommand : ISubCommand
  {
    public string Name {
      get {
        return "list";
      }
    }

    public void Invoke()
    {
      throw new NotImplementedException();
    }
  }
}
