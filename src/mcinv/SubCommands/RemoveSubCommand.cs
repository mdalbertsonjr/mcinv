namespace mcinv.SubCommands
{
  public class RemoveSubCommand : ISubCommand
  {
    public string Name {
      get {
        return "rm";
      }
    }

    public void Invoke()
    {
      throw new NotImplementedException();
    }
  }
}
