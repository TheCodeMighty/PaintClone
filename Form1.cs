using PaintClone;

namespace WinFormsLab
{
    public partial class Form1 : Form
    {
        private string lastFileName;
        private DirectBitmap bitmap;       
        public float zoomScale = 1.0f;
        private Tool currentTool;
        private Color currentToolColor = Color.Black;
        private Pen pen = new Pen(Color.Black, 2);
        Rectangle? rectangle;
        Color lastPickedColor;
        private IniHandler iniFile;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Gray;
            Canvas.BackColor = Color.White;
            bitmap = new DirectBitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = bitmap.Bitmap;
            Canvas.Size = new Size((int)(bitmap.Width * zoomScale), (int)(bitmap.Height * zoomScale));
            canvasPanel.AutoScrollMinSize = new Size(Canvas.Width, Canvas.Height);
            CanvasSizeDisplay();
            DisplayCurrentZoom();
            currentTool = new PenTool(bitmap, Canvas, pen, zoomScale);
            Canvas.MouseWheel += Canvas_MouseWheel;
            Canvas.MouseEnter += Canvas_MouseEnter;
            Canvas.Paint += Canvas_Paint;
            DoubleBuffered = true;
            SubscribeUpperButtons();
            SubscribeBottomButtons();
            CreateNewCanvas();
            Canvas.MouseMove += Canvas_MouseMove_1;
            Canvas.MouseLeave += Canvas_MouseLeave;
            iniFile = new IniHandler(GetIniPath("RecentFiles.ini"));
            LoadRecentFiles();
        }

        private void newMenuItem_Click(object sender, EventArgs e)
        {
            NewCanvasForm newCanvasForm = new NewCanvasForm();

            if (newCanvasForm.ShowDialog() == DialogResult.OK)
            {
                int width = newCanvasForm.SelectedWidth;
                int height = newCanvasForm.SelectedHeight;
                Color backgroundColor = newCanvasForm.NewBackgroundColor;

                PictureBox newCanvas = new PictureBox
                {
                    Width = width,
                    Height = height,
                    Location = new Point(5, 5),
                    BackColor = backgroundColor
                };
                newCanvas.Padding = new Padding(5);

                if (Canvas != null)
                {
                    Canvas.MouseWheel -= Canvas_MouseWheel;
                    Canvas.MouseEnter -= Canvas_MouseEnter;
                    Canvas.Paint -= Canvas_Paint;
                    canvasPanel.Controls.Remove(Canvas);
                    Canvas.Dispose();
                }

                canvasPanel.Controls.Remove(Canvas);
                Canvas.Dispose();
                newCanvas.MouseMove += Canvas_MouseMove_1;
                newCanvas.MouseLeave += Canvas_MouseLeave;
                Canvas = newCanvas;

                bitmap?.Dispose();
                bitmap = new DirectBitmap(width, height);
                using (Graphics g = Graphics.FromImage(bitmap.Bitmap))
                {
                    g.Clear(backgroundColor);
                }
                Canvas.Image = bitmap.Bitmap;

                Canvas.MouseWheel += Canvas_MouseWheel;
                Canvas.MouseEnter += Canvas_MouseEnter;
                Canvas.Paint += Canvas_Paint;

                CanvasSizeDisplay();

                if (currentTool != null)
                {
                    currentTool.DetachEvents();
                }
                InitializeCurrentTool();
                canvasPanel.Controls.Add(Canvas);
                Canvas.BringToFront();
                canvasPanel.Refresh();
            }
        }

