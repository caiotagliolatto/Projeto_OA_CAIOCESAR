namespace View
{
    partial class delup
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
            this.nomebox = new System.Windows.Forms.TextBox();
            this.precobox = new System.Windows.Forms.TextBox();
            this.descbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.preco = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomebox
            // 
            this.nomebox.AcceptsReturn = true;
            this.nomebox.AcceptsTab = true;
            this.nomebox.AllowDrop = true;
            this.nomebox.Location = new System.Drawing.Point(12, 52);
            this.nomebox.Name = "nomebox";
            this.nomebox.Size = new System.Drawing.Size(100, 20);
            this.nomebox.TabIndex = 0;
            this.nomebox.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // precobox
            // 
            this.precobox.Location = new System.Drawing.Point(149, 52);
            this.precobox.Name = "precobox";
            this.precobox.Size = new System.Drawing.Size(88, 20);
            this.precobox.TabIndex = 0;
            // 
            // descbox
            // 
            this.descbox.Location = new System.Drawing.Point(12, 112);
            this.descbox.Name = "descbox";
            this.descbox.Size = new System.Drawing.Size(225, 20);
            this.descbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // preco
            // 
            this.preco.AutoSize = true;
            this.preco.Location = new System.Drawing.Point(147, 33);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(35, 13);
            this.preco.TabIndex = 1;
            this.preco.Text = "Preço";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(13, 92);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(58, 13);
            this.desc.TabIndex = 1;
            this.desc.Text = "Descrição ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 154);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.preco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precobox);
            this.Controls.Add(this.descbox);
            this.Controls.Add(this.nomebox);
            this.Name = "delup";
            this.Text = "delup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.delup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox precobox;
        private System.Windows.Forms.TextBox descbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label preco;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox nomebox;
    }
}