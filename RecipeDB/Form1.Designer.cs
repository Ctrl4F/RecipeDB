namespace RecipeDB
{
    partial class Cookbook
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
            this.listRecipe = new System.Windows.Forms.ListBox();
            this.listIngredent = new System.Windows.Forms.ListBox();
            this.Ingredints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe";
            // 
            // listRecipe
            // 
            this.listRecipe.FormattingEnabled = true;
            this.listRecipe.Location = new System.Drawing.Point(90, 92);
            this.listRecipe.Name = "listRecipe";
            this.listRecipe.Size = new System.Drawing.Size(120, 173);
            this.listRecipe.TabIndex = 1;
            this.listRecipe.SelectedIndexChanged += new System.EventHandler(this.listRecipe_SelectedIndexChanged);
            // 
            // listIngredent
            // 
            this.listIngredent.FormattingEnabled = true;
            this.listIngredent.Location = new System.Drawing.Point(259, 92);
            this.listIngredent.Name = "listIngredent";
            this.listIngredent.Size = new System.Drawing.Size(120, 173);
            this.listIngredent.TabIndex = 2;
            // 
            // Ingredints
            // 
            this.Ingredints.AutoSize = true;
            this.Ingredints.Location = new System.Drawing.Point(256, 63);
            this.Ingredints.Name = "Ingredints";
            this.Ingredints.Size = new System.Drawing.Size(59, 13);
            this.Ingredints.TabIndex = 3;
            this.Ingredints.Text = "Ingredinets";
            // 
            // Cookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Ingredints);
            this.Controls.Add(this.listIngredent);
            this.Controls.Add(this.listRecipe);
            this.Controls.Add(this.label1);
            this.Name = "Cookbook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cookbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRecipe;
        private System.Windows.Forms.ListBox listIngredent;
        private System.Windows.Forms.Label Ingredints;
    }
}

