using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;
using AForge.Imaging.ComplexFilters;

using System.Windows;



namespace WWW
{
   
    public partial class Form : System.Windows.Forms.Form
    {
        Bitmap bitM;
        Bitmap bitM1;
        Bitmap bitW;

        Color[,] c;
        int r1, g1, b1, r2, g2, b2;

        string path;

        public Form()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|.png|Bitmap|.bmp", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[,] c=new Color[pictureBox1.Width,pictureBox1.Height];
            int r1, g1, b1, r2, g2, b2;
            bitM = new Bitmap(pictureBox1.Image);
            bitM1 = new Bitmap(pictureBox1.Image);

            /*for (int y = (pictureBox1.Height / 10) * 9 - 18; y < (pictureBox1.Height / 10) * 9 + 12; y++)

            {
                for (int x = 2; x < pictureBox1.Width - 2; x++)
                {
                    c[x, y] = Color.FromArgb(255, 255, 255);
                }
            }*/

            for (int y = (pictureBox1.Height / 10) * 9 - 18; y < (pictureBox1.Height / 10) * 9 + 12; y++)

            {
                for (int x = 2; x < pictureBox1.Width - 2; x++)
                {

                    r1 = 0;
                    g1 = 0;
                    b1 = 0;
                    r2 = 0;
                    g2 = 0;
                    b2 = 0;

                    /* r1 = bitM.GetPixel(x, y).R;
                     g1 = bitM.GetPixel(x, y).G;
                     b1 = bitM.GetPixel(x, y).B;

                     r2 = bitM.GetPixel(x+1, y).R;
                     g2 = bitM.GetPixel(x+1, y).G;
                     b2 = bitM.GetPixel(x+1, y).B;*/

                    for (int x0 = x - 2; x0 <= x + 2; x0++)
                    {
                        for (int y0 = y - 2; y0 <= y + 2; y0++)
                        {
                            r1 += bitM.GetPixel(x0, y0).R;
                            g1 += bitM.GetPixel(x0, y0).G;
                            b1 += bitM.GetPixel(x0, y0).B;
                        }
                    }
                    r1 /= 25;
                    g1 /= 25;
                    b1 /= 25;





                    /* if ((r1>200) && (g1 > 200) && (b1 > 200) && (r1-r2 >W-10) && (g1-g2 >W- 10) && (b1-b2 >W- 10)
                         && (r1 - r2 < W + 10) && (g1 - g2 < W + 10) && (b1 - b2 < W + 10))
                     {*/
                    /*r1 += W;
                    g1 += W;
                    b1 += W;

                    r2 += W;
                    g2 += W;
                    b2 += W;*/

                    if (r1 < 0) r1 = 0;
                    if (g1 < 0) g1 = 0;
                    if (b1 < 0) b1 = 0;
                    if (r2 < 0) r2 = 0;
                    if (g2 < 0) g2 = 0;
                    if (b2 < 0) b2 = 0;

                    if (r1 > 255) r1 = 255;
                    if (g1 > 255) g1 = 255;
                    if (b1 > 255) b1 = 255;
                    if (r2 > 255) r2 = 255;
                    if (g2 > 255) g2 = 255;
                    if (b2 > 255) b2 = 255;

                    c[x,y] = Color.FromArgb(r1, g1, b1);
                    
                    /*if ((r1<r2) && (g1<g2) && (b1<b2))
                    {                         
                        c=Color.FromArgb(r1,g1,b1);
                        bitM.SetPixel(x,y,c);

                        c = Color.FromArgb(r2, g2, b2);
                        bitM.SetPixel(x+1, y, c);

                    }*/
                    /*if ((r1 > r2) && (g1 > g2) && (b1 > b2))
                    {
                        c = Color.FromArgb(r2, g2, b2);
                        bitM.SetPixel(x, y, c);

                        c = Color.FromArgb(r1, g1, b1);
                        bitM.SetPixel(x + 1, y, c);

                    }*/

                    // }



                }
                

            }

            for (int y = (pictureBox1.Height / 10) * 9 - 18; y < (pictureBox1.Height / 10) * 9 + 12; y++)

            {
                for (int x = 2; x < pictureBox1.Width - 2; x++)
                {
                    bitM.SetPixel(x, y, c[x, y]);
                }
            }

