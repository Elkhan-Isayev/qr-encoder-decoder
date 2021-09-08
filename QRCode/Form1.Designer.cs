namespace QRCode
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
			this.btnEncode = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEncode = new System.Windows.Forms.TextBox();
			this.txtDecode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnDecode = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(403, 39);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(75, 23);
			this.btnEncode.TabIndex = 0;
			this.btnEncode.Text = "Encode";
			this.btnEncode.UseVisualStyleBackColor = true;
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox.Location = new System.Drawing.Point(13, 13);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(237, 210);
			this.pictureBox.TabIndex = 2;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(258, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "value";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtEncode
			// 
			this.txtEncode.Location = new System.Drawing.Point(297, 13);
			this.txtEncode.Name = "txtEncode";
			this.txtEncode.Size = new System.Drawing.Size(181, 20);
			this.txtEncode.TabIndex = 4;
			this.txtEncode.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// txtDecode
			// 
			this.txtDecode.Location = new System.Drawing.Point(297, 81);
			this.txtDecode.Name = "txtDecode";
			this.txtDecode.Size = new System.Drawing.Size(181, 20);
			this.txtDecode.TabIndex = 7;
			this.txtDecode.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(258, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "value";
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(403, 107);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.Size = new System.Drawing.Size(75, 23);
			this.btnDecode.TabIndex = 5;
			this.btnDecode.Text = "Decode";
			this.btnDecode.UseVisualStyleBackColor = true;
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 235);
			this.Controls.Add(this.txtDecode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.txtEncode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnEncode);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEncode;
		private System.Windows.Forms.TextBox txtDecode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnDecode;
	}
}

