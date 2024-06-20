namespace branchProject
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
            bt_msg = new Button();
            tb_nome = new TextBox();
            lb_text = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // bt_msg
            // 
            bt_msg.Location = new Point(104, 204);
            bt_msg.Name = "bt_msg";
            bt_msg.Size = new Size(75, 23);
            bt_msg.TabIndex = 0;
            bt_msg.Text = "Mensagem";
            bt_msg.UseVisualStyleBackColor = true;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(104, 175);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(176, 23);
            tb_nome.TabIndex = 1;
            // 
            // lb_text
            // 
            lb_text.AutoSize = true;
            lb_text.Location = new Point(104, 157);
            lb_text.Name = "lb_text";
            lb_text.Size = new Size(103, 15);
            lb_text.TabIndex = 2;
            lb_text.Text = "Digite o seu nome";
            lb_text.Click += lb_text_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(286, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(468, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(312, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lb_text);
            Controls.Add(tb_nome);
            Controls.Add(bt_msg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_msg;
        private TextBox tb_nome;
        private Label lb_text;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}