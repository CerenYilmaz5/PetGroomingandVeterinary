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
            refreshButton = new Button();
            customerDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new Point(53, 59);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new Size(241, 41);
            customerNameLabel.TabIndex = 0;
            customerNameLabel.Text = "Customer Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(67, 112);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(227, 41);
            phoneNumberLabel.TabIndex = 1;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(186, 167);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(108, 41);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-Mail:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(162, 218);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(132, 41);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // customerNameTextbox
            // 
            customerNameTextbox.Location = new Point(310, 59);
            customerNameTextbox.Name = "customerNameTextbox";
            customerNameTextbox.Size = new Size(261, 47);
            customerNameTextbox.TabIndex = 4;
            // 
            // phoneNumberTextbox
            // 
            phoneNumberTextbox.Location = new Point(310, 112);
            phoneNumberTextbox.Name = "phoneNumberTextbox";
            phoneNumberTextbox.Size = new Size(261, 47);
            phoneNumberTextbox.TabIndex = 5;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(310, 167);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(261, 47);
            emailTextbox.TabIndex = 6;
            // 
            // addressTextbox
            // 
            addressTextbox.Location = new Point(310, 220);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(261, 47);
            addressTextbox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(710, 59);
            addButton.Name = "addButton";
            addButton.Size = new Size(186, 92);
            addButton.TabIndex = 8;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(710, 175);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(186, 92);
            refreshButton.TabIndex = 9;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // customerDataGridView
            // 
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(33, 302);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersWidth = 51;
            customerDataGridView.Size = new Size(989, 342);
            customerDataGridView.TabIndex = 10;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 676);
            Controls.Add(customerDataGridView);
            Controls.Add(refreshButton);
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
        private Button refreshButton;
        private DataGridView customerDataGridView;
    }
}