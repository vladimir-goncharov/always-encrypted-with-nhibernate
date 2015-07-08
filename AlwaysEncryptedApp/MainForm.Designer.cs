namespace AlwaysEncryptedApp
{
    partial class MainForm
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
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPersonalId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPersonalId = new System.Windows.Forms.TextBox();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLoadByPersonalId = new System.Windows.Forms.TextBox();
            this.lblLoadByPersonalId = new System.Windows.Forms.Label();
            this.btnLoadById = new System.Windows.Forms.Button();
            this.grpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCustomer.Controls.Add(this.btnAdd);
            this.grpCustomer.Controls.Add(this.lblPersonalId);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.txtPersonalId);
            this.grpCustomer.Location = new System.Drawing.Point(12, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(554, 80);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "New Customer";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPersonalId
            // 
            this.lblPersonalId.AutoSize = true;
            this.lblPersonalId.Location = new System.Drawing.Point(6, 48);
            this.lblPersonalId.Name = "lblPersonalId";
            this.lblPersonalId.Size = new System.Drawing.Size(65, 13);
            this.lblPersonalId.TabIndex = 4;
            this.lblPersonalId.Text = "Personal ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Meier";
            // 
            // txtPersonalId
            // 
            this.txtPersonalId.Location = new System.Drawing.Point(82, 45);
            this.txtPersonalId.Name = "txtPersonalId";
            this.txtPersonalId.Size = new System.Drawing.Size(174, 20);
            this.txtPersonalId.TabIndex = 2;
            this.txtPersonalId.Text = "AA123456";
            // 
            // gridCustomers
            // 
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomers.Location = new System.Drawing.Point(12, 98);
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.Size = new System.Drawing.Size(554, 228);
            this.gridCustomers.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(417, 334);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(149, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load all customers";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtLoadByPersonalId
            // 
            this.txtLoadByPersonalId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLoadByPersonalId.Location = new System.Drawing.Point(80, 336);
            this.txtLoadByPersonalId.Name = "txtLoadByPersonalId";
            this.txtLoadByPersonalId.Size = new System.Drawing.Size(141, 20);
            this.txtLoadByPersonalId.TabIndex = 13;
            this.txtLoadByPersonalId.Text = "AA123456";
            // 
            // lblLoadByPersonalId
            // 
            this.lblLoadByPersonalId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoadByPersonalId.AutoSize = true;
            this.lblLoadByPersonalId.Location = new System.Drawing.Point(9, 339);
            this.lblLoadByPersonalId.Name = "lblLoadByPersonalId";
            this.lblLoadByPersonalId.Size = new System.Drawing.Size(65, 13);
            this.lblLoadByPersonalId.TabIndex = 12;
            this.lblLoadByPersonalId.Text = "Personal ID:";
            // 
            // btnLoadById
            // 
            this.btnLoadById.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadById.Location = new System.Drawing.Point(227, 334);
            this.btnLoadById.Name = "btnLoadById";
            this.btnLoadById.Size = new System.Drawing.Size(127, 23);
            this.btnLoadById.TabIndex = 11;
            this.btnLoadById.Text = "Load by ID";
            this.btnLoadById.UseVisualStyleBackColor = true;
            this.btnLoadById.Click += new System.EventHandler(this.btnLoadById_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 364);
            this.Controls.Add(this.txtLoadByPersonalId);
            this.Controls.Add(this.lblLoadByPersonalId);
            this.Controls.Add(this.btnLoadById);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.grpCustomer);
            this.Name = "MainForm";
            this.Text = "Always Encrypted";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPersonalId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPersonalId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtLoadByPersonalId;
        private System.Windows.Forms.Label lblLoadByPersonalId;
        private System.Windows.Forms.Button btnLoadById;
    }
}

