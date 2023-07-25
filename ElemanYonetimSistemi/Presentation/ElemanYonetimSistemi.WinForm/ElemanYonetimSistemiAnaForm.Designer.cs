namespace ElemanYonetimSistemi.WinForm
{
    partial class ElemanYonetimSistemiAnaForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(207, 191);
            button1.TabIndex = 0;
            button1.Text = "Yapılacaklar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(243, 12);
            button2.Name = "button2";
            button2.Size = new Size(207, 191);
            button2.TabIndex = 0;
            button2.Text = "Satışlar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(469, 12);
            button3.Name = "button3";
            button3.Size = new Size(207, 191);
            button3.TabIndex = 0;
            button3.Text = "Elemanlar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 224);
            button4.Name = "button4";
            button4.Size = new Size(207, 191);
            button4.TabIndex = 0;
            button4.Text = "Muhasebe";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(243, 224);
            button5.Name = "button5";
            button5.Size = new Size(207, 191);
            button5.TabIndex = 0;
            button5.Text = "Tedarikçiler";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(469, 224);
            button6.Name = "button6";
            button6.Size = new Size(207, 191);
            button6.TabIndex = 0;
            button6.Text = "Müşteriler";
            button6.UseVisualStyleBackColor = true;
            // 
            // ElemanYonetimSistemiAnaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 653);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ElemanYonetimSistemiAnaForm";
            Text = "Ana Yönetim Paneli";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}