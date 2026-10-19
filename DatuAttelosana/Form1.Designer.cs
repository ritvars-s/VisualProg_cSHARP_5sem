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
            txtInvoice = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            butClientInvoice = new Button();
            butInvoiceClientTotal = new Button();
            butSortTotal = new Button();
            butSumAboveHun = new Button();
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
            // txtInvoice
            // 
            txtInvoice.Location = new Point(30, 50);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(71, 23);
            txtInvoice.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(40, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(340, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(340, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 4;
            // 
            // butClientInvoice
            // 
            butClientInvoice.Location = new Point(30, 205);
            butClientInvoice.Name = "butClientInvoice";
            butClientInvoice.Size = new Size(143, 46);
            butClientInvoice.TabIndex = 5;
            butClientInvoice.Text = "Client Invoice";
            butClientInvoice.UseVisualStyleBackColor = true;
            butClientInvoice.Click += butClientInvoice_Click;
            // 
            // butInvoiceClientTotal
            // 
            butInvoiceClientTotal.Location = new Point(30, 257);
            butInvoiceClientTotal.Name = "butInvoiceClientTotal";
            butInvoiceClientTotal.Size = new Size(143, 41);
            butInvoiceClientTotal.TabIndex = 6;
            butInvoiceClientTotal.Text = "InvoiceNumber Client Name, Total Amount, Due Date";
            butInvoiceClientTotal.UseVisualStyleBackColor = true;
            // 
            // butSortTotal
            // 
            butSortTotal.Location = new Point(30, 304);
            butSortTotal.Name = "butSortTotal";
            butSortTotal.Size = new Size(143, 38);
            butSortTotal.TabIndex = 7;
            butSortTotal.Text = "Sort by total amount";
            butSortTotal.UseVisualStyleBackColor = true;
            // 
            // butSumAboveHun
            // 
            butSumAboveHun.Location = new Point(30, 348);
            butSumAboveHun.Name = "butSumAboveHun";
            butSumAboveHun.Size = new Size(143, 46);
            butSumAboveHun.TabIndex = 8;
            butSumAboveHun.Text = "Show data where total amount is above 100";
            butSumAboveHun.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butSumAboveHun);
            Controls.Add(butSortTotal);
            Controls.Add(butInvoiceClientTotal);
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
        private Button butInvoiceClientTotal;
        private Button butSortTotal;
        private Button butSumAboveHun;
    }
}
