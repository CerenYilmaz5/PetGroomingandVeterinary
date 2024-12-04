namespace PetGroomingandVeterinary
{
    partial class WorkSpace
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
            customerButton = new Button();
            appointmentButton = new Button();
            paymentButton = new Button();
            SuspendLayout();
            // 
            // customerButton
            // 
            customerButton.Location = new Point(275, 75);
            customerButton.Name = "customerButton";
            customerButton.Size = new Size(217, 86);
            customerButton.TabIndex = 0;
            customerButton.Text = "Customers";
            customerButton.UseVisualStyleBackColor = true;
            customerButton.Click += customerButton_Click;
            // 
            // appointmentButton
            // 
            appointmentButton.Location = new Point(275, 179);
            appointmentButton.Name = "appointmentButton";
            appointmentButton.Size = new Size(217, 86);
            appointmentButton.TabIndex = 1;
            appointmentButton.Text = "Appointments";
            appointmentButton.UseVisualStyleBackColor = true;
            // 
            // paymentButton
            // 
            paymentButton.Location = new Point(275, 282);
            paymentButton.Name = "paymentButton";
            paymentButton.Size = new Size(217, 86);
            paymentButton.TabIndex = 2;
            paymentButton.Text = "Payment";
            paymentButton.UseVisualStyleBackColor = true;
            // 
            // WorkSpace
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 483);
            Controls.Add(paymentButton);
            Controls.Add(appointmentButton);
            Controls.Add(customerButton);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "WorkSpace";
            Text = "WorkSpace";
            ResumeLayout(false);
        }

        #endregion

        private Button customerButton;
        private Button appointmentButton;
        private Button paymentButton;
    }
}