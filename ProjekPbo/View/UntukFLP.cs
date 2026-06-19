using System;
using System.Drawing;          
using System.Drawing.Drawing2D;
using System.Windows.Forms;    
using System.ComponentModel;

namespace ProjekPbo.View
{
    public class ModernCard : Panel
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Radius { get; set; } = 18;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ShadowColor { get; set; } = Color.FromArgb(25, 0, 0, 0);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = Color.FromArgb(245, 245, 245);

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color NormalColor { get; set; } = Color.White;

        private bool isHover = false;

        public ModernCard()
        {
            this.DoubleBuffered = true;
            this.BackColor = NormalColor;
            this.Padding = new Padding(10);
            this.Margin = new Padding(10);
            this.Cursor = Cursors.Hand;

            this.MouseEnter += (s, e) =>
            {
                isHover = true;
                this.BackColor = HoverColor;
                this.Invalidate();
            };

            this.MouseLeave += (s, e) =>
            {
                isHover = false;
                this.BackColor = NormalColor;
                this.Invalidate();
            };
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 3, this.Height - 3);
            Rectangle shadowRect = new Rectangle(3, 3, this.Width - 3, this.Height - 3);

            using (GraphicsPath shadowPath = GetRoundedRect(shadowRect, Radius))
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(25, 0, 0, 0)))
            {
                e.Graphics.FillPath(shadowBrush, shadowPath);
            }

            using (GraphicsPath path = GetRoundedRect(rect, Radius))
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                this.Region = new Region(path);
                e.Graphics.FillPath(brush, path);

                using (Pen pen = new Pen(ColorTranslator.FromHtml("#B3B3B3"), 4))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            if (d <= 0) d = 1;
            if (d > rect.Width) d = rect.Width;
            if (d > rect.Height) d = rect.Height;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
