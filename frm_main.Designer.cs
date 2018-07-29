namespace YNAB_Desktop
{
    partial class frm_Main
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
            this.dgBudgets = new System.Windows.Forms.DataGridView();
            this.b_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_setToken = new System.Windows.Forms.Button();
            this.eb_accessToken = new System.Windows.Forms.TextBox();
            this.lb_accessToken = new System.Windows.Forms.Label();
            this.btn_fetchBudgets = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBudgets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgBudgets
            // 
            this.dgBudgets.AllowUserToAddRows = false;
            this.dgBudgets.AllowUserToDeleteRows = false;
            this.dgBudgets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBudgets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.b_id,
            this.b_name});
            this.dgBudgets.Location = new System.Drawing.Point(28, 90);
            this.dgBudgets.Name = "dgBudgets";
            this.dgBudgets.ReadOnly = true;
            this.dgBudgets.Size = new System.Drawing.Size(643, 150);
            this.dgBudgets.TabIndex = 0;
            // 
            // b_id
            // 
            this.b_id.HeaderText = "Budget ID";
            this.b_id.Name = "b_id";
            this.b_id.ReadOnly = true;
            this.b_id.Width = 300;
            // 
            // b_name
            // 
            this.b_name.HeaderText = "Budget Name";
            this.b_name.Name = "b_name";
            this.b_name.ReadOnly = true;
            this.b_name.Width = 300;
            // 
            // btn_setToken
            // 
            this.btn_setToken.Location = new System.Drawing.Point(596, 29);
            this.btn_setToken.Name = "btn_setToken";
            this.btn_setToken.Size = new System.Drawing.Size(75, 23);
            this.btn_setToken.TabIndex = 1;
            this.btn_setToken.Text = "Set Token";
            this.btn_setToken.UseVisualStyleBackColor = true;
            this.btn_setToken.Click += new System.EventHandler(this.btn_setToken_Click);
            // 
            // eb_accessToken
            // 
            this.eb_accessToken.Location = new System.Drawing.Point(28, 32);
            this.eb_accessToken.Name = "eb_accessToken";
            this.eb_accessToken.Size = new System.Drawing.Size(551, 20);
            this.eb_accessToken.TabIndex = 2;
            // 
            // lb_accessToken
            // 
            this.lb_accessToken.AutoSize = true;
            this.lb_accessToken.Location = new System.Drawing.Point(25, 16);
            this.lb_accessToken.Name = "lb_accessToken";
            this.lb_accessToken.Size = new System.Drawing.Size(76, 13);
            this.lb_accessToken.TabIndex = 3;
            this.lb_accessToken.Text = "Access Token";
            // 
            // btn_fetchBudgets
            // 
            this.btn_fetchBudgets.Location = new System.Drawing.Point(28, 261);
            this.btn_fetchBudgets.Name = "btn_fetchBudgets";
            this.btn_fetchBudgets.Size = new System.Drawing.Size(85, 23);
            this.btn_fetchBudgets.TabIndex = 4;
            this.btn_fetchBudgets.Text = "Fetch Budgets";
            this.btn_fetchBudgets.UseVisualStyleBackColor = true;
            this.btn_fetchBudgets.Click += new System.EventHandler(this.btn_fetchBudgets_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 305);
            this.Controls.Add(this.btn_fetchBudgets);
            this.Controls.Add(this.lb_accessToken);
            this.Controls.Add(this.eb_accessToken);
            this.Controls.Add(this.btn_setToken);
            this.Controls.Add(this.dgBudgets);
            this.Name = "frm_Main";
            this.Text = "nYNAB Desktop";
            ((System.ComponentModel.ISupportInitialize)(this.dgBudgets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBudgets;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_name;
        private System.Windows.Forms.Button btn_setToken;
        private System.Windows.Forms.TextBox eb_accessToken;
        private System.Windows.Forms.Label lb_accessToken;
        private System.Windows.Forms.Button btn_fetchBudgets;
    }
}

