namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
			this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
			((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// kryptonComboBox1
			// 
			this.kryptonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.kryptonComboBox1.DropDownWidth = 234;
			this.kryptonComboBox1.IntegralHeight = false;
			this.kryptonComboBox1.Items.AddRange(new object[] {
            "qef",
            "egawrtg\t3",
            "qwrghwrg"});
			this.kryptonComboBox1.Location = new System.Drawing.Point(178, 111);
			this.kryptonComboBox1.Name = "kryptonComboBox1";
			this.kryptonComboBox1.Size = new System.Drawing.Size(234, 21);
			this.kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
			this.kryptonComboBox1.TabIndex = 0;
			this.kryptonComboBox1.Text = "kryptonComboBox1";
			this.kryptonComboBox1.Validated += new System.EventHandler(this.kryptonComboBox1_Validated);
			// 
			// kryptonTextBox1
			// 
			this.kryptonTextBox1.Location = new System.Drawing.Point(192, 168);
			this.kryptonTextBox1.Name = "kryptonTextBox1";
			this.kryptonTextBox1.Size = new System.Drawing.Size(100, 23);
			this.kryptonTextBox1.TabIndex = 1;
			this.kryptonTextBox1.Text = "kryptonTextBox1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.kryptonTextBox1);
			this.Controls.Add(this.kryptonComboBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
		private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
	}
}

