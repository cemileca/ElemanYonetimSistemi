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
            KimdenColumn = new DataGridViewTextBoxColumn();
            KimeColumn = new DataGridViewTextBoxColumn();
            VerilenEmrColumn = new DataGridViewTextBoxColumn();
            BaslamaTarihiColumn = new DataGridViewTextBoxColumn();
            BitisTarihiColumn = new DataGridViewTextBoxColumn();
            DetayColumn = new DataGridViewButtonColumn();
            ListePanel = new Panel();
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
            MutfakPanel = new Panel();
            button12 = new Button();
            button11 = new Button();
            AcilPanel = new Panel();
            MudurPanel = new Panel();
            button13 = new Button();
            AramaPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ListePanel.SuspendLayout();
            MutfakPanel.SuspendLayout();
            AcilPanel.SuspendLayout();
            MudurPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { KimdenColumn, KimeColumn, VerilenEmrColumn, BaslamaTarihiColumn, BitisTarihiColumn, DetayColumn });
            dataGridView1.Location = new Point(0, 37);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(2609, 752);
            dataGridView1.TabIndex = 0;
            // 
            // KimdenColumn
            // 
            KimdenColumn.HeaderText = "Kimden";
            KimdenColumn.MinimumWidth = 10;
            KimdenColumn.Name = "KimdenColumn";
            KimdenColumn.Width = 200;
            // 
            // KimeColumn
            // 
            KimeColumn.HeaderText = "Kime";
            KimeColumn.MinimumWidth = 10;
            KimeColumn.Name = "KimeColumn";
            KimeColumn.Width = 200;
            // 
            // VerilenEmrColumn
            // 
            VerilenEmrColumn.HeaderText = "Verilen Emir Açıklamsı";
            VerilenEmrColumn.MinimumWidth = 10;
            VerilenEmrColumn.Name = "VerilenEmrColumn";
            VerilenEmrColumn.Width = 200;
            // 
            // BaslamaTarihiColumn
            // 
            BaslamaTarihiColumn.HeaderText = "Başlama Tarihi";
            BaslamaTarihiColumn.MinimumWidth = 10;
            BaslamaTarihiColumn.Name = "BaslamaTarihiColumn";
            BaslamaTarihiColumn.Width = 200;
            // 
            // BitisTarihiColumn
            // 
            BitisTarihiColumn.HeaderText = "Bitiş Tarihi";
            BitisTarihiColumn.MinimumWidth = 10;
            BitisTarihiColumn.Name = "BitisTarihiColumn";
            BitisTarihiColumn.Width = 200;
            // 
            // DetayColumn
            // 
            DetayColumn.HeaderText = "Detay";
            DetayColumn.MinimumWidth = 10;
            DetayColumn.Name = "DetayColumn";
            DetayColumn.Resizable = DataGridViewTriState.True;
            DetayColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            DetayColumn.Width = 200;
            // 
            // ListePanel
            // 
            ListePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListePanel.BackColor = SystemColors.ActiveCaption;
            ListePanel.Controls.Add(dataGridView1);
            ListePanel.Location = new Point(2, 703);
            ListePanel.Margin = new Padding(6);
            ListePanel.Name = "ListePanel";
            ListePanel.Size = new Size(2616, 646);
            ListePanel.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(130, 338);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(221, 158);
            button2.TabIndex = 2;
            button2.Text = "Acil Her kes Toplansın";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(130, 0);
            button3.Margin = new Padding(6);
            button3.Name = "button3";
            button3.Size = new Size(221, 158);
            button3.TabIndex = 2;
            button3.Text = "Müdür Odama GEL";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(130, 169);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(221, 158);
            button4.TabIndex = 2;
            button4.Text = "Ortaklar Acil Toplanalım";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(6, 6);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(141, 132);
            button1.TabIndex = 2;
            button1.Text = "Müdür Odama Gelir misin";
            button1.UseVisualStyleBackColor = false;
            // 
            // BtnCayIstiyorrum
            // 
            BtnCayIstiyorrum.BackColor = Color.ForestGreen;
            BtnCayIstiyorrum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCayIstiyorrum.ForeColor = SystemColors.ButtonHighlight;
            BtnCayIstiyorrum.Location = new Point(7, 6);
            BtnCayIstiyorrum.Margin = new Padding(6);
            BtnCayIstiyorrum.Name = "BtnCayIstiyorrum";
            BtnCayIstiyorrum.Size = new Size(132, 132);
            BtnCayIstiyorrum.TabIndex = 2;
            BtnCayIstiyorrum.Text = "Çay Verir misin";
            BtnCayIstiyorrum.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.ForestGreen;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(7, 134);
            button6.Margin = new Padding(6);
            button6.Name = "button6";
            button6.Size = new Size(132, 132);
            button6.TabIndex = 2;
            button6.Text = "Kahvaltı Verir misin";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.ForestGreen;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(7, 260);
            button7.Margin = new Padding(6);
            button7.Name = "button7";
            button7.Size = new Size(132, 132);
            button7.TabIndex = 2;
            button7.Text = "Yemek Verir misin";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Olive;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(4, 390);
            button8.Margin = new Padding(6);
            button8.Name = "button8";
            button8.Size = new Size(368, 113);
            button8.TabIndex = 2;
            button8.Text = "Mutfak Sesli Komut";
            button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(356, 0);
            button5.Margin = new Padding(6);
            button5.Name = "button5";
            button5.Size = new Size(124, 497);
            button5.TabIndex = 2;
            button5.Text = "İşle ilgili Çok Kızgınım";
            button5.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkGreen;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(5, 0);
            button9.Margin = new Padding(6);
            button9.Name = "button9";
            button9.Size = new Size(124, 497);
            button9.TabIndex = 2;
            button9.Text = "Keyfim Yerinde";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.DodgerBlue;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Location = new Point(0, 401);
            button10.Margin = new Padding(6);
            button10.Name = "button10";
            button10.Size = new Size(371, 102);
            button10.TabIndex = 2;
            button10.Text = "Müdür Sesli Komut";
            button10.UseVisualStyleBackColor = false;
            // 
            // MutfakPanel
            // 
            MutfakPanel.Controls.Add(button8);
            MutfakPanel.Controls.Add(button7);
            MutfakPanel.Controls.Add(button12);
            MutfakPanel.Controls.Add(button11);
            MutfakPanel.Controls.Add(BtnCayIstiyorrum);
            MutfakPanel.Controls.Add(button6);
            MutfakPanel.Location = new Point(423, 26);
            MutfakPanel.Margin = new Padding(6);
            MutfakPanel.Name = "MutfakPanel";
            MutfakPanel.Size = new Size(371, 503);
            MutfakPanel.TabIndex = 3;
            // 
            // button12
            // 
            button12.BackColor = Color.Yellow;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = SystemColors.ActiveCaptionText;
            button12.Location = new Point(275, 9);
            button12.Margin = new Padding(6);
            button12.Name = "button12";
            button12.Size = new Size(95, 384);
            button12.TabIndex = 2;
            button12.Text = "Uyarı";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.ForestGreen;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(141, 6);
            button11.Margin = new Padding(6);
            button11.Name = "button11";
            button11.Size = new Size(132, 132);
            button11.TabIndex = 2;
            button11.Text = "Odamı Temizler misin";
            button11.UseVisualStyleBackColor = false;
            // 
            // AcilPanel
            // 
            AcilPanel.BackColor = SystemColors.ActiveCaptionText;
            AcilPanel.Controls.Add(button9);
            AcilPanel.Controls.Add(button5);
            AcilPanel.Controls.Add(button3);
            AcilPanel.Controls.Add(button4);
            AcilPanel.Controls.Add(button2);
            AcilPanel.Location = new Point(2123, 20);
            AcilPanel.Margin = new Padding(6);
            AcilPanel.Name = "AcilPanel";
            AcilPanel.Size = new Size(485, 503);
            AcilPanel.TabIndex = 3;
            // 
            // MudurPanel
            // 
            MudurPanel.Controls.Add(button1);
            MudurPanel.Controls.Add(button10);
            MudurPanel.Controls.Add(button13);
            MudurPanel.Location = new Point(22, 30);
            MudurPanel.Margin = new Padding(6);
            MudurPanel.Name = "MudurPanel";
            MudurPanel.Size = new Size(371, 503);
            MudurPanel.TabIndex = 4;
            // 
            // button13
            // 
            button13.BackColor = Color.Yellow;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = SystemColors.ActiveCaptionText;
            button13.Location = new Point(271, 13);
            button13.Margin = new Padding(6);
            button13.Name = "button13";
            button13.Size = new Size(95, 384);
            button13.TabIndex = 2;
            button13.Text = "Uyarı";
            button13.UseVisualStyleBackColor = false;
            // 
            // AramaPanel
            // 
            AramaPanel.BackColor = SystemColors.ControlDark;
            AramaPanel.Location = new Point(12, 559);
            AramaPanel.Name = "AramaPanel";
            AramaPanel.Size = new Size(2599, 135);
            AramaPanel.TabIndex = 5;
            AramaPanel.Tag = "";
            // 
            // ToDoForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2626, 1348);
            Controls.Add(AramaPanel);
            Controls.Add(MudurPanel);
            Controls.Add(AcilPanel);
            Controls.Add(MutfakPanel);
            Controls.Add(ListePanel);
            Margin = new Padding(6);
            Name = "ToDoForm";
            Text = "ToDoForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ListePanel.ResumeLayout(false);
            MutfakPanel.ResumeLayout(false);
            AcilPanel.ResumeLayout(false);
            MudurPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel ListePanel;
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
        private Panel MutfakPanel;
        private Panel AcilPanel;
        private Button button12;
        private Button button11;
        private Panel MudurPanel;
        private Button button13;
        private DataGridViewTextBoxColumn KimdenColumn;
        private DataGridViewTextBoxColumn KimeColumn;
        private DataGridViewTextBoxColumn VerilenEmrColumn;
        private DataGridViewTextBoxColumn BaslamaTarihiColumn;
        private DataGridViewTextBoxColumn BitisTarihiColumn;
        private DataGridViewButtonColumn DetayColumn;
        private Panel AramaPanel;
    }
}