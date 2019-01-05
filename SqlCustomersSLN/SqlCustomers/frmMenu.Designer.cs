namespace SqlCustomers
{
    partial class frmMenu
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
            this.btnViewAudit = new System.Windows.Forms.Button();
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.btnUpdateDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewAudit
            // 
            this.btnViewAudit.Location = new System.Drawing.Point(26, 22);
            this.btnViewAudit.Name = "btnViewAudit";
            this.btnViewAudit.Size = new System.Drawing.Size(242, 23);
            this.btnViewAudit.TabIndex = 0;
            this.btnViewAudit.Text = "View Audit Data";
            this.btnViewAudit.UseVisualStyleBackColor = true;
            this.btnViewAudit.Click += new System.EventHandler(this.btnViewAudit_Click);
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(26, 74);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(242, 23);
            this.btnAddCustomers.TabIndex = 1;
            this.btnAddCustomers.Text = "Add Customers";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // btnUpdateDelete
            // 
            this.btnUpdateDelete.Location = new System.Drawing.Point(26, 126);
            this.btnUpdateDelete.Name = "btnUpdateDelete";
            this.btnUpdateDelete.Size = new System.Drawing.Size(242, 23);
            this.btnUpdateDelete.TabIndex = 2;
            this.btnUpdateDelete.Text = "Update or Delete Customers";
            this.btnUpdateDelete.UseVisualStyleBackColor = true;
            this.btnUpdateDelete.Click += new System.EventHandler(this.btnUpdateDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(26, 178);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(242, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 231);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateDelete);
            this.Controls.Add(this.btnAddCustomers);
            this.Controls.Add(this.btnViewAudit);
            this.Name = "frmMenu";
            this.Text = "More Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewAudit;
        private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.Button btnUpdateDelete;
        private System.Windows.Forms.Button btnBack;
    }
}