namespace DatuAttelosana
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
            srcView = new DataGridView();
            butInvoice = new Button();
            butClient = new Button();
            butPayments = new Button();
            Search = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txtInvoice = new TextBox();
            butClientInvoice = new Button();
            butUnpaidInvoice = new Button();
            butClientFinances = new Button();
            butOverduePay = new Button();
            butTopClient = new Button();
            ((System.ComponentModel.ISupportInitialize)srcView).BeginInit();
            Search.SuspendLayout();
            SuspendLayout();
            // 
            // srcView
            // 
            srcView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            srcView.Location = new Point(199, 185);
            srcView.Name = "srcView";
            srcView.Size = new Size(411, 253);
            srcView.TabIndex = 0;
            // 
            // butInvoice
            // 
            butInvoice.Location = new Point(384, 156);
            butInvoice.Name = "butInvoice";
            butInvoice.Size = new Size(75, 23);
            butInvoice.TabIndex = 1;
            butInvoice.Text = "Invoices";
            butInvoice.UseVisualStyleBackColor = true;
            butInvoice.Click += butInvoice_Click;
            // 
            // butClient
            // 
            butClient.Location = new Point(465, 156);
            butClient.Name = "butClient";
            butClient.Size = new Size(75, 23);
            butClient.TabIndex = 2;
            butClient.Text = "Clients";
            butClient.UseVisualStyleBackColor = true;
            butClient.Click += butClient_Click;
            // 
            // butPayments
            // 
            butPayments.Location = new Point(546, 156);
            butPayments.Name = "butPayments";
            butPayments.Size = new Size(75, 23);
            butPayments.TabIndex = 3;
            butPayments.Text = "Payments";
            butPayments.UseVisualStyleBackColor = true;
            butPayments.Click += butPayments_Click;
            // 
            // Search
            // 
            Search.Controls.Add(textBox5);
            Search.Controls.Add(textBox4);
            Search.Controls.Add(textBox3);
            Search.Controls.Add(textBox2);
            Search.Controls.Add(txtInvoice);
            Search.Location = new Point(100, 50);
            Search.Name = "Search";
            Search.Size = new Size(500, 100);
            Search.TabIndex = 4;
            Search.TabStop = false;
            Search.Text = "Search";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(340, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 1;
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(30, 50);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(71, 23);
            txtInvoice.TabIndex = 0;
            // 
            // butClientInvoice
            // 
            butClientInvoice.Location = new Point(30, 185);
            butClientInvoice.Name = "butClientInvoice";
            butClientInvoice.Size = new Size(143, 46);
            butClientInvoice.TabIndex = 5;
            butClientInvoice.Text = "Client Invoice";
            butClientInvoice.UseVisualStyleBackColor = true;
            butClientInvoice.Click += butClientInvoice_Click;
            // 
            // butUnpaidInvoice
            // 
            butUnpaidInvoice.Location = new Point(30, 237);
            butUnpaidInvoice.Name = "butUnpaidInvoice";
            butUnpaidInvoice.Size = new Size(143, 41);
            butUnpaidInvoice.TabIndex = 6;
            butUnpaidInvoice.Text = "Unpaid invoices";
            butUnpaidInvoice.UseVisualStyleBackColor = true;
            butUnpaidInvoice.Click += butUnpaidInvoice_Click;
            // 
            // butClientFinances
            // 
            butClientFinances.Location = new Point(30, 284);
            butClientFinances.Name = "butClientFinances";
            butClientFinances.Size = new Size(143, 38);
            butClientFinances.TabIndex = 7;
            butClientFinances.Text = "Client financial status";
            butClientFinances.UseVisualStyleBackColor = true;
            butClientFinances.Click += butClientFinances_Click;
            // 
            // butOverduePay
            // 
            butOverduePay.Location = new Point(30, 328);
            butOverduePay.Name = "butOverduePay";
            butOverduePay.Size = new Size(143, 46);
            butOverduePay.TabIndex = 8;
            butOverduePay.Text = "Overdue payments";
            butOverduePay.UseVisualStyleBackColor = true;
            butOverduePay.Click += butOverduePay_Click;
            // 
            // butTopClient
            // 
            butTopClient.Location = new Point(30, 380);
            butTopClient.Name = "butTopClient";
            butTopClient.Size = new Size(143, 46);
            butTopClient.TabIndex = 9;
            butTopClient.Text = "Top clients";
            butTopClient.UseVisualStyleBackColor = true;
            butTopClient.Click += butTopClient_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butTopClient);
            Controls.Add(butOverduePay);
            Controls.Add(butClientFinances);
            Controls.Add(butUnpaidInvoice);
            Controls.Add(butClientInvoice);
            Controls.Add(Search);
            Controls.Add(butPayments);
            Controls.Add(butClient);
            Controls.Add(butInvoice);
            Controls.Add(srcView);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)srcView).EndInit();
            Search.ResumeLayout(false);
            Search.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView srcView;
        private Button butInvoice;
        private Button butClient;
        private Button butPayments;
        private GroupBox Search;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtInvoice;
        private Button butClientInvoice;
        private Button butUnpaidInvoice;
        private Button butClientFinances;
        private Button butOverduePay;
        private Button butTopClient;
    }
}
