using System.Drawing.Drawing2D;

namespace WinFormsLab
{
    public class SelectionTool : Tool
    {
        public Rectangle selectionField;
        private bool isSelecting = false;
        private Point beginningPoint;
        private float zoomScale;
        private ToolStripStatusLabel selectionStatusBarLabel;
        public event Action<string> UpdateStatusText;

        public SelectionTool(DirectBitmap bitmap, PictureBox canvas, float zoomScale, ToolStripStatusLabel selectionStatusBarLabel) : base(bitmap, canvas) 
        {
            this.zoomScale = zoomScale;
            this.selectionStatusBarLabel = selectionStatusBarLabel;
        }

        public override void MouseDown(object sender, MouseEventArgs e)
        {
            beginningPoint = UnzoomPoint(e.Location);
            selectionField.Location = beginningPoint;
            selectionField.Size = new Size();
            isSelecting = true;
            canvas.Invalidate();
        }

        //https://www.codeproject.com/Questions/341482/Crop-area-selection-control-like-photoshops-in-csh
        public override void MouseMove(object sender, MouseEventArgs e)
        {
            if (isSelecting)
            {
                Point currentPoint = UnzoomPoint(e.Location);
                int x1 = Math.Min(beginningPoint.X, currentPoint.X);
                int y1 = Math.Min(beginningPoint.Y, currentPoint.Y);
                int x2 = Math.Max(beginningPoint.X, currentPoint.X);
                int y2 = Math.Max(beginningPoint.Y, currentPoint.Y);

                selectionField.Location = new Point(x1, y1);
                selectionField.Size = new Size(x2 - x1, y2 - y1);
                UpdateSelectionStatusLabel(x1, y1, x2, y2);
                canvas.Invalidate();
            }
        }

        public override void MouseUp(object sender, MouseEventArgs e)
        {
            isSelecting = false;
            UpdateSelectionStatusLabel(selectionField.Left, selectionField.Top, selectionField.Right, selectionField.Bottom);
            canvas.Invalidate();
        }

        public override void Paint(Graphics g)
        {
            if (!selectionField.Size.IsEmpty)
            {
                Rectangle zoomedRect = new Rectangle(
                    ZoomPoint(selectionField.Location).X,
                    ZoomPoint(selectionField.Location).Y,
                    (int)(selectionField.Width * zoomScale),
                    (int)(selectionField.Height * zoomScale));

                Color rectangleColor = isSelecting ? Color.Black : Color.Blue;
                using (var pen = new Pen(rectangleColor, 2) { DashStyle = DashStyle.Dash })
                {
                    g.DrawRectangle(pen, zoomedRect);
                }
            }
        }

        private Point UnzoomPoint(Point point)
        {
            return new Point((int)(point.X / zoomScale), (int)(point.Y / zoomScale));
        }

        private Point ZoomPoint(Point point)
        {
            return new Point((int)(point.X * zoomScale), (int)(point.Y * zoomScale));
        }

        public override void UpdateZoomScale(float newZoomScale)
        {
            zoomScale = newZoomScale;
        }

        public void SelectAll()
        {
            selectionField = new Rectangle(0, 0, (int)(canvas.Width / zoomScale), (int)(canvas.Height / zoomScale));
            isSelecting = false;
            canvas.Invalidate();
        }

        private void UpdateSelectionStatusLabel(int x1, int y1, int x2, int y2)
        {
            string statusText = $"S({x1}, {y1}), E({x2}, {y2}), Size({x2 - x1}, {y2 - y1})";
            selectionStatusBarLabel.Text = statusText;
        }
    }
}
