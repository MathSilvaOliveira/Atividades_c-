namespace ConversaodeMoedas
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
            DolarHoje = new Label();
            textBox1 = new TextBox();
            DolarOntem = new Label();
            textBox2 = new TextBox();
            Avaliar = new Button();
            SuspendLayout();
            // 
            // DolarHoje
            // 
            DolarHoje.AutoSize = true;
            DolarHoje.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DolarHoje.Location = new Point(21, 49);
            DolarHoje.Name = "DolarHoje";
            DolarHoje.Size = new Size(131, 25);
            DolarHoje.TabIndex = 0;
            DolarHoje.Text = "Dolar Hoje = ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // DolarOntem
            // 
            DolarOntem.AutoSize = true;
            DolarOntem.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DolarOntem.Location = new Point(12, 108);
            DolarOntem.Name = "DolarOntem";
            DolarOntem.Size = new Size(144, 25);
            DolarOntem.TabIndex = 3;
            DolarOntem.Text = "Dolar Ontem =";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // Avaliar
            // 
            Avaliar.Location = new Point(140, 167);
            Avaliar.Name = "Avaliar";
            Avaliar.Size = new Size(164, 33);
            Avaliar.TabIndex = 5;
            Avaliar.Text = "Avaliar";
            Avaliar.UseVisualStyleBackColor = true;
            Avaliar.Click += Avaliar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Avaliar);
            Controls.Add(textBox2);
            Controls.Add(DolarOntem);
            Controls.Add(textBox1);
            Controls.Add(DolarHoje);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DolarHoje;
        private TextBox textBox1;
        private Label DolarOntem;
        private TextBox textBox2;
        private Button Avaliar;
    }
}
