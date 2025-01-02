namespace mcinv.SubCommands
{
  public interface ISubCommand
  {
    public string Name { get; }
    public void Invoke();
  }
}
