namespace ej1
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
            tbPrueba = new TextBox();
            btnPrueba = new Button();
            SuspendLayout();
            // 
            // tbPrueba
            // 
            tbPrueba.Location = new Point(12, 12);
            tbPrueba.Multiline = true;
            tbPrueba.Name = "tbPrueba";
            tbPrueba.Size = new Size(655, 609);
            tbPrueba.TabIndex = 0;
            // 
            // btnPrueba
            // 
            btnPrueba.Location = new Point(673, 236);
            btnPrueba.Name = "btnPrueba";
            btnPrueba.Size = new Size(137, 83);
            btnPrueba.TabIndex = 1;
            btnPrueba.Text = "Prueba";
            btnPrueba.UseVisualStyleBackColor = true;
            btnPrueba.Click += btnPrueba_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 633);
            Controls.Add(btnPrueba);
            Controls.Add(tbPrueba);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Ejercicio1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPrueba;
        private Button btnPrueba;
    }
}
