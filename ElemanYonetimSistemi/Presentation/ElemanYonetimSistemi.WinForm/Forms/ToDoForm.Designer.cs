namespace ElemanYonetimSistemi.WinForm.Forms
{
    partial class ToDoForm
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
            dataGridView1 = new DataGridView();
            DataGridPanel = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            BtnCayIstiyorrum = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button5 = new Button();
            button9 = new Button();
            button10 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button11 = new Button();
            button12 = new Button();
            MudurPanel = new Panel();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            DataGridPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            MudurPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(964, 346);
            dataGridView1.TabIndex = 0;
            // 
            // DataGridPanel
            // 
            DataGridPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridPanel.Controls.Add(dataGridView1);
            DataGridPanel.Location = new Point(1, 328);
            DataGridPanel.Name = "DataGridPanel";
            DataGridPanel.Size = new Size(964, 304);
            DataGridPanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(70, 158);
            button2.Name = "button2";
            button2.Size = new Size(119, 74);
            button2.TabIndex = 2;
            button2.Text = "Acil Her kes Toplansın";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(70, 4);
            button3.Name = "button3";
            button3.Size = new Size(119, 74);
            button3.TabIndex = 2;
            button3.Text = "Müdür Odama GEL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(70, 81);
            button4.Name = "button4";
            button4.Size = new Size(119, 74);
            button4.TabIndex = 2;
            button4.Text = "Ortaklar Acil Toplanalım";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(76, 62);
            button1.TabIndex = 2;
            button1.Text = "Müdür Odama Gelir misin";
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnCayIstiyorrum
            // 
            BtnCayIstiyorrum.BackColor = Color.ForestGreen;
            BtnCayIstiyorrum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCayIstiyorrum.ForeColor = SystemColors.ButtonHighlight;
            BtnCayIstiyorrum.Location = new Point(4, 3);
            BtnCayIstiyorrum.Name = "BtnCayIstiyorrum";
            BtnCayIstiyorrum.Size = new Size(71, 62);
            BtnCayIstiyorrum.TabIndex = 2;
            BtnCayIstiyorrum.Text = "Çay Verir misin";
            BtnCayIstiyorrum.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(4, 63);
            button6.Name = "button6";
            button6.Size = new Size(71, 62);
            button6.TabIndex = 2;
            button6.Text = "Kahvaltı Verir misin";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.ForestGreen;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(4, 122);
            button7.Name = "button7";
            button7.Size = new Size(71, 62);
            button7.TabIndex = 2;
            button7.Text = "Yemek Verir misin";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Olive;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(2, 183);
            button8.Name = "button8";
            button8.Size = new Size(198, 53);
            button8.TabIndex = 2;
            button8.Text = "Mutfak Sesli Komut";
            button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(189, 0);
            button5.Name = "button5";
            button5.Size = new Size(67, 233);
            button5.TabIndex = 2;
            button5.Text = "İşle ilgili Çok Kızgınım";
            button5.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkGreen;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(3, 0);
            button9.Name = "button9";
            button9.Size = new Size(67, 233);
            button9.TabIndex = 2;
            button9.Text = "Keyfim Yerinde";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.DodgerBlue;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(0, 188);
            button10.Name = "button10";
            button10.Size = new Size(200, 48);
            button10.TabIndex = 2;
            button10.Text = "Müdür Sesli Komut";
            button10.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(BtnCayIstiyorrum);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(228, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 236);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(696, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 236);
            panel3.TabIndex = 3;
            // 
            // button11
            // 
            button11.BackColor = Color.ForestGreen;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(76, 3);
            button11.Name = "button11";
            button11.Size = new Size(71, 62);
            button11.TabIndex = 2;
            button11.Text = "Odamı Temizler misin";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Yellow;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ActiveCaptionText;
            button12.Location = new Point(148, 4);
            button12.Name = "button12";
            button12.Size = new Size(51, 180);
            button12.TabIndex = 2;
            button12.Text = "Uyarı";
            button12.UseVisualStyleBackColor = false;
            // 
            // MudurPanel
            // 
            MudurPanel.Controls.Add(button1);
            MudurPanel.Controls.Add(button10);
            MudurPanel.Controls.Add(button13);
            MudurPanel.Location = new Point(12, 14);
            MudurPanel.Name = "MudurPanel";
            MudurPanel.Size = new Size(200, 236);
            MudurPanel.TabIndex = 4;
            // 
            // button13
            // 
            button13.BackColor = Color.Yellow;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ActiveCaptionText;
            button13.Location = new Point(146, 6);
            button13.Name = "button13";
            button13.Size = new Size(51, 180);
            button13.TabIndex = 2;
            button13.Text = "Uyarı";
            button13.UseVisualStyleBackColor = false;
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 632);
            Controls.Add(MudurPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(DataGridPanel);
            Name = "ToDoForm";
            Text = "ToDoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            DataGridPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            MudurPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel DataGridPanel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button BtnCayIstiyorrum;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button5;
        private Button button9;
        private Button button10;
        private Panel panel2;
        private Panel panel3;
        private Button button12;
        private Button button11;
        private Panel MudurPanel;
        private Button button13;
    }
}