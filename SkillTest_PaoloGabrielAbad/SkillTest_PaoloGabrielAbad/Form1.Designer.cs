
namespace SkillTest_PaoloGabrielAbad
{
    partial class form_Sorter
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.sort_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Output = new System.Windows.Forms.Label();
            this.comboBox_SelectSortingType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Letters:";
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(127, 31);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(346, 20);
            this.textBox_Input.TabIndex = 1;
            // 
            // sort_Button
            // 
            this.sort_Button.Location = new System.Drawing.Point(341, 76);
            this.sort_Button.Name = "sort_Button";
            this.sort_Button.Size = new System.Drawing.Size(132, 25);
            this.sort_Button.TabIndex = 2;
            this.sort_Button.Text = "Sort";
            this.sort_Button.UseVisualStyleBackColor = true;
            this.sort_Button.Click += new System.EventHandler(this.sort_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sorted Letters Would Be:";
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(171, 132);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(0, 13);
            this.label_Output.TabIndex = 4;
            // 
            // comboBox_SelectSortingType
            // 
            this.comboBox_SelectSortingType.FormattingEnabled = true;
            this.comboBox_SelectSortingType.Location = new System.Drawing.Point(127, 76);
            this.comboBox_SelectSortingType.Name = "comboBox_SelectSortingType";
            this.comboBox_SelectSortingType.Size = new System.Drawing.Size(158, 21);
            this.comboBox_SelectSortingType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sorting Type:";
            // 
            // form_Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 176);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_SelectSortingType);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sort_Button);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form_Sorter";
            this.Text = "String Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button sort_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.ComboBox comboBox_SelectSortingType;
        private System.Windows.Forms.Label label3;
    }
}

