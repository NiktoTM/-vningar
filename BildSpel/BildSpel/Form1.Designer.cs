
namespace BildSpel
{
    partial class Form1
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
            System.Windows.Forms.Button Starta;
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            Starta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Starta
            // 
            Starta.AutoSize = true;
            Starta.BackColor = System.Drawing.Color.Green;
            Starta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Starta.ForeColor = System.Drawing.Color.Black;
            Starta.Location = new System.Drawing.Point(250, 309);
            Starta.Name = "Starta";
            Starta.Size = new System.Drawing.Size(113, 49);
            Starta.TabIndex = 1;
            Starta.Text = "Starta ";
            Starta.UseVisualStyleBackColor = false;
            Starta.Click += new System.EventHandler(this.Starta_Click);
            Starta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Starta_MouseClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(290, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(231, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "Game the Game";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Green;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(438, 310);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 49);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Text
            // 
            this.Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text.Location = new System.Drawing.Point(213, 114);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(395, 108);
            this.Text.TabIndex = 3;
            this.Text.Text = "Välkommen spelare I detta spelet ska du komma ihåg ett kort ifrån en samling av k" +
    "ort med hjälp av AI ska programmet gissa fram vilket kort du har valt . Lycka ti" +
    "ll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Exit);
            this.Controls.Add(Starta);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Exit;
        private new System.Windows.Forms.Label Text;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

