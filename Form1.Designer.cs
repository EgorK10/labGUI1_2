
namespace labGUI1_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_clear = new System.Windows.Forms.Button();
            this.task = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nums = new System.Windows.Forms.TextBox();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_clear.BackgroundImage = global::labGUI1_2.Properties.Resources.trash;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Location = new System.Drawing.Point(519, 158);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 44);
            this.button_clear.TabIndex = 16;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // task
            // 
            this.task.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.task.AutoSize = true;
            this.task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.task.Location = new System.Drawing.Point(52, 9);
            this.task.Margin = new System.Windows.Forms.Padding(0);
            this.task.MaximumSize = new System.Drawing.Size(510, 115);
            this.task.Name = "task";
            this.task.Size = new System.Drawing.Size(500, 110);
            this.task.TabIndex = 15;
            this.task.Text = resources.GetString("task.Text");
            this.task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_answer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_answer.Location = new System.Drawing.Point(98, 274);
            this.label_answer.MaximumSize = new System.Drawing.Size(280, 100);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(2, 20);
            this.label_answer.TabIndex = 14;
            this.label_answer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Последовательность цифр:\r\n";
            // 
            // Nums
            // 
            this.Nums.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nums.Location = new System.Drawing.Point(277, 167);
            this.Nums.MaxLength = 18;
            this.Nums.Name = "Nums";
            this.Nums.Size = new System.Drawing.Size(236, 27);
            this.Nums.TabIndex = 10;
            this.Nums.TextChanged += new System.EventHandler(this.Nums_TextChanged);
            this.Nums.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nums_KeyPress);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(277, 225);
            this.numericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(45, 23);
            this.numericUpDown.TabIndex = 17;
            this.numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown.Visible = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Количество соседних цифр:\r\n";
            this.label2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(590, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.task);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nums);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label task;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nums;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label2;
    }
}

