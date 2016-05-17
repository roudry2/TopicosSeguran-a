namespace Proj_Seguranca
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtChavePrivada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviarFicheiro = new System.Windows.Forms.Button();
            this.txtFicheiro = new System.Windows.Forms.TextBox();
            this.lbFicheiros = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChavePublica = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar ao servidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChavePrivada
            // 
            this.txtChavePrivada.Location = new System.Drawing.Point(11, 22);
            this.txtChavePrivada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChavePrivada.Multiline = true;
            this.txtChavePrivada.Name = "txtChavePrivada";
            this.txtChavePrivada.Size = new System.Drawing.Size(383, 94);
            this.txtChavePrivada.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(63, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(20, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(607, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 34);
            this.panel1.TabIndex = 5;
            // 
            // btnEnviarFicheiro
            // 
            this.btnEnviarFicheiro.Location = new System.Drawing.Point(781, 379);
            this.btnEnviarFicheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarFicheiro.Name = "btnEnviarFicheiro";
            this.btnEnviarFicheiro.Size = new System.Drawing.Size(117, 27);
            this.btnEnviarFicheiro.TabIndex = 8;
            this.btnEnviarFicheiro.Text = "Enviar Ficheiro";
            this.btnEnviarFicheiro.UseVisualStyleBackColor = true;
            // 
            // txtFicheiro
            // 
            this.txtFicheiro.Location = new System.Drawing.Point(304, 379);
            this.txtFicheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFicheiro.Multiline = true;
            this.txtFicheiro.Name = "txtFicheiro";
            this.txtFicheiro.Size = new System.Drawing.Size(472, 114);
            this.txtFicheiro.TabIndex = 9;
            // 
            // lbFicheiros
            // 
            this.lbFicheiros.FormattingEnabled = true;
            this.lbFicheiros.ItemHeight = 16;
            this.lbFicheiros.Location = new System.Drawing.Point(12, 12);
            this.lbFicheiros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbFicheiros.Name = "lbFicheiros";
            this.lbFicheiros.Size = new System.Drawing.Size(149, 308);
            this.lbFicheiros.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(667, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 22);
            this.txtNome.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID: #...";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Gerar Chaves (Privada /  Publica)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChavePrivada);
            this.groupBox1.Location = new System.Drawing.Point(168, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chave Privada";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChavePublica);
            this.groupBox2.Location = new System.Drawing.Point(168, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 133);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chave Publica";
            // 
            // txtChavePublica
            // 
            this.txtChavePublica.Location = new System.Drawing.Point(5, 25);
            this.txtChavePublica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChavePublica.Multiline = true;
            this.txtChavePublica.Name = "txtChavePublica";
            this.txtChavePublica.Size = new System.Drawing.Size(383, 94);
            this.txtChavePublica.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbFicheiros);
            this.Controls.Add(this.txtFicheiro);
            this.Controls.Add(this.btnEnviarFicheiro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtChavePrivada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviarFicheiro;
        private System.Windows.Forms.TextBox txtFicheiro;
        private System.Windows.Forms.ListBox lbFicheiros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChavePublica;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}

