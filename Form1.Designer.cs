namespace AS2324.Antonio.Russo._3G.es2.lab.form
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
            textNum1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(743, 127);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            // 
            // textNum1
            // 
            textNum1.Location = new Point(590, 128);
            textNum1.Name = "textNum1";
            textNum1.Size = new Size(125, 27);
            textNum1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(501, 136);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(590, 255);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Conteggio :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(590, 205);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Somma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(590, 295);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Media :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 527);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNum1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Antonio.Russo.calcolo numeri somma media";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textNum1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}