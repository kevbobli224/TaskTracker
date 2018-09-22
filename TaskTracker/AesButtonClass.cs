using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TaskTracker
{
    public enum FStyles { Minimize, Close, LeftArrow, Blank, Plus, Pause, Play };
    class AesButtonClass : Button
    {
        public Color ButtonColor { get; set; } = Color.FromArgb(88, 88, 88);
        public Point ButtonLocation { get; set; }
        public FStyles Styles { get; set; } = FStyles.Blank;
        public int shades = 30;
        public override string Text { get; set; } = string.Empty;
        public bool Transparent { get; set; } = false;

        private SolidBrush brush;
        private Color AesColor;
        private Size drawSize;
        private Point[] drawingPoints;
        
        public AesButtonClass()
        {
            
            this.ButtonColor = Color.FromArgb(88, 88, 88);
            this.Size = new Size(80, 80);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = ButtonColor;
            this.AesColor = Shader(ButtonColor, shades);
            this.brush = new SolidBrush(AesColor);
            this.Margin = new Padding(0,0,0,0);
            
        }
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            
        }
        private Color Shader(Color c, int shades)
        {
            int R, G, B;
            R = c.R - shades;
            G = c.G - shades;
            B = c.B - shades;
            Color newColor = Color.FromArgb(R, G, B);
            return newColor;
        }

        private Point[] CloseSymbol(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            //Here comes the calamity
            tracker.Y += y;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            tracker.Y += y;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            Point point3 = new Point(tracker.X, tracker.Y);
            tracker.Y -= y;
            Point point4 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y -= y;
            Point point5 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            tracker.Y -= y;
            Point point6 = new Point(tracker.X, tracker.Y);
            tracker.Y -= y;
            Point point7 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            Point point8 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y += y;
            Point point9 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y -= y;
            Point point10 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            Point point11 = new Point(tracker.X, tracker.Y);
            tracker.Y += y;
            Point point12 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            tracker.Y += y;
            Point point13 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y += y;
            Point point14 = new Point(tracker.X, tracker.Y);
            tracker.Y += y;
            Point point15 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            Point point16 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = {point1, point2, point3, point4, point5, point6,
                point7, point8, point9, point10, point11, point12, point13, point14,
                point15, point16};
            return pPoints;
        }

        private Point[] MinimizeSymbol(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X -= x;
            tracker.Y += y;
            tracker.Y += dpp.Height/2;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y -= y;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.X += 4 * x;
            Point point3 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y += y;
            Point point4 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = { point1, point2, point3, point4 };
            return pPoints;
        }

        private Point[] LeftArrowSymbol(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X += x/2;
            Point point0 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            tracker.Y -= y;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            tracker.Y -= y;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.X -= 2 * x;
            tracker.Y += 2 * y;
            Point point3 = new Point(tracker.X, tracker.Y);
            tracker.X += 2 * x;
            tracker.Y += 2 * y;
            Point point4 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            tracker.Y -= y;
            Point point5 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = { point0, point1, point2, point3, point4, point5};
            return pPoints;
        }

        private Point[] PlusSymbol(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X -= x/2;
            tracker.Y -= y/2;
            Point point0 = new Point(tracker.X, tracker.Y);
            tracker.Y -= y;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.Y += y;
            Point point3 = new Point(tracker.X, tracker.Y);
            tracker.X += x;
            Point point4 = new Point(tracker.X, tracker.Y);
            tracker.Y += y;
            Point point5 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            Point point6 = new Point(tracker.X, tracker.Y);
            tracker.Y += y;
            Point point7 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            Point point8 = new Point(tracker.X, tracker.Y);
            tracker.Y -= y;
            Point point9 = new Point(tracker.X, tracker.Y);
            tracker.X -= x;
            Point point10 = new Point(tracker.X, tracker.Y);
            tracker.Y -= y;
            Point point11 = new Point(tracker.X, tracker.Y);

            Point[] pPoints = { point0, point1, point2, point3, point4, point5 ,
            point6, point7, point8, point9, point10, point11};
            return pPoints;
        }
        private Point[] PauseSymbol1(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X -= 3*((x / 2) + 1);
            tracker.Y -= 3*((y / 2) + 1);
            Point point0 = new Point(tracker.X, tracker.Y);
            tracker.Y += 3*y;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X += (x / 2) + x;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.Y -= 3*y;
            Point point3 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = { point0, point1, point2, point3 };
            return pPoints;
        }
        private Point[] PauseSymbol2(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X += 3 * ((x / 2) + 1);
            tracker.Y -= 3 * ((y / 2) + 1);
            Point point0 = new Point(tracker.X, tracker.Y);
            tracker.Y += 3 * y;
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X -= (x / 2) + x;
            Point point2 = new Point(tracker.X, tracker.Y);
            tracker.Y -= 3 * y;
            Point point3 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = { point0, point1, point2, point3 };
            return pPoints;
        }
        private Point[] PlaySymbol(Point origin, Size dpp)
        {
            Point tracker = origin;
            int x = dpp.Width;
            int y = dpp.Height;

            tracker.X -= 3 * ((x / 2) + 1);
            tracker.Y -= 3 * ((y / 2) + 1);
            Point point0 = new Point(tracker.X, tracker.Y);
            tracker.X += 6 * ((x / 2) + 1);
            tracker.Y += 3 * ((y / 2) + 1);
            Point point1 = new Point(tracker.X, tracker.Y);
            tracker.X -= 6 * ((x / 2) + 1);
            tracker.Y += 3 * ((y / 2) + 1);
            Point point2 = new Point(tracker.X, tracker.Y);
            Point[] pPoints = { point0, point1, point2 };
            return pPoints;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            this.ButtonLocation = new Point(this.Width / 2, this.Height / 2);
            this.drawSize = new Size((this.Width - 10) / 5, (this.Height - 10) / 5);
            base.OnPaint(pevent);
            if (this.Styles == FStyles.Close)
            {
                drawingPoints = CloseSymbol(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
            }
            else if(this.Styles == FStyles.Minimize)
            {
                drawingPoints = MinimizeSymbol(ButtonLocation, drawSize);
                this.Multidrawer(drawingPoints, 1, pevent);
            }
            else if(this.Styles == FStyles.LeftArrow)
            {
                drawingPoints = LeftArrowSymbol(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
            }
            else if (this.Styles == FStyles.Plus)
            {
                drawingPoints = PlusSymbol(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
            }
            else if(this.Styles == FStyles.Pause)
            {
                drawingPoints = PauseSymbol1(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
                drawingPoints = PauseSymbol2(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
            }
            else if (this.Styles == FStyles.Play)
            {
                drawingPoints = PlaySymbol(ButtonLocation, drawSize);
                this.FillPolygonPoint(pevent);
            }
        }

        public void FillPolygonPoint(PaintEventArgs e)
        {
            e.Graphics.FillPolygon(brush, drawingPoints);
        }

        public void Multidrawer(Point[] p, int template, PaintEventArgs e)
        {
            GraphicsPath g = new GraphicsPath();
            if (template == 1)
            {
                g.AddLine(p[0], p[1]);
                g.AddArc(p[1].X, p[1].Y - drawSize.Height * 2, p[2].X - p[1].X, drawSize.Height*4, 0, -180);
                g.AddLine(p[2], p[3]);
                g.AddArc(p[0].X, p[0].Y - drawSize.Height, p[3].X - p[0].X, drawSize.Height*2, 0, -180);
                e.Graphics.FillPath(brush, g);
                //e.Graphics.DrawPath(new Pen(brush), g);
            }
            if (template == 2)
            {
               
            }

        }
    }

}
