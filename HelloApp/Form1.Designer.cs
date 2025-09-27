namespace HelloApp
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            buttonEye1 = new Button();
            buttonEye2 = new Button();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(291, 200);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 0;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 93);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese contraseña:";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.PasswordChar = '●';
            // 
            // buttonEye1
            // 
            buttonEye1.Location = new Point(495, 90);
            buttonEye1.Name = "buttonEye1";
            buttonEye1.Size = new Size(30, 23);
            buttonEye1.TabIndex = 6;
            buttonEye1.Text = "👁";
            buttonEye1.UseVisualStyleBackColor = true;
            buttonEye1.Click += buttonEye1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(291, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.PasswordChar = '●';
            // 
            // buttonEye2
            // 
            buttonEye2.Location = new Point(495, 133);
            buttonEye2.Name = "buttonEye2";
            buttonEye2.Size = new Size(30, 23);
            buttonEye2.TabIndex = 7;
            buttonEye2.Text = "👁";
            buttonEye2.UseVisualStyleBackColor = true;
            buttonEye2.Click += buttonEye2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 136);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 4;
            label2.Text = "Confirmar contraseña:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitulo.Location = new Point(220, 30);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(274, 30);
            labelTitulo.TabIndex = 5;
            labelTitulo.Text = "Validación de Contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 300);
            Controls.Add(labelTitulo);
            Controls.Add(buttonEye2);
            Controls.Add(buttonEye1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Validación de Contraseña";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label labelTitulo;
        private Button buttonEye1;
        private Button buttonEye2;
    }
}
