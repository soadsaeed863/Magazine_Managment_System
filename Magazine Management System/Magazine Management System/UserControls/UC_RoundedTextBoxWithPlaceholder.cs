using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.IO;

    namespace Magazine_Management_System.UserControls
    {
        public partial class UC_RoundedTextBoxWithPlaceholder : UserControl
        {
            private TextBox textBox;
            private string placeholderText = "Search...";
            private bool isPlaceholder = true;
            private PictureBox searchIcon;

            // Constructor
            public UC_RoundedTextBoxWithPlaceholder()
            {
            var names = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var name in names)
            {
                MessageBox.Show(name); // or use Console.WriteLine(name); if it's a console app
            }
            InitializeComponent();
                textBox = new TextBox();
                textBox.BorderStyle = BorderStyle.None;
                textBox.Location = new Point(30, 5); // Adjust location to make space for the icon
                textBox.Width = this.Width - 35; // Adjust width to make space for the icon
                textBox.ForeColor = Color.Gray;
                textBox.Text = placeholderText;
                textBox.GotFocus += RemovePlaceholder;
                textBox.LostFocus += SetPlaceholder;
                this.Controls.Add(textBox);

            searchIcon = new PictureBox();
            searchIcon.Image = LoadImageFromResource("Magazine_Management_System.Resources.searchicon.png");
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.Location = new Point(5, 5);
            searchIcon.Size = new Size(20, 20);
            this.Controls.Add(searchIcon);

            this.Paint += new PaintEventHandler(DrawRoundedRectangle);
            }

            private void RemovePlaceholder(object sender, EventArgs e)
            {
                if (isPlaceholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    isPlaceholder = false;
                }
            }

            private void SetPlaceholder(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                    isPlaceholder = true;
                }
            }

            private void DrawRoundedRectangle(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black, 2);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, 10, 10, 180, 90);
                    path.AddArc(this.Width - 10, 0, 10, 10, 270, 90);
                    path.AddArc(this.Width - 10, this.Height - 10, 10, 10, 0, 90);
                    path.AddArc(0, this.Height - 10, 10, 10, 90, 90);
                    path.CloseFigure();
                    g.DrawPath(pen, path);
                }
            }


        private Image LoadImageFromResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                    throw new ArgumentException($"Resource '{resourceName}' not found.");
                return Image.FromStream(stream);
            }
        }

    }
}


