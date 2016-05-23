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
            this.txtBothKeys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEnviarFicheiro = new System.Windows.Forms.Button();
            this.lbFicheiros = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChavePublica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.tbSymmetricKeyEncrtypted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSymmentricKey = new System.Windows.Forms.TextBox();
            this.tbSymmetricKeyDecrypted = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar ao servidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBothKeys
            // 
            this.txtBothKeys.Location = new System.Drawing.Point(11, 22);
            this.txtBothKeys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBothKeys.Multiline = true;
            this.txtBothKeys.Name = "txtBothKeys";
            this.txtBothKeys.Size = new System.Drawing.Size(383, 94);
            this.txtBothKeys.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_Status);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(260, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 34);
            this.panel1.TabIndex = 5;
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.Red;
            this.panel_Status.Location = new System.Drawing.Point(67, 10);
            this.panel_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(17, 17);
            this.panel_Status.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(315, 7);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(163, 22);
            this.txtNome.TabIndex = 11;
            // 
            // btnEnviarFicheiro
            // 
            this.btnEnviarFicheiro.Enabled = false;
            this.btnEnviarFicheiro.Location = new System.Drawing.Point(201, 271);
            this.btnEnviarFicheiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnviarFicheiro.Name = "btnEnviarFicheiro";
            this.btnEnviarFicheiro.Size = new System.Drawing.Size(113, 27);
            this.btnEnviarFicheiro.TabIndex = 8;
            this.btnEnviarFicheiro.Text = "Enviar Ficheiro";
            this.btnEnviarFicheiro.UseVisualStyleBackColor = true;
            // 
            // lbFicheiros
            // 
            this.lbFicheiros.FormattingEnabled = true;
            this.lbFicheiros.ItemHeight = 16;
            this.lbFicheiros.Location = new System.Drawing.Point(11, 38);
            this.lbFicheiros.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lbFicheiros.Name = "lbFicheiros";
            this.lbFicheiros.Size = new System.Drawing.Size(304, 228);
            this.lbFicheiros.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(29, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 27);
            this.button2.TabIndex = 13;
            this.button2.Text = "Gerar Chaves (Privada /  Publica)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBothKeys);
            this.groupBox1.Location = new System.Drawing.Point(15, 232);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(403, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chave Privada / Chave Publica";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtChavePublica);
            this.groupBox2.Location = new System.Drawing.Point(15, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(403, 133);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chave Publica";
            // 
            // txtChavePublica
            // 
            this.txtChavePublica.Enabled = false;
            this.txtChavePublica.Location = new System.Drawing.Point(5, 25);
            this.txtChavePublica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChavePublica.Multiline = true;
            this.txtChavePublica.Name = "txtChavePublica";
            this.txtChavePublica.Size = new System.Drawing.Size(383, 94);
            this.txtChavePublica.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Lista de Ficheiros enviados:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(11, 271);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Escolher Ficheiro ...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbFicheiros);
            this.groupBox3.Controls.Add(this.btnEnviarFicheiro);
            this.groupBox3.Location = new System.Drawing.Point(437, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(324, 303);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ficheiros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 22;
            this.label5.Text = "Client Side";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(773, 94);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 33);
            this.button5.TabIndex = 23;
            this.button5.Text = "Encript";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbSymmetricKeyEncrtypted
            // 
            this.tbSymmetricKeyEncrtypted.Location = new System.Drawing.Point(773, 181);
            this.tbSymmetricKeyEncrtypted.Margin = new System.Windows.Forms.Padding(5);
            this.tbSymmetricKeyEncrtypted.Multiline = true;
            this.tbSymmetricKeyEncrtypted.Name = "tbSymmetricKeyEncrtypted";
            this.tbSymmetricKeyEncrtypted.Size = new System.Drawing.Size(409, 110);
            this.tbSymmetricKeyEncrtypted.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(769, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Encrypted Symmetric Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Text:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(769, 131);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Encrypted Text:";
            // 
            // tbSymmentricKey
            // 
            this.tbSymmentricKey.Location = new System.Drawing.Point(825, 59);
            this.tbSymmentricKey.Margin = new System.Windows.Forms.Padding(5);
            this.tbSymmentricKey.Name = "tbSymmentricKey";
            this.tbSymmentricKey.Size = new System.Drawing.Size(397, 22);
            this.tbSymmentricKey.TabIndex = 27;
            // 
            // tbSymmetricKeyDecrypted
            // 
            this.tbSymmetricKeyDecrypted.Location = new System.Drawing.Point(773, 358);
            this.tbSymmetricKeyDecrypted.Margin = new System.Windows.Forms.Padding(5);
            this.tbSymmetricKeyDecrypted.Name = "tbSymmetricKeyDecrypted";
            this.tbSymmetricKeyDecrypted.Size = new System.Drawing.Size(397, 22);
            this.tbSymmetricKeyDecrypted.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(773, 316);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 33);
            this.button6.TabIndex = 29;
            this.button6.Text = "Decrypt";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 401);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbSymmetricKeyDecrypted);
            this.Controls.Add(this.tbSymmentricKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSymmetricKeyEncrtypted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Client Side";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBothKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnviarFicheiro;
        private System.Windows.Forms.ListBox lbFicheiros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChavePublica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbSymmetricKeyEncrtypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSymmentricKey;
        private System.Windows.Forms.TextBox tbSymmetricKeyDecrypted;
        private System.Windows.Forms.Button button6;
    }
}

