using session04.Model;
using session04.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session04.UI;
public partial class FormProduct : Form
{
    public FormProduct()
    {
        InitializeComponent();
    }

    private void FormProduct_Load(object sender, EventArgs e)
    {
        groupBoxProduct.DesignForm(typeof(Product));
        reload();
    }

    private void reload()
    {
        //
    }
}
