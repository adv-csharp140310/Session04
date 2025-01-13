namespace Session04.UI;

partial class FormProduct
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBoxProduct = new GroupBox();
        buttonSave = new Button();
        buttonRefresh = new Button();
        dataGridViewProducts = new DataGridView();
        ColumnEdit = new DataGridViewButtonColumn();
        ColumnDelete = new DataGridViewButtonColumn();
        groupBoxProduct.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        SuspendLayout();
        // 
        // groupBoxProduct
        // 
        groupBoxProduct.Controls.Add(buttonRefresh);
        groupBoxProduct.Controls.Add(buttonSave);
        groupBoxProduct.Location = new Point(12, 12);
        groupBoxProduct.Name = "groupBoxProduct";
        groupBoxProduct.Size = new Size(776, 241);
        groupBoxProduct.TabIndex = 0;
        groupBoxProduct.TabStop = false;
        groupBoxProduct.Text = "Product";
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(695, 183);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 0;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        // 
        // buttonRefresh
        // 
        buttonRefresh.Location = new Point(695, 212);
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Size = new Size(75, 23);
        buttonRefresh.TabIndex = 1;
        buttonRefresh.Text = "Refresh";
        buttonRefresh.UseVisualStyleBackColor = true;
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { ColumnEdit, ColumnDelete });
        dataGridViewProducts.Location = new Point(12, 259);
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.Size = new Size(776, 245);
        dataGridViewProducts.TabIndex = 1;
        // 
        // ColumnEdit
        // 
        ColumnEdit.HeaderText = "ویرایش";
        ColumnEdit.Name = "ColumnEdit";
        ColumnEdit.ReadOnly = true;
        ColumnEdit.Text = "ویرایش";
        ColumnEdit.UseColumnTextForButtonValue = true;
        // 
        // ColumnDelete
        // 
        ColumnDelete.HeaderText = "حذف";
        ColumnDelete.Name = "ColumnDelete";
        ColumnDelete.ReadOnly = true;
        ColumnDelete.Text = "حذف";
        ColumnDelete.UseColumnTextForButtonValue = true;
        // 
        // FormProduct
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 516);
        Controls.Add(dataGridViewProducts);
        Controls.Add(groupBoxProduct);
        Name = "FormProduct";
        Text = "FormProduct";
        Load += FormProduct_Load;
        groupBoxProduct.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxProduct;
    private Button buttonRefresh;
    private Button buttonSave;
    private DataGridView dataGridViewProducts;
    private DataGridViewButtonColumn ColumnEdit;
    private DataGridViewButtonColumn ColumnDelete;
}