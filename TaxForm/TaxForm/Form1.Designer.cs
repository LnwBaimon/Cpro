namespace TaxForm
{
    partial class a
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPurchase = new TextBox();
            perc = new TextBox();
            txtTotalDue = new TextBox();
            btnCompute = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 137);
            label1.Name = "label1";
            label1.Size = new Size(195, 41);
            label1.TabIndex = 0;
            label1.Text = "Total Amount:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(71, 207);
            label2.Name = "label2";
            label2.Size = new Size(278, 48);
            label2.TabIndex = 1;
            label2.Text = "Total Percentage:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 277);
            label3.Name = "label3";
            label3.Size = new Size(195, 44);
            label3.TabIndex = 2;
            label3.Text = "Total Due:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(148, 21);
            label4.Name = "label4";
            label4.Size = new Size(449, 66);
            label4.TabIndex = 3;
            label4.Text = "Tax Calculator";
            label4.Click += label4_Click;
            // 
            // txtPurchase
            // 
            txtPurchase.Location = new Point(328, 148);
            txtPurchase.Name = "txtPurchase";
            txtPurchase.Size = new Size(237, 27);
            txtPurchase.TabIndex = 4;
            txtPurchase.TextAlign = HorizontalAlignment.Right;
            txtPurchase.TextChanged += textBox1_TextChanged;
            // 
            // perc
            // 
            perc.Location = new Point(328, 218);
            perc.Name = "perc";
            perc.Size = new Size(125, 27);
            perc.TabIndex = 5;
            // 
            // txtTotalDue
            // 
            txtTotalDue.Enabled = false;
            txtTotalDue.Location = new Point(328, 288);
            txtTotalDue.Name = "txtTotalDue";
            txtTotalDue.Size = new Size(237, 27);
            txtTotalDue.TabIndex = 6;
            txtTotalDue.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = SystemColors.ButtonFace;
            btnCompute.ForeColor = SystemColors.ActiveCaptionText;
            btnCompute.Location = new Point(270, 373);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(94, 33);
            btnCompute.TabIndex = 7;
            btnCompute.Text = "Complete";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(790, 450);
            Controls.Add(btnCompute);
            Controls.Add(txtTotalDue);
            Controls.Add(perc);
            Controls.Add(txtPurchase);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "a";
            Text = "Tax Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPurchase;
        private TextBox perc;
        private TextBox txtTotalDue;
        private Button btnCompute;
    }
}
