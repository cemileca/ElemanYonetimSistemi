namespace ElemanYonetimSistemi.WinForm.Forms
{
    partial class CayIstiyorumFrm
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(201, 40);
            button1.Name = "button1";
            button1.Size = new Size(215, 49);
            button1.TabIndex = 0;
            button1.Text = "Satndart";
            // 
            // button2
            // 
            button2.Location = new Point(201, 95);
            button2.Name = "button2";
            button2.Size = new Size(215, 49);
            button2.TabIndex = 0;
            button2.Text = "Diğer";
            // 
            // button3
            // 
            button3.Location = new Point(12, 161);
            button3.Name = "button3";
            button3.Size = new Size(154, 49);
            button3.TabIndex = 0;
            button3.Text = "Odama";
            // 
            // button4
            // 
            button4.Location = new Point(182, 161);
            button4.Name = "button4";
            button4.Size = new Size(154, 49);
            button4.TabIndex = 0;
            button4.Text = "1 adet";
            // 
            // button5
            // 
            button5.Location = new Point(356, 161);
            button5.Name = "button5";
            button5.Size = new Size(154, 49);
            button5.TabIndex = 0;
            button5.Text = "Koyu";
            // 
            // button6
            // 
            button6.Location = new Point(12, 216);
            button6.Name = "button6";
            button6.Size = new Size(154, 49);
            button6.TabIndex = 0;
            button6.Text = "Diğer";
            // 
            // button7
            // 
            button7.Location = new Point(182, 216);
            button7.Name = "button7";
            button7.Size = new Size(154, 49);
            button7.TabIndex = 0;
            button7.Text = "Diğer";
            // 
            // button8
            // 
            button8.Location = new Point(356, 216);
            button8.Name = "button8";
            button8.Size = new Size(154, 49);
            button8.TabIndex = 0;
            button8.Text = "Açık";
            // 
            // button9
            // 
            button9.Location = new Point(356, 271);
            button9.Name = "button9";
            button9.Size = new Size(154, 49);
            button9.TabIndex = 0;
            button9.Text = "Çok Açık";
            // 
            // CayIstiyorumFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 445);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CayIstiyorumFrm";
            Text = "CayIstiyorumFrm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}