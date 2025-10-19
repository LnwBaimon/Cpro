namespace Slot
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            win = new Label();
            Spin = new Button();
            Reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Arial Unicode MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(87, 125);
            label1.Name = "label1";
            label1.Size = new Size(151, 65);
            label1.TabIndex = 0;
            label1.Text = "slot1";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Arial Unicode MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(342, 125);
            label2.Name = "label2";
            label2.Size = new Size(151, 65);
            label2.TabIndex = 1;
            label2.Text = "slot2";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Arial Unicode MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(597, 125);
            label3.Name = "label3";
            label3.Size = new Size(151, 65);
            label3.TabIndex = 2;
            label3.Text = "slot3";
            label3.Click += label3_Click;
            // 
            // win
            // 
            win.BackColor = SystemColors.ActiveCaptionText;
            win.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            win.ForeColor = Color.LawnGreen;
            win.Location = new Point(658, 397);
            win.Name = "win";
            win.Size = new Size(137, 51);
            win.TabIndex = 3;
            win.Text = "Win: ";
            // 
            // Spin
            // 
            Spin.BackColor = SystemColors.ControlLightLight;
            Spin.Location = new Point(264, 280);
            Spin.Name = "Spin";
            Spin.Size = new Size(92, 39);
            Spin.TabIndex = 4;
            Spin.Text = "Spin";
            Spin.UseVisualStyleBackColor = false;
            Spin.Click += btnSpin_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(453, 280);
            Reset.Name = "Reset";
            Reset.Size = new Size(92, 39);
            Reset.TabIndex = 5;
            Reset.Text = "Reset Score\r\n";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += btnReset_Click;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(581, 9);
            label4.Name = "label4";
            label4.Size = new Size(214, 38);
            label4.TabIndex = 6;
            label4.Text = "Slot Together";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_lucky_777_slot_machine_jackpot_win_image_17269320;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(820, 457);
            Controls.Add(label4);
            Controls.Add(Reset);
            Controls.Add(Spin);
            Controls.Add(win);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Slot Game";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label win;
        private Button Spin;
        private Button Reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Label label4;
    }
}
