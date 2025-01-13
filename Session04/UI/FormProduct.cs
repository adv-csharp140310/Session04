using session04.Model;
using session04.Service;
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
    ProductService productService = new ProductService();
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
        dataGridViewProducts.DataSource = productService.Read();
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var product = (Product)groupBoxProduct.GetFormData(typeof(Product));
        if (product.ID > 0)
        {
            productService.Update(product);
        }
        else
        {
            productService.Create(product);
        }
        reload();
        groupBoxProduct.SetFormData(new Product { });
        MessageBox.Show("Success 🎉🎉");
    }

    private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var id = Convert.ToInt32(dataGridViewProducts.Rows[e.RowIndex].Cells["Id"].Value);
        if (dataGridViewProducts.CurrentCell.OwningColumn.Name == "ColumnDelete")
        {
            if (MessageBox.Show("مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                productService.Delete(id);
                reload();
                MessageBox.Show("Done");
            }
        }

        if (dataGridViewProducts.CurrentCell.OwningColumn.Name == "ColumnEdit")
        {
            groupBoxProduct.SetFormData(productService.GetById(id));
        }
    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
        reload();
    }
}
