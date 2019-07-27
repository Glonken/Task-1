namespace MatkTaskMeometryArea
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ObjectChoice = new System.Windows.Forms.ComboBox();
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.Name3 = new System.Windows.Forms.Label();
            this.Argument1 = new System.Windows.Forms.TextBox();
            this.Argument2 = new System.Windows.Forms.TextBox();
            this.Argument3 = new System.Windows.Forms.TextBox();
            this.AreaSolution = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ObjectChoice
            // 
            this.ObjectChoice.FormattingEnabled = true;
            this.ObjectChoice.Items.AddRange(new object[] {
            "Треугольник",
            "Прямоугольник",
            "Ромб",
            "Параллелограмм",
            "Круг",
            "Трапеция",
            "Эллипс",
            "Выпуклый четырехугольник"});
            this.ObjectChoice.Location = new System.Drawing.Point(31, 76);
            this.ObjectChoice.Name = "ObjectChoice";
            this.ObjectChoice.Size = new System.Drawing.Size(121, 21);
            this.ObjectChoice.TabIndex = 0;
            this.ObjectChoice.SelectedIndexChanged += new System.EventHandler(this.ObjectChoice_SelectedIndexChanged);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(31, 127);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(0, 13);
            this.Name1.TabIndex = 1;
            this.Name1.Visible = false;
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Location = new System.Drawing.Point(31, 157);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(0, 13);
            this.Name2.TabIndex = 2;
            this.Name2.Visible = false;
            // 
            // Name3
            // 
            this.Name3.AutoSize = true;
            this.Name3.Location = new System.Drawing.Point(31, 184);
            this.Name3.Name = "Name3";
            this.Name3.Size = new System.Drawing.Size(0, 13);
            this.Name3.TabIndex = 3;
            this.Name3.Visible = false;
            // 
            // Argument1
            // 
            this.Argument1.Location = new System.Drawing.Point(146, 124);
            this.Argument1.Name = "Argument1";
            this.Argument1.Size = new System.Drawing.Size(100, 20);
            this.Argument1.TabIndex = 4;
            this.Argument1.Visible = false;
            // 
            // Argument2
            // 
            this.Argument2.Location = new System.Drawing.Point(146, 154);
            this.Argument2.Name = "Argument2";
            this.Argument2.Size = new System.Drawing.Size(100, 20);
            this.Argument2.TabIndex = 5;
            this.Argument2.Visible = false;
            // 
            // Argument3
            // 
            this.Argument3.Location = new System.Drawing.Point(146, 181);
            this.Argument3.Name = "Argument3";
            this.Argument3.Size = new System.Drawing.Size(100, 20);
            this.Argument3.TabIndex = 6;
            this.Argument3.Visible = false;
            // 
            // AreaSolution
            // 
            this.AreaSolution.Location = new System.Drawing.Point(14, 240);
            this.AreaSolution.Name = "AreaSolution";
            this.AreaSolution.Size = new System.Drawing.Size(138, 22);
            this.AreaSolution.TabIndex = 7;
            this.AreaSolution.Text = "Найти площадь";
            this.AreaSolution.UseVisualStyleBackColor = true;
            this.AreaSolution.Click += new System.EventHandler(this.AreaSolution_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(28, 40);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(236, 13);
            this.Label.TabIndex = 8;
            this.Label.Text = "Выберите геометрическую фигуру из списка";
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Location = new System.Drawing.Point(193, 245);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(0, 13);
            this.Solution.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.AreaSolution);
            this.Controls.Add(this.Argument3);
            this.Controls.Add(this.Argument2);
            this.Controls.Add(this.Argument1);
            this.Controls.Add(this.Name3);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.ObjectChoice);
            this.Name = "MainForm";
            this.Text = "Площадь геометрическх фигур";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ObjectChoice;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Name3;
        private System.Windows.Forms.TextBox Argument1;
        private System.Windows.Forms.TextBox Argument2;
        private System.Windows.Forms.TextBox Argument3;
        private System.Windows.Forms.Button AreaSolution;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Solution;
    }
}

