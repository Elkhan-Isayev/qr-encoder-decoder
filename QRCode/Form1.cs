using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void PictureBox_Click(object sender, EventArgs e)
		{

		}

		private void btnEncode_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "JPEG|*.jpg", ValidateNames = true})
			{
				if(sfd.ShowDialog() == DialogResult.OK)
				{
					MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
					encoder.QRCodeScale = 8;
					Bitmap bmp = encoder.Encode(txtEncode.Text);
					pictureBox.Image = bmp;
					bmp.Save(sfd.FileName, ImageFormat.Jpeg);
				}
			}
		}

		private void btnDecode_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
			{
				if(ofd.ShowDialog() == DialogResult.OK)
				{
					pictureBox.Image = Image.FromFile(ofd.FileName);
					MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
					txtDecode.Text = decoder.Decode(new QRCodeBitmapImage(pictureBox.Image as Bitmap));
				}
			}
		}
	}
}