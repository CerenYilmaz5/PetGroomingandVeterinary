namespace PetGroomingandVeterinary
{
    partial class Customer
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
            customerNameLabel = new Label();
            phoneNumberLabel = new Label();
            emailLabel = new Label();
            addressLabel = new Label();
            customerNameTextbox = new TextBox();
            phoneNumberTextbox = new TextBox();
            emailTextbox = new TextBox();
            addressTextbox = new TextBox();
            addButton = new Button();
            customerDataGridView = new DataGridView();
            updateButton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(53, 29);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(241, 41);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Customer Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(67, 85);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(227, 41);
            phoneNumberLabel.TabIndex = 1;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(186, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(108, 41);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-Mail:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(162, 192);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(132, 41);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // customerNameTextbox
            // 
            customerNameTextbox.Location = new Point(300, 29);
            customerNameTextbox.Name = "customerNameTextbox";
            customerNameTextbox.Size = new Size(616, 47);
            customerNameTextbox.TabIndex = 4;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.Location = new Point(300, 82);
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.Size = new Size(616, 47);
            phoneNumberTextbox.TabIndex = 5;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(300, 135);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(616, 47);
            emailTextbox.TabIndex = 6;
            // 
            // addressTextbox
            // 
            addressTextbox.Location = new Point(300, 192);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(616, 47);
            addressTextbox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(644, 245);
            addButton.Name = "addButton";
            addButton.Size = new Size(186, 47);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // customerDataGridView
            // 
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(33, 302);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.Size = new Size(989, 342);
            customerDataGridView.TabIndex = 10;
            customerDataGridView.CellContentClick += customerDataGridView_CellContentClick;
            // 
            // updateButton1
            // 
            updateButton1.Location = new Point(836, 245);
            updateButton1.Name = "updateButton1";
            updateButton1.Size = new Size(186, 47);
            updateButton1.TabIndex = 11;
            updateButton1.Text = "Update";
            updateButton1.UseVisualStyleBackColor = true;
            updateButton1.Click += updateButton_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 676);
            Controls.Add(updateButton1);
            Controls.Add(customerDataGridView);
            Controls.Add(addButton);
            Controls.Add(addressTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(phoneNumberTextbox);
            Controls.Add(customerNameTextbox);
            Controls.Add(addressLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(customerNameLabel);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerNameLabel;
        private Label phoneNumberLabel;
        private Label emailLabel;
        private Label addressLabel;
        private TextBox customerNameTextbox;
        private TextBox phoneNumberTextbox;
        private TextBox emailTextbox;
        private TextBox addressTextbox;
        private Button addButton;
        private DataGridView customerDataGridView;
        private Button updateButton1;
    }
}