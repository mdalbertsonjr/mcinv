using mcinv;
using mcinv.SubCommands;

namespace mcinv.tests
{
  [TestClass]
  public class CommandLineArgParserTests
  {

    private CommandLineArgParser sut;

    public CommandLineArgParserTests()
    {
      sut = new CommandLineArgParser(new ISubCommand[] {
          new AddSubCommand(),
          new ChangesSubCommand(),
          new InitSubCommand(),
          new ListSubCommand(),
          new RemoveSubCommand(),
          });
    }

    [TestMethod]
    public void Parse_init_AllDefaultArgs()
    {
      // Arrange
      var args = new string[] {
        "init"
      };

      // Act
      var result = sut.Parse(args);

      // Assert
      Assert.IsNotNull(result);
    }
    [TestMethod]
    public void Parse_add_AllDefaultArgs()
    {
      // Arrange
      var args = new string[] {
        "add"
      };

      // Act
      var result = sut.Parse(args);

      // Assert
      Assert.IsNotNull(result);
    }
    [TestMethod]
    public void Parse_rm_AllDefaultArgs()
    {
      // Arrange
      var args = new string[] {
        "rm"
      };

      // Act
      var result = sut.Parse(args);

      // Assert
      Assert.IsNotNull(result);
    }
    [TestMethod]
    public void Parse_list_AllDefaultArgs()
    {
      // Arrange
      var args = new string[] {
        "list"
      };

      // Act
      var result = sut.Parse(args);

      // Assert
      Assert.IsNotNull(result);
    }
    [TestMethod]
    public void Parse_changes_AllDefaultArgs()
    {
      // Arrange
      var args = new string[] {
        "changes"
      };

      // Act
      var result = sut.Parse(args);

      // Assert
      Assert.IsNotNull(result);
    }
  }
}
