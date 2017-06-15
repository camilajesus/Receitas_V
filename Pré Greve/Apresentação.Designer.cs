namespace Pré_Greve
{
    partial class Apresentação
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
            this.btnsair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnapre = new System.Windows.Forms.Button();
            this.btnvolta = new System.Windows.Forms.Button();
            this.cmbescolha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.Control;
            this.btnsair.BackgroundImage = global::Pré_Greve.Properties.Resources.sair;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsair.Location = new System.Drawing.Point(508, 3);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(52, 32);
            this.btnsair.TabIndex = 6;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hora da Apresentação";
            // 
            // btnapre
            // 
            this.btnapre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapre.Location = new System.Drawing.Point(116, 247);
            this.btnapre.Name = "btnapre";
            this.btnapre.Size = new System.Drawing.Size(93, 56);
            this.btnapre.TabIndex = 8;
            this.btnapre.Text = "Apresentar";
            this.btnapre.UseVisualStyleBackColor = true;
            this.btnapre.Click += new System.EventHandler(this.btnapre_Click);
            // 
            // btnvolta
            // 
            this.btnvolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolta.Location = new System.Drawing.Point(326, 247);
            this.btnvolta.Name = "btnvolta";
            this.btnvolta.Size = new System.Drawing.Size(93, 56);
            this.btnvolta.TabIndex = 9;
            this.btnvolta.Text = "Voltar a estudar";
            this.btnvolta.UseVisualStyleBackColor = true;
            this.btnvolta.Click += new System.EventHandler(this.btnvolta_Click);
            // 
            // cmbescolha
            // 
            this.cmbescolha.FormattingEnabled = true;
            this.cmbescolha.Items.AddRange(new object[] {
            "Bolo de Cenoura",
            "Bolo de Chocolate",
            "Mousse de Maracujá",
            "Torta Holandesa"});
            this.cmbescolha.Location = new System.Drawing.Point(179, 142);
            this.cmbescolha.Name = "cmbescolha";
            this.cmbescolha.Size = new System.Drawing.Size(240, 21);
            this.cmbescolha.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Escolha a apresentação:";
            // 
            // Apresentação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 359);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbescolha);
            this.Controls.Add(this.btnvolta);
            this.Controls.Add(this.btnapre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Apresentação";
            this.Text = "Apresentação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnapre;
        private System.Windows.Forms.Button btnvolta;
        private System.Windows.Forms.ComboBox cmbescolha;
        private System.Windows.Forms.Label label2;
    }
}