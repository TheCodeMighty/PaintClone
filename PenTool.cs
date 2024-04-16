namespace WinFormsLab
{
    public class PenTool : Tool
    {
        private Point previousPoint;
        private Pen pen;
        private bool isDrawing;
        private float zoomScale;

        public PenTool(DirectBitmap bitmap, PictureBox canvas, Pen pen, float zoomScale) : base(bitmap, canvas)
        {
            this.pen = new Pen(pen.Color, pen.Width);
            this.zoomScale = zoomScale;
        }

        private Point NewMousePosition(Point point)
        {
            return new Point((int)(point.X / zoomScale), (int)(point.Y / zoomScale));
        }

        public override void UpdateZoomScale(float newZoomScale)
        {
            zoomScale = newZoomScale;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            previousPoint = NewMousePosition(e.Location);
            isDrawing = true;
        }

        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                Point currentPoint = NewMousePosition(e.Location);
                DrawLine(bitmap, previousPoint.X, previousPoint.Y, currentPoint.X, currentPoint.Y, pen.Color);
                previousPoint = currentPoint;
                canvas.Image = bitmap.Bitmap;
                canvas.Refresh();
            }
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        public void UpdatePen(Pen newPen)
        {
            if (this.pen != null)
            {
                this.pen.Dispose();
            }
                
            this.pen = new Pen(newPen.Color, newPen.Width);
        }

        //https://stackoverflow.com/questions/62651042/how-to-implement-bresenhams-line-algorithm-in-c-when-trying-to-draw-a-line-in-b
        private void DrawLine(DirectBitmap bmp, int x, int y, int x2, int y2, Color color)
        {
            int dx = Math.Abs(x2 - x), sx = x < x2 ? 1 : -1;
            int dy = -Math.Abs(y2 - y), sy = y < y2 ? 1 : -1;
            int err = dx + dy, e2;

            while (true)
            {
                if (x >= 0 && x < bmp.Width && y >= 0 && y < bmp.Height)
                {
                    bmp.SetPixel(x, y, color);
                }
                if (x == x2 && y == y2) break;
                e2 = 2 * err;
                if (e2 >= dy) { err += dy; x += sx; }
                if (e2 <= dx) { err += dx; y += sy; }
            }
        }
    }
}
