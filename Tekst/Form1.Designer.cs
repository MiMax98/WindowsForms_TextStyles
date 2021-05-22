
namespace Tekst
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdobduza = new System.Windows.Forms.RadioButton();
            this.rdoduza = new System.Windows.Forms.RadioButton();
            this.rdomala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chxUnderline = new System.Windows.Forms.CheckBox();
            this.chxItalic = new System.Windows.Forms.CheckBox();
            this.chxBold = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdopom = new System.Windows.Forms.RadioButton();
            this.rdoniebieski = new System.Windows.Forms.RadioButton();
            this.rdoczerwony = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj tekst";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 23);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdobduza);
            this.groupBox1.Controls.Add(this.rdoduza);
            this.groupBox1.Controls.Add(this.rdomala);
            this.groupBox1.Location = new System.Drawing.Point(40, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // rdobduza
            // 
            this.rdobduza.AutoSize = true;
            this.rdobduza.Location = new System.Drawing.Point(7, 73);
            this.rdobduza.Name = "rdobduza";
            this.rdobduza.Size = new System.Drawing.Size(89, 19);
            this.rdobduza.TabIndex = 2;
            this.rdobduza.TabStop = true;
            this.rdobduza.Text = "bardzo duża";
            this.rdobduza.UseVisualStyleBackColor = true;
            this.rdobduza.CheckedChanged += new System.EventHandler(this.rdobduza_CheckedChanged);
            // 
            // rdoduza
            // 
            this.rdoduza.AutoSize = true;
            this.rdoduza.Location = new System.Drawing.Point(7, 48);
            this.rdoduza.Name = "rdoduza";
            this.rdoduza.Size = new System.Drawing.Size(50, 19);
            this.rdoduza.TabIndex = 1;
            this.rdoduza.TabStop = true;
            this.rdoduza.Text = "duża";
            this.rdoduza.UseVisualStyleBackColor = true;
            this.rdoduza.CheckedChanged += new System.EventHandler(this.rdoduza_CheckedChanged);
            // 
            // rdomala
            // 
            this.rdomala.AutoSize = true;
            this.rdomala.Location = new System.Drawing.Point(7, 23);
            this.rdomala.Name = "rdomala";
            this.rdomala.Size = new System.Drawing.Size(51, 19);
            this.rdomala.TabIndex = 0;
            this.rdomala.TabStop = true;
            this.rdomala.Text = "mała";
            this.rdomala.UseVisualStyleBackColor = true;
            this.rdomala.CheckedChanged += new System.EventHandler(this.rdomala_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chxUnderline);
            this.groupBox2.Controls.Add(this.chxItalic);
            this.groupBox2.Controls.Add(this.chxBold);
            this.groupBox2.Location = new System.Drawing.Point(240, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 102);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl czcionki";
            // 
            // chxUnderline
            // 
            this.chxUnderline.AutoSize = true;
            this.chxUnderline.Location = new System.Drawing.Point(6, 73);
            this.chxUnderline.Name = "chxUnderline";
            this.chxUnderline.Size = new System.Drawing.Size(93, 19);
            this.chxUnderline.TabIndex = 2;
            this.chxUnderline.Text = "Podkreślenie";
            this.chxUnderline.UseVisualStyleBackColor = true;
            this.chxUnderline.CheckedChanged += new System.EventHandler(this.chxUnderline_CheckedChanged);
            // 
            // chxItalic
            // 
            this.chxItalic.AutoSize = true;
            this.chxItalic.Location = new System.Drawing.Point(6, 48);
            this.chxItalic.Name = "chxItalic";
            this.chxItalic.Size = new System.Drawing.Size(84, 19);
            this.chxItalic.TabIndex = 1;
            this.chxItalic.Text = "Pochylenie";
            this.chxItalic.UseVisualStyleBackColor = true;
            this.chxItalic.CheckedChanged += new System.EventHandler(this.chxItalic_CheckedChanged);
            // 
            // chxBold
            // 
            this.chxBold.AutoSize = true;
            this.chxBold.Location = new System.Drawing.Point(7, 23);
            this.chxBold.Name = "chxBold";
            this.chxBold.Size = new System.Drawing.Size(90, 19);
            this.chxBold.TabIndex = 0;
            this.chxBold.Text = "Pogrubienie";
            this.chxBold.UseVisualStyleBackColor = true;
            this.chxBold.CheckedChanged += new System.EventHandler(this.chxBold_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdopom);
            this.groupBox3.Controls.Add(this.rdoniebieski);
            this.groupBox3.Controls.Add(this.rdoczerwony);
            this.groupBox3.Location = new System.Drawing.Point(440, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 102);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor czcionki";
            // 
            // rdopom
            // 
            this.rdopom.AutoSize = true;
            this.rdopom.Location = new System.Drawing.Point(6, 73);
            this.rdopom.Name = "rdopom";
            this.rdopom.Size = new System.Drawing.Size(106, 19);
            this.rdopom.TabIndex = 2;
            this.rdopom.TabStop = true;
            this.rdopom.Text = "pomarańczowy";
            this.rdopom.UseVisualStyleBackColor = true;
            this.rdopom.CheckedChanged += new System.EventHandler(this.rdopom_CheckedChanged);
            // 
            // rdoniebieski
            // 
            this.rdoniebieski.AutoSize = true;
            this.rdoniebieski.Location = new System.Drawing.Point(7, 48);
            this.rdoniebieski.Name = "rdoniebieski";
            this.rdoniebieski.Size = new System.Drawing.Size(71, 19);
            this.rdoniebieski.TabIndex = 1;
            this.rdoniebieski.TabStop = true;
            this.rdoniebieski.Text = "niebieski";
            this.rdoniebieski.UseVisualStyleBackColor = true;
            this.rdoniebieski.CheckedChanged += new System.EventHandler(this.rdoniebieski_CheckedChanged);
            // 
            // rdoczerwony
            // 
            this.rdoczerwony.AutoSize = true;
            this.rdoczerwony.Location = new System.Drawing.Point(7, 23);
            this.rdoczerwony.Name = "rdoczerwony";
            this.rdoczerwony.Size = new System.Drawing.Size(75, 19);
            this.rdoczerwony.TabIndex = 0;
            this.rdoczerwony.TabStop = true;
            this.rdoczerwony.Text = "czerwony";
            this.rdoczerwony.UseVisualStyleBackColor = true;
            this.rdoczerwony.CheckedChanged += new System.EventHandler(this.rdoczerwony_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(200, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aktualizuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdobduza;
        private System.Windows.Forms.RadioButton rdoduza;
        private System.Windows.Forms.RadioButton rdomala;
        private System.Windows.Forms.CheckBox chxUnderline;
        private System.Windows.Forms.CheckBox chxItalic;
        private System.Windows.Forms.CheckBox chxBold;
        private System.Windows.Forms.RadioButton rdopom;
        private System.Windows.Forms.RadioButton rdoniebieski;
        private System.Windows.Forms.RadioButton rdoczerwony;
    }
}

