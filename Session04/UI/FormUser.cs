using session04.Model;
using session04.Service;
using session04.Utils;

namespace Session04.UI;
public partial class FormUser : Form
{
    UserService userService = new UserService();

    public FormUser()
    {
        InitializeComponent();
    }

    private void FormUser_Load(object sender, EventArgs e)
    {
        groupBoxUser.DesignForm(typeof(User));
        reload();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var user = (User)groupBoxUser.GetFormData(typeof(User));
        if(user.ID > 0)
        {
            userService.Update(user);
        }
        else
        {
            userService.Create(user);
        }
        reload();
        groupBoxUser.SetFormData(new User { });
        MessageBox.Show("Success 🎉🎉");
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        reload();
    }

    private void reload()
    {
        dataGridViewUsers.DataSource = userService.Read();
    }

    private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var id = Convert.ToInt32(dataGridViewUsers.Rows[e.RowIndex].Cells["ColumnId"].Value);
        if (dataGridViewUsers.CurrentCell.OwningColumn.Name == "ColumnDelete")
        {
            if (MessageBox.Show("مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                userService.Delete(id);
                reload();
                MessageBox.Show("Done");
            }
        }

        if (dataGridViewUsers.CurrentCell.OwningColumn.Name == "ColumnEdit")
        {
            groupBoxUser.SetFormData(userService.GetById(id));
        }
    }
}
