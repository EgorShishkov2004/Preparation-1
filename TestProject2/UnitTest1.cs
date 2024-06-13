using Preparation__1;
using Preparation__1.Forms;

[TestFixture]
public class Form_AuthorizationTests
{
    private Form_Authorization _form;
    private Mock<DB> _dbMock;

    [SetUp]
    public void Setup()
    {
        _dbMock = new Mock<DB>();
        _form = new Form_Authorization(_dbMock.Object);
    }

    [Test]
    public void Button_SignIn_Click_ValidUser_AdministratorRole_OpenOrderForm()
    {
        // Arrange
        var user = new User
        {
            Login = "admin",
            Password = "password",
            Role = new Role { Name = "Администратор" }
        };

        _dbMock.Setup(db => db.Users.Include(x => x.Role)
            .Where(x => x.Login == "admin" && x.Password == "password"))
            .Returns(new[] { user }.AsQueryable());

        // Act
        _form.textBox_Login.Text = "admin";
        _form.textBox_Password.Text = "password";
        _form.button_SignIn_Click(null, null);

        // Assert
        _dbMock.Verify(db => db.Users.Include(x => x.Role)
            .Where(x => x.Login == "admin" && x.Password == "password"), Times.Once);
        Assert.IsTrue(_form.Visible == false);
        Assert.IsTrue(_form.Owner is Form_Order);
    }
}
