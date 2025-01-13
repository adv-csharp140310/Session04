namespace Session04.UI;

partial class FormUser
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
        groupBoxUser = new GroupBox();
        buttonSave = new Button();
        dataGridViewUsers = new DataGridView();
        buttonRefresh = new Button();
        groupBoxUser.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
        SuspendLayout();
        // 
        // groupBoxUser
        // 
        groupBoxUser.Controls.Add(buttonSave);
        groupBoxUser.Location = new Point(12, 12);
        groupBoxUser.Name = "groupBoxUser";
        groupBoxUser.Size = new Size(605, 230);
        groupBoxUser.TabIndex = 0;
        groupBoxUser.TabStop = false;
        groupBoxUser.Text = "User";
        // 
        // buttonSave
        // 
        buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        buttonSave.Location = new Point(524, 201);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(75, 23);
        buttonSave.TabIndex = 0;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // dataGridViewUsers
        // 
        dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewUsers.Location = new Point(12, 248);
        dataGridViewUsers.Name = "dataGridViewUsers";
        dataGridViewUsers.Size = new Size(765, 328);
        dataGridViewUsers.TabIndex = 1;
        // 
        // buttonRefresh
        // 
        buttonRefresh.Location = new Point(702, 213);
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Size = new Size(75, 23);
        buttonRefresh.TabIndex = 2;
        buttonRefresh.Text = "Refresh";
        buttonRefresh.UseVisualStyleBackColor = true;
        buttonRefresh.Click += buttonRefresh_Click;
        // 
        // FormUser
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(789, 588);
        Controls.Add(buttonRefresh);
        Controls.Add(dataGridViewUsers);
        Controls.Add(groupBoxUser);
        Name = "FormUser";
        Text = "FormUser";
        Load += FormUser_Load;
        groupBoxUser.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBoxUser;
    private Button buttonSave;
    private DataGridView dataGridViewUsers;
    private Button buttonRefresh;
}