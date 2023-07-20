namespace KelimeOgren
{
    partial class FormKelimeEkrani
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
            tbxTr = new TextBox();
            tbxEn = new TextBox();
            lblKalanSure = new Label();
            btnPas = new Button();
            btnBitir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMessage = new Label();
            lblKalanHak = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "Tr:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 1;
            label2.Text = "En:";
            // 
            // tbxTr
            // 
            tbxTr.Location = new Point(42, 6);
            tbxTr.Name = "tbxTr";
            tbxTr.ReadOnly = true;
            tbxTr.Size = new Size(162, 27);
            tbxTr.TabIndex = 2;
            // 
            // tbxEn
            // 
            tbxEn.Location = new Point(42, 44);
            tbxEn.Name = "tbxEn";
            tbxEn.Size = new Size(162, 27);
            tbxEn.TabIndex = 2;
            tbxEn.TextChanged += tbxEn_TextChanged;
            // 
            // lblKalanSure
            // 
            lblKalanSure.AutoSize = true;
            lblKalanSure.Location = new Point(248, 10);
            lblKalanSure.Name = "lblKalanSure";
            lblKalanSure.Size = new Size(0, 20);
            lblKalanSure.TabIndex = 3;
            // 
            // btnPas
            // 
            btnPas.Location = new Point(124, 103);
            btnPas.Name = "btnPas";
            btnPas.Size = new Size(76, 29);
            btnPas.TabIndex = 4;
            btnPas.Text = "Pas";
            btnPas.UseVisualStyleBackColor = true;
            btnPas.Click += btnPas_Click;
            // 
            // btnBitir
            // 
            btnBitir.Location = new Point(42, 103);
            btnBitir.Name = "btnBitir";
            btnBitir.Size = new Size(76, 29);
            btnBitir.TabIndex = 4;
            btnBitir.Text = "Başla";
            btnBitir.UseVisualStyleBackColor = true;
            btnBitir.Click += btnBitir_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(37, 143);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 5;
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Location = new Point(42, 80);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(110, 20);
            lblKalanHak.TabIndex = 3;
            lblKalanHak.Text = "Kalan hakkınız :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 187);
            Controls.Add(lblMessage);
            Controls.Add(btnBitir);
            Controls.Add(btnPas);
            Controls.Add(lblKalanHak);
            Controls.Add(lblKalanSure);
            Controls.Add(tbxEn);
            Controls.Add(tbxTr);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kelime Öğren";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxTr;
        private TextBox tbxEn;
        private Label lblKalanSure;
        private Button btnPas;
        private Button btnBitir;
        private System.Windows.Forms.Timer timer1;
        private Label lblMessage;
        private Label lblKalanHak;
    }
}