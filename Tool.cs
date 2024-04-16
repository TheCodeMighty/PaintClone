namespace WinFormsLab
{
    public abstract class Tool
    {
        protected DirectBitmap bitmap;
        protected PictureBox canvas;

        public Tool(DirectBitmap bitmap, PictureBox canvas)
        {
            this.bitmap = bitmap;
            this.canvas = canvas;
        }

        public abstract void MouseDown(object sender, MouseEventArgs e);
        public abstract void MouseMove(object sender, MouseEventArgs e);
        public abstract void MouseUp(object sender, MouseEventArgs e);

        public virtual void Paint(Graphics g) { }

        public virtual void UpdateZoomScale(float newZoomScale) { }

        public virtual void AttachEvents()
        {
            canvas.MouseDown += MouseDown;
            canvas.MouseMove += MouseMove;
            canvas.MouseUp += MouseUp;
            canvas.Paint += Canvas_Paint;
        }

        protected virtual void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Paint(e.Graphics);
        }

        public virtual void DetachEvents()
        {
            canvas.MouseDown -= MouseDown;
            canvas.MouseMove -= MouseMove;
            canvas.MouseUp -= MouseUp;
            canvas.Paint -= Canvas_Paint;
        }
    }
}
