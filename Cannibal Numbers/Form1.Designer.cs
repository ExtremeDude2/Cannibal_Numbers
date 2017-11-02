namespace Cannibal_Numbers
{
    partial class Cannibal_Numbers
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
            this.textBox_in = new System.Windows.Forms.TextBox();
            this.textBox_query = new System.Windows.Forms.TextBox();
            this.textBox_out = new System.Windows.Forms.TextBox();
            this.inLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.queryLabel = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_in
            // 
            this.textBox_in.Location = new System.Drawing.Point(12, 29);
            this.textBox_in.Name = "textBox_in";
            this.textBox_in.Size = new System.Drawing.Size(100, 20);
            this.textBox_in.TabIndex = 1;
            // 
            // textBox_query
            // 
            this.textBox_query.Location = new System.Drawing.Point(12, 68);
            this.textBox_query.Name = "textBox_query";
            this.textBox_query.Size = new System.Drawing.Size(100, 20);
            this.textBox_query.TabIndex = 2;
            // 
            // textBox_out
            // 
            this.textBox_out.Location = new System.Drawing.Point(172, 29);
            this.textBox_out.Name = "textBox_out";
            this.textBox_out.Size = new System.Drawing.Size(100, 20);
            this.textBox_out.TabIndex = 3;
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Location = new System.Drawing.Point(13, 13);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(34, 13);
            this.inLabel.TabIndex = 4;
            this.inLabel.Text = "Input:";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(237, 12);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(42, 13);
            this.outLabel.TabIndex = 5;
            this.outLabel.Text = "Output:";
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(13, 52);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(38, 13);
            this.queryLabel.TabIndex = 6;
            this.queryLabel.Text = "Query:";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(105, 94);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 22);
            this.button_go.TabIndex = 7;
            this.button_go.Text = "Go!";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // Cannibal_Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.queryLabel);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.textBox_out);
            this.Controls.Add(this.textBox_query);
            this.Controls.Add(this.textBox_in);
            this.Name = "Cannibal_Numbers";
            this.Text = "Cannibal Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_in;
        private System.Windows.Forms.TextBox textBox_query;
        private System.Windows.Forms.TextBox textBox_out;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.Button button_go;
    }
}

