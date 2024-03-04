namespace WinFormsApp1
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
            sideA = new TextBox();
            sideB = new TextBox();
            sideC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Button1 = new Button();
            SuspendLayout();
            // 
            // sideA
            // 
            sideA.Location = new Point(118, 85);
            sideA.Name = "sideA";
            sideA.Size = new Size(205, 31);
            sideA.TabIndex = 0;
            // 
            // sideB
            // 
            sideB.Location = new Point(118, 122);
            sideB.Name = "sideB";
            sideB.Size = new Size(205, 31);
            sideB.TabIndex = 1;
            // 
            // sideC
            // 
            sideC.Location = new Point(118, 159);
            sideC.Name = "sideC";
            sideC.Size = new Size(205, 31);
            sideC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 88);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 3;
            label1.Text = "a = ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 125);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 4;
            label2.Text = "b = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 162);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 5;
            label3.Text = "c = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 39);
            label4.Name = "label4";
            label4.Size = new Size(312, 25);
            label4.TabIndex = 6;
            label4.Text = "Введите длины сторон треугольника";
            // 
            // Button1
            // 
            Button1.Location = new Point(207, 216);
            Button1.Name = "Button1";
            Button1.Size = new Size(149, 34);
            Button1.TabIndex = 7;
            Button1.Text = "Проверка";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 292);
            Controls.Add(Button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sideC);
            Controls.Add(sideB);
            Controls.Add(sideA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sideA;
        private TextBox sideB;
        private TextBox sideC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Button1;
    }
}
