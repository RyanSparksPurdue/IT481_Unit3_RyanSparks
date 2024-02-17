namespace IT481_Unit_2_Assign
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
            this.btnGetEntryCount = new System.Windows.Forms.Button();
            this.btnShowCustomerTable = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtRecordCount = new System.Windows.Forms.Button();
            this.radioCustomers = new System.Windows.Forms.RadioButton();
            this.radioOrders = new System.Windows.Forms.RadioButton();
            this.radioEmployees = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetEntryCount
            // 
            this.btnGetEntryCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGetEntryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetEntryCount.ForeColor = System.Drawing.Color.Purple;
            this.btnGetEntryCount.Location = new System.Drawing.Point(439, 148);
            this.btnGetEntryCount.Name = "btnGetEntryCount";
            this.btnGetEntryCount.Size = new System.Drawing.Size(296, 229);
            this.btnGetEntryCount.TabIndex = 0;
            this.btnGetEntryCount.Text = "Show Record Count";
            this.btnGetEntryCount.UseVisualStyleBackColor = false;
            this.btnGetEntryCount.Click += new System.EventHandler(this.btnGetEntryCount_Click);
            // 
            // btnShowCustomerTable
            // 
            this.btnShowCustomerTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShowCustomerTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomerTable.ForeColor = System.Drawing.Color.Purple;
            this.btnShowCustomerTable.Location = new System.Drawing.Point(93, 148);
            this.btnShowCustomerTable.Name = "btnShowCustomerTable";
            this.btnShowCustomerTable.Size = new System.Drawing.Size(296, 229);
            this.btnShowCustomerTable.TabIndex = 1;
            this.btnShowCustomerTable.Text = "View Database";
            this.btnShowCustomerTable.UseVisualStyleBackColor = false;
            this.btnShowCustomerTable.Click += new System.EventHandler(this.btnShowCustomerTable_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(93, 65);
            this.lblTitle.Multiline = true;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(969, 63);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Welcome to Northwind Database";
            this.lblTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(969, 334);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordCount.ForeColor = System.Drawing.Color.Purple;
            this.txtRecordCount.Location = new System.Drawing.Point(766, 148);
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(296, 229);
            this.txtRecordCount.TabIndex = 4;
            this.txtRecordCount.Text = "Thinking...";
            this.txtRecordCount.UseVisualStyleBackColor = false;
            // 
            // radioCustomers
            // 
            this.radioCustomers.AutoSize = true;
            this.radioCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCustomers.Location = new System.Drawing.Point(113, 427);
            this.radioCustomers.Name = "radioCustomers";
            this.radioCustomers.Size = new System.Drawing.Size(147, 33);
            this.radioCustomers.TabIndex = 5;
            this.radioCustomers.TabStop = true;
            this.radioCustomers.Text = "Customers";
            this.radioCustomers.UseVisualStyleBackColor = true;
            this.radioCustomers.CheckedChanged += new System.EventHandler(this.radioCustomers_CheckedChanged);
            // 
            // radioOrders
            // 
            this.radioOrders.AutoSize = true;
            this.radioOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOrders.Location = new System.Drawing.Point(499, 427);
            this.radioOrders.Name = "radioOrders";
            this.radioOrders.Size = new System.Drawing.Size(106, 33);
            this.radioOrders.TabIndex = 6;
            this.radioOrders.TabStop = true;
            this.radioOrders.Text = "Orders";
            this.radioOrders.UseVisualStyleBackColor = true;
            this.radioOrders.CheckedChanged += new System.EventHandler(this.radioOrders_CheckedChanged);
            // 
            // radioEmployees
            // 
            this.radioEmployees.AutoSize = true;
            this.radioEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmployees.Location = new System.Drawing.Point(826, 427);
            this.radioEmployees.Name = "radioEmployees";
            this.radioEmployees.Size = new System.Drawing.Size(152, 33);
            this.radioEmployees.TabIndex = 7;
            this.radioEmployees.TabStop = true;
            this.radioEmployees.Text = "Employees";
            this.radioEmployees.UseVisualStyleBackColor = true;
            this.radioEmployees.CheckedChanged += new System.EventHandler(this.radioEmployees_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1105, 871);
            this.Controls.Add(this.radioEmployees);
            this.Controls.Add(this.radioOrders);
            this.Controls.Add(this.radioCustomers);
            this.Controls.Add(this.txtRecordCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShowCustomerTable);
            this.Controls.Add(this.btnGetEntryCount);
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetEntryCount;
        private System.Windows.Forms.Button btnShowCustomerTable;
        private System.Windows.Forms.TextBox lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtRecordCount;
        private System.Windows.Forms.RadioButton radioCustomers;
        private System.Windows.Forms.RadioButton radioOrders;
        private System.Windows.Forms.RadioButton radioEmployees;
    }
}