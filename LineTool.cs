namespace WinFormsLab
{
    public class LineTool : Tool
    {
        private Point beginningPoint;
        private bool isDrawing = false;
        private Pen pen;
        private Graphics graphics;
        private DirectBitmap lineBitmap;
        private float zoomScale;

        public LineTool(DirectBitmap bitmap, PictureBox canvas, Pen pen, float zoomScale) : base(bitmap, canvas) 
        {
            this.pen = new Pen(pen.Color, pen.Width);
            this.zoomScale = zoomScale;
            InitializeGraphics();
        }

        private void InitializeGraphics()
        {
            if (lineBitmap != null)
            {
                lineBitmap.Dispose();
                graphics.Dispose();
            }

            lineBitmap = new DirectBitmap(bitmap.Width, bitmap.Height);
            graphics = Graphics.FromImage(lineBitmap.Bitmap);
            graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            beginningPoint = NewMousePosition(e.Location);
            isDrawing = true;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = NewMousePosition(e.Location);
                graphics.Clear(Color.Transparent);
                graphics.DrawImage(bitmap.Bitmap, 0, 0);

                DrawLine(graphics, beginningPoint.X, beginningPoint.Y, currentPoint.X, currentPoint.Y, pen);
                canvas.Image = lineBitmap.Bitmap;
                canvas.Invalidate();
            }
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point endPoint = NewMousePosition(e.Location);
                DrawLine(bitmap, beginningPoint.X, beginningPoint.Y, endPoint.X, endPoint.Y, pen.Color);
                graphics.Clear(Color.Transparent);
                graphics.DrawImage(bitmap.Bitmap, 0, 0);
                canvas.Image = bitmap.Bitmap;
                canvas.Refresh();
                isDrawing = false;
            }
        }

        public void UpdatePen(Pen newPen)
        {
            if (this.pen != null)
            {
                this.pen.Dispose();
            }

            this.pen = new Pen(newPen.Color, newPen.Width);
            InitializeGraphics();
        }

        private Point NewMousePosition(Point point)
        {
            return new Point((int)(point.X / zoomScale), (int)(point.Y / zoomScale));
        }

        public override void UpdateZoomScale(float newZoomScale)
        {
            zoomScale = newZoomScale;
        }

        private void DrawLine(Graphics g, int x, int y, int x2, int y2, Pen pen)
        {
            g.DrawLine(this.pen, x, y, x2, y2);
        }

        //https://stackoverflow.com/questions/62651042/how-to-implement-bresenhams-line-algorithm-in-c-when-trying-to-draw-a-line-in-b
        private void DrawLine(DirectBitmap bmp, int x, int y, int x2, int y2, Color color)
        {
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;

            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;

            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);

            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }

            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                bmp.SetPixel(x, y, color);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }
    }
}
