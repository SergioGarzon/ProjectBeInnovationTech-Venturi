
namespace Automatizador
{
    partial class FormularioEmail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEmail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNombres = new System.Windows.Forms.ComboBox();
            this.txtBetechGmail = new System.Windows.Forms.TextBox();
            this.btnBeTechGmail = new System.Windows.Forms.Button();
            this.txtVenturiGmail = new System.Windows.Forms.TextBox();
            this.txtBetech = new System.Windows.Forms.TextBox();
            this.txtVenturi = new System.Windows.Forms.TextBox();
            this.btnVenturiGmail = new System.Windows.Forms.Button();
            this.btnBetech = new System.Windows.Forms.Button();
            this.btnVenturi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlEmailCopiado = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 57);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 27);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(718, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 61);
            this.button1.TabIndex = 19;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select name:";
            // 
            // cmbNombres
            // 
            this.cmbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombres.FormattingEnabled = true;
            this.cmbNombres.Location = new System.Drawing.Point(325, 79);
            this.cmbNombres.Name = "cmbNombres";
            this.cmbNombres.Size = new System.Drawing.Size(366, 28);
            this.cmbNombres.TabIndex = 2;
            this.cmbNombres.SelectedIndexChanged += new System.EventHandler(this.cmbNombres_SelectedIndexChanged);
            // 
            // txtBetechGmail
            // 
            this.txtBetechGmail.Enabled = false;
            this.txtBetechGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetechGmail.Location = new System.Drawing.Point(236, 154);
            this.txtBetechGmail.Multiline = true;
            this.txtBetechGmail.Name = "txtBetechGmail";
            this.txtBetechGmail.Size = new System.Drawing.Size(352, 32);
            this.txtBetechGmail.TabIndex = 4;
            // 
            // btnBeTechGmail
            // 
            this.btnBeTechGmail.BackColor = System.Drawing.Color.LightGreen;
            this.btnBeTechGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBeTechGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeTechGmail.Location = new System.Drawing.Point(614, 143);
            this.btnBeTechGmail.Name = "btnBeTechGmail";
            this.btnBeTechGmail.Size = new System.Drawing.Size(119, 48);
            this.btnBeTechGmail.TabIndex = 5;
            this.btnBeTechGmail.Text = "Copy";
            this.btnBeTechGmail.UseVisualStyleBackColor = false;
            this.btnBeTechGmail.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtVenturiGmail
            // 
            this.txtVenturiGmail.Enabled = false;
            this.txtVenturiGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenturiGmail.Location = new System.Drawing.Point(236, 222);
            this.txtVenturiGmail.Multiline = true;
            this.txtVenturiGmail.Name = "txtVenturiGmail";
            this.txtVenturiGmail.Size = new System.Drawing.Size(352, 32);
            this.txtVenturiGmail.TabIndex = 8;
            // 
            // txtBetech
            // 
            this.txtBetech.Enabled = false;
            this.txtBetech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBetech.Location = new System.Drawing.Point(236, 289);
            this.txtBetech.Multiline = true;
            this.txtBetech.Name = "txtBetech";
            this.txtBetech.Size = new System.Drawing.Size(352, 32);
            this.txtBetech.TabIndex = 12;
            // 
            // txtVenturi
            // 
            this.txtVenturi.Enabled = false;
            this.txtVenturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenturi.Location = new System.Drawing.Point(236, 359);
            this.txtVenturi.Multiline = true;
            this.txtVenturi.Name = "txtVenturi";
            this.txtVenturi.Size = new System.Drawing.Size(352, 32);
            this.txtVenturi.TabIndex = 16;
            // 
            // btnVenturiGmail
            // 
            this.btnVenturiGmail.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenturiGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenturiGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenturiGmail.Location = new System.Drawing.Point(614, 211);
            this.btnVenturiGmail.Name = "btnVenturiGmail";
            this.btnVenturiGmail.Size = new System.Drawing.Size(119, 48);
            this.btnVenturiGmail.TabIndex = 9;
            this.btnVenturiGmail.Text = "Copy";
            this.btnVenturiGmail.UseVisualStyleBackColor = false;
            this.btnVenturiGmail.Click += new System.EventHandler(this.btnVenturiGmail_Click);
            // 
            // btnBetech
            // 
            this.btnBetech.BackColor = System.Drawing.Color.LightGreen;
            this.btnBetech.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBetech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetech.Location = new System.Drawing.Point(614, 278);
            this.btnBetech.Name = "btnBetech";
            this.btnBetech.Size = new System.Drawing.Size(119, 48);
            this.btnBetech.TabIndex = 13;
            this.btnBetech.Text = "Copy";
            this.btnBetech.UseVisualStyleBackColor = false;
            this.btnBetech.Click += new System.EventHandler(this.btnBetech_Click);
            // 
            // btnVenturi
            // 
            this.btnVenturi.BackColor = System.Drawing.Color.LightGreen;
            this.btnVenturi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenturi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenturi.Location = new System.Drawing.Point(614, 348);
            this.btnVenturi.Name = "btnVenturi";
            this.btnVenturi.Size = new System.Drawing.Size(119, 48);
            this.btnVenturi.TabIndex = 17;
            this.btnVenturi.Text = "Copy";
            this.btnVenturi.UseVisualStyleBackColor = false;
            this.btnVenturi.Click += new System.EventHandler(this.btnVenturi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BeTech gmail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Venturi gmail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Betech:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Venturi:";
            // 
            // pnlEmailCopiado
            // 
            this.pnlEmailCopiado.BackColor = System.Drawing.Color.Black;
            this.pnlEmailCopiado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEmailCopiado.BackgroundImage")));
            this.pnlEmailCopiado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmailCopiado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmailCopiado.Location = new System.Drawing.Point(307, 474);
            this.pnlEmailCopiado.Name = "pnlEmailCopiado";
            this.pnlEmailCopiado.Size = new System.Drawing.Size(229, 58);
            this.pnlEmailCopiado.TabIndex = 20;
            this.pnlEmailCopiado.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 48);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(748, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 48);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(748, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 48);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(748, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 48);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormularioEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 529);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlEmailCopiado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVenturi);
            this.Controls.Add(this.btnBetech);
            this.Controls.Add(this.btnVenturiGmail);
            this.Controls.Add(this.txtVenturi);
            this.Controls.Add(this.txtBetech);
            this.Controls.Add(this.txtVenturiGmail);
            this.Controls.Add(this.btnBeTechGmail);
            this.Controls.Add(this.txtBetechGmail);
            this.Controls.Add(this.cmbNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioEmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNombres;
        private System.Windows.Forms.TextBox txtBetechGmail;
        private System.Windows.Forms.Button btnBeTechGmail;
        private System.Windows.Forms.TextBox txtVenturiGmail;
        private System.Windows.Forms.TextBox txtBetech;
        private System.Windows.Forms.TextBox txtVenturi;
        private System.Windows.Forms.Button btnVenturiGmail;
        private System.Windows.Forms.Button btnBetech;
        private System.Windows.Forms.Button btnVenturi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlEmailCopiado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}