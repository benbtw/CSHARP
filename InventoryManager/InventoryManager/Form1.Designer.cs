namespace InventoryManager
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
            label1 = new Label();
            priceTxBx = new TextBox();
            InventoryGridView = new DataGridView();
            newBtn = new Button();
            saveBtn = new Button();
            deleteBtn = new Button();
            descripTxBx = new TextBox();
            quantTxBx = new TextBox();
            skuTxBx = new TextBox();
            nameTxBx = new TextBox();
            cateCBx = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 47);
            label1.TabIndex = 0;
            label1.Text = "Inventory Manager";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // priceTxBx
            // 
            priceTxBx.Location = new Point(12, 122);
            priceTxBx.Name = "priceTxBx";
            priceTxBx.Size = new Size(221, 23);
            priceTxBx.TabIndex = 1;
            // 
            // InventoryGridView
            // 
            InventoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InventoryGridView.BackgroundColor = SystemColors.ButtonHighlight;
            InventoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InventoryGridView.Location = new Point(12, 180);
            InventoryGridView.Name = "InventoryGridView";
            InventoryGridView.RowTemplate.Height = 25;
            InventoryGridView.Size = new Size(893, 386);
            InventoryGridView.TabIndex = 2;
            InventoryGridView.CellDoubleClick += InventoryGridView_CellDoubleClick;
            // 
            // newBtn
            // 
            newBtn.Location = new Point(12, 151);
            newBtn.Name = "newBtn";
            newBtn.Size = new Size(221, 23);
            newBtn.TabIndex = 3;
            newBtn.Text = "New";
            newBtn.UseVisualStyleBackColor = true;
            newBtn.Click += newBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(351, 151);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(221, 23);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(684, 151);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(221, 23);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // descripTxBx
            // 
            descripTxBx.Location = new Point(351, 122);
            descripTxBx.Name = "descripTxBx";
            descripTxBx.Size = new Size(221, 23);
            descripTxBx.TabIndex = 6;
            // 
            // quantTxBx
            // 
            quantTxBx.Location = new Point(684, 122);
            quantTxBx.Name = "quantTxBx";
            quantTxBx.Size = new Size(221, 23);
            quantTxBx.TabIndex = 7;
            // 
            // skuTxBx
            // 
            skuTxBx.Location = new Point(12, 82);
            skuTxBx.Name = "skuTxBx";
            skuTxBx.Size = new Size(221, 23);
            skuTxBx.TabIndex = 8;
            // 
            // nameTxBx
            // 
            nameTxBx.Location = new Point(351, 82);
            nameTxBx.Name = "nameTxBx";
            nameTxBx.Size = new Size(221, 23);
            nameTxBx.TabIndex = 9;
            // 
            // cateCBx
            // 
            cateCBx.FormattingEnabled = true;
            cateCBx.Items.AddRange(new object[] { "Automotive", "Hardware", "Grocery", "Pharmacy" });
            cateCBx.Location = new Point(684, 82);
            cateCBx.Name = "cateCBx";
            cateCBx.Size = new Size(221, 23);
            cateCBx.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 11;
            label2.Text = "SKU:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(351, 56);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(684, 54);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 13;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(351, 104);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 15;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(684, 104);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 16;
            label7.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(917, 578);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cateCBx);
            Controls.Add(nameTxBx);
            Controls.Add(skuTxBx);
            Controls.Add(quantTxBx);
            Controls.Add(descripTxBx);
            Controls.Add(deleteBtn);
            Controls.Add(saveBtn);
            Controls.Add(newBtn);
            Controls.Add(InventoryGridView);
            Controls.Add(priceTxBx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Inventory Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)InventoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox priceTxBx;
        private DataGridView InventoryGridView;
        private Button newBtn;
        private Button saveBtn;
        private Button deleteBtn;
        private TextBox descripTxBx;
        private TextBox quantTxBx;
        private TextBox skuTxBx;
        private TextBox nameTxBx;
        private ComboBox cateCBx;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}