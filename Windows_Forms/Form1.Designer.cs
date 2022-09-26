namespace Windows_Forms
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
            this.btn_clickme = new System.Windows.Forms.Button();
            this.textLabel = new System.Windows.Forms.Label();
            this.Cordinates = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.Buton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clickme
            // 
            this.btn_clickme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clickme.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clickme.Location = new System.Drawing.Point(345, 167);
            this.btn_clickme.Name = "btn_clickme";
            this.btn_clickme.Size = new System.Drawing.Size(129, 71);
            this.btn_clickme.TabIndex = 0;
            this.btn_clickme.Text = "Click me";
            this.btn_clickme.UseVisualStyleBackColor = true;
            this.btn_clickme.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_clickme_MouseDown);
            // 
            // textLabel
            // 
            this.textLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel.Location = new System.Drawing.Point(314, 66);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(190, 77);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Emin Novruz";
            // 
            // Cordinates
            // 
            this.Cordinates.AutoSize = true;
            this.Cordinates.Location = new System.Drawing.Point(15, 10);
            this.Cordinates.Name = "Cordinates";
            this.Cordinates.Size = new System.Drawing.Size(38, 15);
            this.Cordinates.TabIndex = 2;
            this.Cordinates.Text = "label1";
            // 
            // Clock
            // 
            this.Clock.Font = new System.Drawing.Font("Swis721 Cn BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clock.Location = new System.Drawing.Point(334, 280);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(245, 83);
            this.Clock.TabIndex = 3;
            this.Clock.Text = "Clock: ";
            // 
            // Buton
            // 
            this.Buton.Location = new System.Drawing.Point(121, 167);
            this.Buton.Name = "Buton";
            this.Buton.Size = new System.Drawing.Size(132, 71);
            this.Buton.TabIndex = 4;
            this.Buton.Text = "ColorChanger";
            this.Buton.UseVisualStyleBackColor = true;
            this.Buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buton);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.Cordinates);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.btn_clickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_clickme;
        private Label textLabel;
        private Label Cordinates;
        private Label Clock;
        private Button Buton;
        private Button button1;
    }
}