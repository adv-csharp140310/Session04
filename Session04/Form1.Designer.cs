namespace Session04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonUsers = new Button();
            buttonProducts = new Button();
            buttonLambda = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // buttonUsers
            // 
            buttonUsers.Location = new Point(12, 12);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(176, 23);
            buttonUsers.TabIndex = 0;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(12, 41);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(176, 23);
            buttonProducts.TabIndex = 1;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonLambda
            // 
            buttonLambda.Location = new Point(230, 12);
            buttonLambda.Name = "buttonLambda";
            buttonLambda.Size = new Size(124, 23);
            buttonLambda.TabIndex = 2;
            buttonLambda.Text = "Lambda";
            buttonLambda.UseVisualStyleBackColor = true;
            buttonLambda.Click += buttonLambda_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(381, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(174, 349);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 384);
            Controls.Add(listBox1);
            Controls.Add(buttonLambda);
            Controls.Add(buttonProducts);
            Controls.Add(buttonUsers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonUsers;
        private Button buttonProducts;
        private Button buttonLambda;
        private ListBox listBox1;
    }
}