            /*for (int p = 0; p < 2; p++)
            {
                for (int y = (pictureBox1.Height / 10) * 9 - 18; y <= (pictureBox1.Height / 10) * 9 + 12; y++)

                {
                    for (int x = 0; x < pictureBox1.Width; x++)
                    {
                        r1 = 0;
                        g1 = 0;
                        b1 = 0;
                        r2 = 0;
                        g2 = 0;
                        b2 = 0;
                        r1 = 2 * bitM.GetPixel(x, y).R;
                        g1 = 2 * bitM.GetPixel(x, y).G;
                        b1 = 2 * bitM.GetPixel(x, y).B;

                        r1 += bitM1.GetPixel(x, y).R+2;
                        g1 += bitM1.GetPixel(x, y).G+2;
                        b1 += bitM1.GetPixel(x, y).B+2;

                        r1 /= 3;
                        g1 /= 3;
                        b1 /= 3;

                        if (r1 >= 255) r1 = 254;
                        if (g1 >= 255) g1 = 254;
                        if (b1 >= 255) b1 = 254;
                        c[x,y] = Color.FromArgb(r1, g1, b1);
                        bitM.SetPixel(x, y, c[x,y]);
                    }

                }
            }*/
            //bitM.Transforms.Sharpen(95);

            /*for (int y = 0; y < pictureBox1.Height; y++)

            {
                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    c[x, y] = bitM.GetPixel(x,y);
                    c[x, y] = Color.FromArgb(0, 0, c[x, y].B);
                    bitM.SetPixel(x,y, c[x, y]);
                }
            }*/
                    pictureBox1.Image = bitM;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int r1, g1, b1;
            bitM = new Bitmap(pictureBox1.Image);

