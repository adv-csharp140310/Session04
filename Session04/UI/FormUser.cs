using session04.Model;
using session04.Service;
using session04.Utils;

namespace Session04.UI;
public partial class FormUser : Form
{
    public FormUser()
    {
        InitializeComponent();
    }

    private void FormUser_Load(object sender, EventArgs e)
    {
        groupBoxUser.DesignForm(typeof(User));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var user = (User)groupBoxUser.GetFormData(typeof(User));
        var service = new UserService();
        service.Create(user);
        MessageBox.Show("Success 🎉🎉");
    }
}
