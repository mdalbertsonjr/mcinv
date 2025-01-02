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
          new InitSubCommand()
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
  }
}