            //pictureBox2.Image = Image.FromFile(@"X:\Downloads\final.png");
            bitW = new Bitmap(pictureBox2.Image);
            for (int i = 0; i < pictureBox1.Width / bitW.Width; i++)
            {
                for (int x = 0; x < bitW.Width; x++)
                {
                    for (int y = 0; y < bitW.Height; y++)
                    {
                        if ((bitW.GetPixel(x, y).R == 0) && (bitW.GetPixel(x, y).G == 0) && (bitW.GetPixel(x, y).B == 0))
                        {


                            r1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).R+70;
                            g1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).G+70;
                            b1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).B;


                            if (r1 > 255) r1 = 255;
                            if (g1 > 255) g1 = 255;
                            if (b1 > 255) b1 = 255;

                            bitM.SetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9-30, Color.FromArgb(r1, g1, b1));
                        }

                    }
                }
            }



            pictureBox1.Image = bitM;



            /*// pictureBox1.Image = DoF(new Sharpen());
            using (Image image = Image.FromFile(@"X:\Downloads\dddd4.jpeg"))
            //using (Image image = pictureBox1.Image)
            using (Image watermarkImage = Image.FromFile(@"X:\Downloads\1111.png"))
            using (Graphics imageGraphics = Graphics.FromImage(image))
            using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
            {
                int x = 0;
                int y = (pictureBox1.Height / 9) * 10-18; //    H/13*14
                watermarkBrush.TranslateTransform(x, y);
                imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new System.Drawing.Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));
                image.Save(@"X:\Downloads\Desert_watermark.jpg");
            } */

            /* string firstText = "Hello";
             string secondText = "World";

             PointF firstLocation = new PointF(10f, 10f);
             PointF secondLocation = new PointF(10f, 50f);

             string imageFilePath = @"X:\Downloads\dddd4.jpeg";

             Bitmap bitmap = (Bitmap)Image.FromFile(imageFilePath);//load the image file

             using (Graphics graphics = Graphics.FromImage(bitmap))
             {
                 using (Font arialFont = new Font("Arial", 10))
                 {
                     graphics.DrawString(firstText, arialFont, Brushes.Blue, firstLocation);
                     graphics.DrawString(secondText, arialFont, Brushes.Red, secondLocation);
                 }
             }
             //string fff= @"X:\Downloads\ttt.jpg";
             bitmap.Save(@"X:\Downloads\ttt.jpg");//save the image file */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void watermarkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory();

            Directory.CreateDirectory(path + @"\Watermarking");
            string[] names = Directory.GetFiles(path+@"\Water", "*.jpg");


            for (int g = 0; g < names.Length; g++)
            {
                pictureBox1.Image = Image.FromFile(names[g]);

                c = new Color[pictureBox1.Width, pictureBox1.Height];

                bitM = new Bitmap(pictureBox1.Image);
                bitM1 = new Bitmap(pictureBox1.Image);

                int r1, g1, b1;
                bitM = new Bitmap(pictureBox1.Image);

                //pictureBox2.Image = Image.FromFile(@"X:\Downloads\final.png");
                bitW = new Bitmap(pictureBox2.Image);
                for (int i = 0; i < pictureBox1.Width / bitW.Width; i++)
                {
                    for (int x = 0; x < bitW.Width; x++)
                    {
                        for (int y = 0; y < bitW.Height; y++)
                        {
                            if ((bitW.GetPixel(x, y).R == 0) && (bitW.GetPixel(x, y).G == 0) && (bitW.GetPixel(x, y).B == 0))
                            {


                                r1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).R + 70;
                                g1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).G + 70;
                                b1 = bitM.GetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30).B ;


                                if (r1 > 255) r1 = 255;
                                if (g1 > 255) g1 = 255;
                                if (b1 > 255) b1 = 255;

                                bitM.SetPixel(x + i * bitW.Width, y + (pictureBox1.Height / 10) * 9 - 30, Color.FromArgb(r1, g1, b1));
                            }

                        }
                    }
                }


                    pictureBox1.Image = bitM;

                    pictureBox1.Image.Save(path + @"\Watermarking\" + g + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }

            private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
            {

            }

            private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
            {

            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }

            private void fileToolStripMenuItem_Click(object sender, EventArgs e)
            {
                path = Directory.GetCurrentDirectory();

                Directory.CreateDirectory(path+@"\Water");
                string[] names= Directory.GetFiles(path, "*.jpg");


                for (int i=0;i<names.Length;i++)
                {
                    pictureBox1.Image = Image.FromFile(names[i]);

                    c = new Color[pictureBox1.Width, pictureBox1.Height];

                    bitM = new Bitmap(pictureBox1.Image);
                    bitM1 = new Bitmap(pictureBox1.Image);

                    for(int p = 0; p < 3; p++)
                    {
                        for (int y = (pictureBox1.Height / 10) * 9 - 18; y < (pictureBox1.Height / 10) * 9 + 12; y++)

                        {
                            for (int x = 2; x < pictureBox1.Width - 2; x++)
                            {

                                r1 = 0;
                                g1 = 0;
                                b1 = 0;
                                r2 = 0;
                                g2 = 0;
                                b2 = 0;


                                for (int x0 = x - 2; x0 <= x + 2; x0++)
                                {
                                    for (int y0 = y - 2; y0 <= y + 2; y0++)
                                    {
                                        r1 += bitM.GetPixel(x0, y0).R;
                                        g1 += bitM.GetPixel(x0, y0).G;
                                        b1 += bitM.GetPixel(x0, y0).B;
                                    }
                                }
                                r1 /= 25;
                                g1 /= 25;
                                b1 /= 25;







                                if (r1 < 0) r1 = 0;
                                if (g1 < 0) g1 = 0;
                                if (b1 < 0) b1 = 0;
                                if (r2 < 0) r2 = 0;
                                if (g2 < 0) g2 = 0;
                                if (b2 < 0) b2 = 0;

                                if (r1 > 255) r1 = 255;
                                if (g1 > 255) g1 = 255;
                                if (b1 > 255) b1 = 255;
                                if (r2 > 255) r2 = 255;
                                if (g2 > 255) g2 = 255;
                                if (b2 > 255) b2 = 255;

                                c[x, y] = Color.FromArgb(r1, g1, b1);

                            }


                        }

                        for (int y = (pictureBox1.Height / 10) * 9 - 18; y < (pictureBox1.Height / 10) * 9 + 12; y++)

                        {
                            for (int x = 2; x < pictureBox1.Width - 2; x++)
                            {
                                bitM.SetPixel(x, y, c[x, y]);
                            }
                        }
                    }



                    /*for (int y = 0; y < pictureBox1.Height; y++)

                    {
                        for (int x = 0; x < pictureBox1.Width; x++)
                        {
                            c[x, y] = bitM.GetPixel(x,y);
                            c[x, y] = Color.FromArgb(0, 0, c[x, y].B);
                            bitM.SetPixel(x,y, c[x, y]);
                        }
                    }*/




                pictureBox1.Image = bitM;

                pictureBox1.Image.Save(path+@"\Water\"+i+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int j = 4;
            pictureBox1.Image.Save(@"X:\Downloads\dddd"+j+".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            // pictureBox1.Image.Save(@"X:\Downloads", System.Drawing.Imaging.ImageFormat.Jpeg);
            /*Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|.gif|PNG|.png";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.

                    
                    bitM.Save("c:\\button.jpeg", System.Drawing.Imaging.ImageFormat.jpeg);

                    myStream.Close();
                }
            }*/
        }
    }
}