        private void InitializeCurrentTool()
        {
            if (currentTool != null)
            {
                currentTool.DetachEvents();
                if (currentTool is SelectionTool selectionTool)
                {
                    selectionTool.UpdateStatusText -= UpdateStatusText;
                }
            }

            if (currentTool is PenTool)
            {
                currentTool = new PenTool(bitmap, Canvas, pen, zoomScale);
            }
            else if (currentTool is LineTool)
            {
                currentTool = new LineTool(bitmap, Canvas, pen, zoomScale);
            }
            else if (currentTool is SelectionTool)
            {
                var tool = new SelectionTool(bitmap, Canvas, zoomScale, selectionStatusBarLabel);
                tool.UpdateStatusText += UpdateStatusText;
                currentTool = tool;
            }

            currentTool.AttachEvents();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JPEG|*.jpeg|PNG|*.png|Bitmap|*.bmp|All Files|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lastFileName = openFileDialog.FileName;
                UpdateRecentFiles(lastFileName);

                bitmap?.Dispose();

                using (var tempBitmap = new Bitmap(lastFileName))
                {
                    bitmap = new DirectBitmap(tempBitmap.Width, tempBitmap.Height);
                    using (Graphics g = Graphics.FromImage(bitmap.Bitmap))
                    {
                        g.Clear(Color.White);
                        g.DrawImage(tempBitmap, 0, 0);
                    }
                }

                Canvas.Image = bitmap.Bitmap;
                Canvas.Width = bitmap.Width;
                Canvas.Height = bitmap.Height;
                canvasPanel.AutoScrollMinSize = new Size(bitmap.Width, bitmap.Height);
                Canvas.Invalidate();
                CanvasSizeDisplay();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastFileName))
            {
                SaveCanvas(lastFileName);
                UpdateRecentFiles(lastFileName);
            }
            else
            {
                saveAsMenuItem_Click(sender, e);
            }
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPEG|*.jpeg|PNG|*.png|Bitmap|*.bmp|All Files|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lastFileName = saveFileDialog.FileName;
                    SaveCanvas(lastFileName);
                    UpdateRecentFiles(lastFileName);
                }
            }
        }

        private void printMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            ClearRecentFiles();
            this.Close();
        }
        private void Canvas_MouseMove_1(object sender, MouseEventArgs e)
        {
            Point newPoint = e.Location;
            if (newPoint.X >= 0 && newPoint.Y >= 0 && newPoint.X < Canvas.Width && newPoint.Y < Canvas.Height)
            {
                currentPositionStatusBarLabel.Text = $"({newPoint.X} x {newPoint.Y}px)";
            }
            else
            {
                currentPositionStatusBarLabel.Text = "";
            }

            MouseEventArgs newEventArgs = new MouseEventArgs(e.Button, e.Clicks, newPoint.X, newPoint.Y, e.Delta);
            currentTool.MouseMove(sender, newEventArgs);
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            Point newPoint = e.Location;
            MouseEventArgs newEventArgs = new MouseEventArgs(e.Button, e.Clicks, newPoint.X, newPoint.Y, e.Delta);
            currentTool.MouseDown(sender, newEventArgs);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            Point newPoint = e.Location;
            MouseEventArgs newEventArgs = new MouseEventArgs(e.Button, e.Clicks, newPoint.X, newPoint.Y, e.Delta);
            currentTool.MouseUp(sender, newEventArgs);
            if (currentTool is SelectionTool selectionTool)
            {
                rectangle = selectionTool.selectionField;
            }
        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            currentPositionStatusBarLabel.Text = "";
        }

        private void SaveCanvas(string fileName)
        {
            using (Bitmap savingBitmap = new Bitmap(Canvas.Width, Canvas.Height))
            {
                if (Canvas.BackgroundImage != null)
                {
                    using (Graphics g = Graphics.FromImage(savingBitmap))
                    {
                        g.DrawImage(Canvas.BackgroundImage, new Rectangle(0, 0, savingBitmap.Width, savingBitmap.Height));
                    }
                }

                using (Graphics g = Graphics.FromImage(savingBitmap))
                {
                    g.DrawImage(bitmap.Bitmap, new Rectangle(0, 0, savingBitmap.Width, savingBitmap.Height));
                }

                savingBitmap.Save(lastFileName);
            }
        }

        private void editColorMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentToolColor = colorDialog.Color;
                    pen.Color = currentToolColor;
                    if (currentTool is PenTool penTool)
                    {
                        penTool.UpdatePen(new Pen(currentToolColor, pen.Width));
                    }
                    else if (currentTool is LineTool lineTool)
                    {
                        lineTool.UpdatePen(new Pen(currentToolColor, pen.Width));
                    }
                }
            }
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void CanvasSizeDisplay()
        {
            if (Canvas != null)
            {
                currentCanvasSizeLabel.Text = $"{Canvas.Width}, {Canvas.Height}px";
            }
        }

        private void UpdateZoom(float zoomScale)
        {
            if (currentTool is SelectionTool selectionTool)
            {
                selectionTool.UpdateZoomScale(zoomScale);
            }
            else if (currentTool is PenTool penTool)
            {
                penTool.UpdateZoomScale(zoomScale);
            }
            else if (currentTool is LineTool lineTool)
            {
                lineTool.UpdateZoomScale(zoomScale);
            }
        }

        private void ZoomIn()
        {
            zoomScale *= 1.05f;
            UpdateZoom(zoomScale);
            ApplyZoom();
            DisplayCurrentZoom();
        }

        private void ZoomOut()
        {
            zoomScale /= 1.05f;
            UpdateZoom(zoomScale);
            ApplyZoom();
            DisplayCurrentZoom();
        }

        private void ApplyZoom()
        {
            Canvas.Size = new Size((int)(bitmap.Width * zoomScale), (int)(bitmap.Height * zoomScale));

            canvasPanel.AutoScrollMinSize = new Size(Canvas.Width, Canvas.Height);

            Canvas.Invalidate();
        }

        private void Canvas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomIn();
            }
            else if (e.Delta < 0)
            {
                ZoomOut();
            }
        }

        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            if (!Canvas.Focused)
            {
                Canvas.Focus();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Canvas.BackColor);
            e.Graphics.DrawImage(bitmap.Bitmap, new Rectangle(0, 0, Canvas.Width, Canvas.Height));
            currentTool?.Paint(e.Graphics);
        }

        private void zoomInMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomOutMenuItem_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void resetZoomMenuItem_Click(object sender, EventArgs e)
        {
            zoomScale = 1.0f;
            DisplayCurrentZoom();
            ApplyZoom();
        }

        private void DisplayCurrentZoom()
        {
            currentZoomStatusBarLabel.Text = $"{zoomScale * 100:0}%";
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.DetachEvents();
            }
            currentTool = new LineTool(bitmap, Canvas, new Pen(currentToolColor, pen.Width), zoomScale);
            currentTool.AttachEvents();
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.DetachEvents();
            }

            currentTool = new PenTool(bitmap, Canvas, new Pen(currentToolColor, pen.Width), zoomScale);
            currentTool.AttachEvents();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (currentTool != null)
            {
                currentTool.DetachEvents();
            }

            currentTool = new SelectionTool(bitmap, Canvas, zoomScale, selectionStatusBarLabel);
            currentTool.AttachEvents();
        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            if (!(currentTool is SelectionTool))
            {
                if (currentTool != null)
                {
                    currentTool.DetachEvents();
                }
                currentTool = new SelectionTool(bitmap, Canvas, zoomScale, selectionStatusBarLabel);
                currentTool.AttachEvents();
            }

            if (currentTool is SelectionTool selectionTool)
            {
                selectionTool.SelectAll();
            }
        }

        private void invertColorsMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle? rectangle = null;

            if (currentTool is SelectionTool selectionTool && !selectionTool.selectionField.Size.IsEmpty)
            {
                rectangle = selectionTool.selectionField;
            }

            if (rectangle.HasValue)
            {
                InvertBitmap(rectangle.Value);
            }
            else
            {
                InvertBitmap(new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            }
            InvertCanvasBackColor();
            Canvas.Refresh();
        }

        //https://stackoverflow.com/questions/33024881/invert-image-faster-in-c-sharp
        private void InvertBitmap(Rectangle rectangle)
        {
            for (int y = rectangle.Y; y < rectangle.Y + rectangle.Height; y++)
            {
                for (int x = rectangle.X; x < rectangle.X + rectangle.Width; x++)
                {
                    Color originalColor = bitmap.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(originalColor.A, 255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    bitmap.SetPixel(x, y, invertedColor);
                }
            }
        }

        private void InvertCanvasBackColor()
        {
            Canvas.BackColor = Color.FromArgb(255 - Canvas.BackColor.R, 255 - Canvas.BackColor.G, 255 - Canvas.BackColor.B);
        }

        private void CreateNewCanvas()
        {
            int defaultWidth = 800;
            int defaultHeight = 600;
            Color backgroundColor = Color.White;

            if (Canvas == null)
            {
                Canvas = new PictureBox
                {
                    Width = defaultWidth,
                    Height = defaultHeight,
                    Location = new Point(5, 5),
                    BackColor = backgroundColor,
                    BorderStyle = BorderStyle.FixedSingle
                };
                this.Controls.Add(Canvas);
            }

            bitmap?.Dispose();

            bitmap = new DirectBitmap(defaultWidth, defaultHeight);

            using (Graphics g = Graphics.FromImage(bitmap.Bitmap))
            {
                g.Clear(backgroundColor);
            }

            Canvas.Image = bitmap.Bitmap;

            Canvas.MouseWheel += Canvas_MouseWheel;
            Canvas.MouseEnter += Canvas_MouseEnter;
            Canvas.Paint += Canvas_Paint;

            DisplayCurrentZoom();
            CanvasSizeDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void UpperPaletteButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            lastPickedColor = clickedButton.BackColor;
            lastPickedColorButton.BackColor = lastPickedColor;
            if (currentTool is PenTool penTool)
            {
                penTool.UpdatePen(new Pen(lastPickedColor, pen.Width));
            }
            Canvas.Invalidate();
        }

        private void BottomPaletteButtonClick(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            lastPickedColor = clickedButton.BackColor;
            lastPickedColorButton.BackColor = lastPickedColor;
            if (currentTool is LineTool lineTool)
            {
                lineTool.UpdatePen(new Pen(lastPickedColor, pen.Width));
            }
            Canvas.Invalidate();
        }

        private void SubscribeUpperButtons()
        {
            blackButtonUpperPalette.Click += UpperPaletteButton_Click;
            dimGreyButtonUpperPalette.Click += UpperPaletteButton_Click;
            darkGreyButtonUpperPalette.Click += UpperPaletteButton_Click;
            bdarkRedButtonUpperPalette.Click += UpperPaletteButton_Click;
            darkOrangeButtonUpperPalette.Click += UpperPaletteButton_Click;
            goldButtonUpperPalette.Click += UpperPaletteButton_Click;
            yellowButtonUpperPalette.Click += UpperPaletteButton_Click;
            greenYellowButtonBottomPalette.Click += UpperPaletteButton_Click;
            forestGreenButtonUpperPalette.Click += UpperPaletteButton_Click;
            lightSkyBlueButtonUpperPalette.Click += UpperPaletteButton_Click;
            blueButtonUpperPalette.Click += UpperPaletteButton_Click;
            royalBlueButtonUpperPalette.Click += UpperPaletteButton_Click;
            indigoButtonUpperPalette.Click += UpperPaletteButton_Click;
        }

        private void SubscribeBottomButtons()
        {
            blackButtonBottomPalette.Click += UpperPaletteButton_Click;
            dimGreyButtonBottomPalette.Click += UpperPaletteButton_Click;
            darkGreyButtonBottomPalette.Click += UpperPaletteButton_Click;
            darkRedButtonBottomPalette.Click += UpperPaletteButton_Click;
            darkOrangeButtonBottomPalette.Click += UpperPaletteButton_Click;
            goldButtonBottomPalette.Click += UpperPaletteButton_Click;
            yellowButtonBottomPalette.Click += UpperPaletteButton_Click;
            greenYellowButtonBottomPalette.Click += UpperPaletteButton_Click;
            forestGreenButtonBottomPalette.Click += UpperPaletteButton_Click;
            lightSkyBlueButtonBottomPalette.Click += UpperPaletteButton_Click;
            blueButtonBottomPalette.Click += UpperPaletteButton_Click;
            royalBlueButtonBottomPalette.Click += UpperPaletteButton_Click;
            indigoButtonBottomPalette.Click += UpperPaletteButton_Click;
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }


        //Here starts ini :-(

        private void RecentFileItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                string filePath = menuItem.Tag.ToString();
                if (!string.IsNullOrEmpty(filePath))
                {
                    OpenFile(filePath);
                }
            }
        }

        private void ClearRecentFiles()
        {
            for (int i = 0; i < 10; i++)
            {
                iniFile.Write("RecentFiles", "File" + i, "");
            }
        }

        private void ClearMenuItems()
        {
            foreach (ToolStripMenuItem menuItem in openedFilesMenuItem.DropDownItems)
            {
                menuItem.Click -= openedFilesMenuItem_Click;
            }
            openedFilesMenuItem.DropDownItems.Clear();
        }

        private void LoadRecentFiles()
        {
            openedFilesMenuItem.DropDownItems.Clear();

            for (int i = 0; i < 10; i++)
            {
                string filePath = iniFile.Read("RecentFiles", "File" + i);
                if (!string.IsNullOrEmpty(filePath))
                {
                    ToolStripMenuItem fileItem = new ToolStripMenuItem(Path.GetFileName(filePath));
                    fileItem.Tag = filePath;
                    fileItem.Click += RecentFileItem_Click;
                    openedFilesMenuItem.DropDownItems.Add(fileItem);
                }
            }
        }

        private void openedFilesMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            OpenFile(GetIniPath("RecentFiles.ini"));
        }

        private void OpenFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                TextBox.Text = content;
            }
            catch (Exception ex)
            {
                this.Close();
            }
        }

        private void UpdateRecentFiles(string filePath)
        {
            List<string> files = openedFilesMenuItem.DropDownItems.Cast<ToolStripMenuItem>()
                                      .Select(item => item.Tag.ToString()).ToList();
            files.Remove(filePath);
            files.Insert(0, filePath);

            files = files.Take(10).ToList();

            for (int i = 0; i < files.Count; i++)
            {
                iniFile.Write("RecentFiles", "File" + i, files[i]);
            }
            LoadRecentFiles();
        }

        private static string GetIniPath(string fileName)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, fileName);
            return filePath;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearRecentFiles();

            ClearMenuItems();
        }

        private void UpdateStatusText(string text)
        {
            selectionStatusBarLabel.Text = text;
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            using (About aboutItem = new About())
            {
                aboutItem.ShowDialog();
            }
        }
    }
}
