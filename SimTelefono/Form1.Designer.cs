namespace SimTelefono
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
            txtNumero = new TextBox();
            txtCredito = new TextBox();
            label2 = new Label();
            txtMinuti = new TextBox();
            label3 = new Label();
            txtDestinatario = new TextBox();
            label4 = new Label();
            btnSalva = new Button();
            btnMinuti = new Button();
            btnTelefonata = new Button();
            btnStampa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 42);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero propritario";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(168, 39);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(240, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtCredito
            // 
            txtCredito.Location = new Point(168, 121);
            txtCredito.Name = "txtCredito";
            txtCredito.Size = new Size(240, 23);
            txtCredito.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 124);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Credito rimanente";
            // 
            // txtMinuti
            // 
            txtMinuti.Location = new Point(168, 209);
            txtMinuti.Name = "txtMinuti";
            txtMinuti.Size = new Size(240, 23);
            txtMinuti.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 212);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 4;
            label3.Text = "Minuti di chiamata";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(168, 292);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(240, 23);
            txtDestinatario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 295);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 6;
            label4.Text = "Numero destinatario";
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(501, 39);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(265, 48);
            btnSalva.TabIndex = 8;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnMinuti
            // 
            btnMinuti.Location = new Point(501, 124);
            btnMinuti.Name = "btnMinuti";
            btnMinuti.Size = new Size(265, 48);
            btnMinuti.TabIndex = 9;
            btnMinuti.Text = "Minuti di chiamata";
            btnMinuti.UseVisualStyleBackColor = true;
            btnMinuti.Click += btnMinuti_Click;
            // 
            // btnTelefonata
            // 
            btnTelefonata.Location = new Point(501, 209);
            btnTelefonata.Name = "btnTelefonata";
            btnTelefonata.Size = new Size(265, 48);
            btnTelefonata.TabIndex = 10;
            btnTelefonata.Text = "Telefonate verso un certo numero";
            btnTelefonata.UseVisualStyleBackColor = true;
            btnTelefonata.Click += btnTelefonata_Click;
            // 
            // btnStampa
            // 
            btnStampa.Location = new Point(501, 292);
            btnStampa.Name = "btnStampa";
            btnStampa.Size = new Size(265, 48);
            btnStampa.TabIndex = 11;
            btnStampa.Text = "Stampa";
            btnStampa.UseVisualStyleBackColor = true;
            btnStampa.Click += btnStampa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStampa);
            Controls.Add(btnTelefonata);
            Controls.Add(btnMinuti);
            Controls.Add(btnSalva);
            Controls.Add(txtDestinatario);
            Controls.Add(label4);
            Controls.Add(txtMinuti);
            Controls.Add(label3);
            Controls.Add(txtCredito);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private TextBox txtCredito;
        private Label label2;
        private TextBox txtMinuti;
        private Label label3;
        private TextBox txtDestinatario;
        private Label label4;
        private Button btnSalva;
        private Button btnMinuti;
        private Button btnTelefonata;
        private Button btnStampa;
    }
}
