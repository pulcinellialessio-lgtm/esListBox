namespace esListBox
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
            listBox1 = new ListBox();
            Aggiungi = new Button();
            Rimuovi = new Button();
            Modifica = new Button();
            textBoxAggiungi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxModifica = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(67, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(103, 94);
            listBox1.TabIndex = 0;
            // 
            // Aggiungi
            // 
            Aggiungi.Location = new Point(202, 32);
            Aggiungi.Name = "Aggiungi";
            Aggiungi.Size = new Size(75, 23);
            Aggiungi.TabIndex = 1;
            Aggiungi.Text = "Aggiungi";
            Aggiungi.UseVisualStyleBackColor = true;
            Aggiungi.Click += Aggiungi_Click;
            // 
            // Rimuovi
            // 
            Rimuovi.Location = new Point(202, 61);
            Rimuovi.Name = "Rimuovi";
            Rimuovi.Size = new Size(75, 23);
            Rimuovi.TabIndex = 2;
            Rimuovi.Text = "Rimuovi";
            Rimuovi.UseVisualStyleBackColor = true;
            // 
            // Modifica
            // 
            Modifica.Location = new Point(202, 90);
            Modifica.Name = "Modifica";
            Modifica.Size = new Size(75, 23);
            Modifica.TabIndex = 3;
            Modifica.Text = "Modifica";
            Modifica.UseVisualStyleBackColor = true;
            // 
            // textBoxAggiungi
            // 
            textBoxAggiungi.Location = new Point(297, 32);
            textBoxAggiungi.Name = "textBoxAggiungi";
            textBoxAggiungi.Size = new Size(109, 23);
            textBoxAggiungi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 14);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "Aggiungi elemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 117);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 7;
            label2.Text = "Modifica elemento";
            label2.Click += label2_Click;
            // 
            // textBoxModifica
            // 
            textBoxModifica.Location = new Point(297, 91);
            textBoxModifica.Name = "textBoxModifica";
            textBoxModifica.Size = new Size(109, 23);
            textBoxModifica.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxModifica);
            Controls.Add(label1);
            Controls.Add(textBoxAggiungi);
            Controls.Add(Modifica);
            Controls.Add(Rimuovi);
            Controls.Add(Aggiungi);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button Aggiungi;
        private Button Rimuovi;
        private Button Modifica;
        private TextBox textBoxAggiungi;
        private Label label1;
        private Label label2;
        private TextBox textBoxModifica;
    }
}
