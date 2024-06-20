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
            SuspendLayout();
            // 
            // bt_msg
            // 
            bt_msg.Location = new Point(350, 204);
            bt_msg.Name = "bt_msg";
            bt_msg.Size = new Size(75, 23);
            bt_msg.TabIndex = 0;
            bt_msg.Text = "Mensagem";
            bt_msg.UseVisualStyleBackColor = true;
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(297, 175);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(176, 23);
            tb_nome.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}