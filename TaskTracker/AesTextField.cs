using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskTracker
{
    class AesTextField: RichTextBox
    {
        public Color BackColour { get; set; }
        public override int MaxLength { get; set; } = 32;

        
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int WM_MOUSEWHEEL = 0x20A;
        private const int WM_PAINT = 0x00F;


        public int lineOffset = 0;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                using (Graphics g = base.CreateGraphics())
                {
                    Point p = new Point();
                    int h = TextRenderer.MeasureText("Testj", this.Font).Height;
                    lineOffset = h - (p.Y % h);
                    for (int x = lineOffset; x < Height; x += h)
                    {
                        Color underlineColor = Shader(BackColor, 30, false);
                        g.DrawLine(new Pen(underlineColor, 2), 0, x, Width, x);
                    }
                    Parent.Invalidate();
                }
            }
        }

        public AesTextField() : base()
        {
            BorderStyle = BorderStyle.None;
            this.BackColor = SystemColors.WindowFrame;
            this.Multiline = false;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            
        }

        private Color Shader(Color c, int shades, bool updown)
        {
            int R, G, B;
            if (updown)
            {
                R = c.R + shades;
                G = c.G + shades;
                B = c.B + shades;
                Color newColor = Color.FromArgb(R, G, B);
                return newColor;
            }
            else
            {
                R = c.R - shades;
                G = c.G - shades;
                B = c.B - shades;
                Color newColor = Color.FromArgb(R, G, B);
                return newColor;
            }
        }
    }
}
