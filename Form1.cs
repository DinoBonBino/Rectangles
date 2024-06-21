using Rectangles.Common;
using Rectangles.Models;

namespace Rectangles
{
    public partial class Form1 : Form
    {
        private readonly Logs _logs = new Logs();

        private readonly List<Models.Rectangle> _rectangles;
        private readonly Pen _drawPen;
        private readonly SolidBrush _drawBrush;

        private AppMode _selectedMode;
        private MouseButtons _mouseClickedButton;
        private Color _drawColor;
        private System.Drawing.Point _drawStartLocation;
        private System.Drawing.Point _drawMouseLocation;
        private Models.Rectangle _selectRectangle;

        public Form1()
        {
            InitializeComponent();
            _rectangles = [];
            _drawColor = checkBox1.BackColor;
            _drawPen = new Pen(Color.Black, 2);
            _drawBrush = new SolidBrush(_drawColor);
        }

        private bool IsDrawMode => _selectedMode == AppMode.Draw;
        private bool IsMouseDown => _mouseClickedButton == MouseButtons.Left || _mouseClickedButton == MouseButtons.Right;
        private double DrawTopLeftX => Math.Min(_drawStartLocation.X, _drawMouseLocation.X);
        private double DrawTopLeftY => Math.Min(_drawStartLocation.Y, _drawMouseLocation.Y);
        private double DrawBotRightX => Math.Max(_drawStartLocation.X, _drawMouseLocation.X);
        private double DrawBotRightY => Math.Max(_drawStartLocation.Y, _drawMouseLocation.Y);

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && _selectedMode != AppMode.Draw)
            {
                _selectedMode = AppMode.Draw;
                CheckOnlyOneColor(checkBox1);
                _drawColor = checkBox1.BackColor;
                _selectRectangle = null;
                RefreshPictureBox();
                SetText("Каким цветом рисуем?");
                _logs.Write("The mode has been changed to AppMode.Draw");
            }
            else if (radioButton2.Checked == true && _selectedMode != AppMode.Select)
            {
                _selectedMode = AppMode.Select;
                SetText("Какими цветами выделяем?");
                _logs.Write("The mode has been changed to AppMode.Select");
            }
        }

        private void SetText(string text)
        {
            label1.Text = text;
            label1.Invalidate();
        }

        private void CheckBox_Clicked(object sender, EventArgs e)
        {
            if (IsDrawMode)
            {
                var checkBox = (CheckBox)sender;
                CheckOnlyOneColor(checkBox);
                _drawColor = checkBox.BackColor;
                _logs.Write("Draw in color " + _drawColor.Name);
            }
        }

        private void CheckOnlyOneColor(CheckBox checkBox)
        {
            ClearAllCheckBoxes();
            checkBox.CheckState = CheckState.Checked;
        }

        private void ClearAllCheckBoxes()
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseClickedButton = e.Button;
            _drawStartLocation = e.Location;
            _drawMouseLocation = e.Location;

            if (IsDrawMode)
            {
                return;
            }

            if (_mouseClickedButton == MouseButtons.Left)
            {
                _drawColor = Color.FromArgb(70, 66, 170, 255);
            }
            else if (_mouseClickedButton == MouseButtons.Right)
            {
                _drawColor = Color.FromArgb(70, 128, 255, 0);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                _drawMouseLocation = e.Location;
                RefreshPictureBox();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            var rect = new Models.Rectangle(DrawTopLeftX, DrawTopLeftY, DrawBotRightX, DrawBotRightY, _drawColor);

            if (IsDrawMode)
            {
                _rectangles.Add(rect);
                _logs.Write("A new ractangle has been added to canvas. Rect:" + rect);
            }
            else
            {
                if (_mouseClickedButton == MouseButtons.Left)
                {
                    TrySetSelectedRactangle(rect, rect.Contains);
                }
                else if(_mouseClickedButton == MouseButtons.Right)
                {
                    TrySetSelectedRactangle(rect, rect.Intersect);
                }
            }

            _mouseClickedButton = MouseButtons.None;
            RefreshPictureBox();
        }

        private void TrySetSelectedRactangle(Models.Rectangle rect, Func<Models.Rectangle, bool> predicate)
        {
            var selectedColors = GetSelectedColors().Where(x => !x.IsEmpty);
            var selectedRects = _rectangles.Where(x => predicate(x) && selectedColors.Contains(x.Color));
            if (selectedRects.Any())
            {
                _logs.Write("The following rectangles have been selected:");
                foreach (var value in selectedRects)
                {
                    _logs.Write("Rect: " + value);
                }

                var x1 = selectedRects.Min(x => x.TopLeft.X);
                var y1 = selectedRects.Min(x => x.TopLeft.Y);
                var x2 = selectedRects.Max(x => x.BotRight.X);
                var y2 = selectedRects.Max(x => x.BotRight.Y);
                rect.Set(x1, y1, x2, y2, _drawColor);

                _selectRectangle = rect;
            }
            else
            {
                _selectRectangle = null;
            }
        }

        private IEnumerable<Color> GetSelectedColors()
        {
            yield return GetBackColor(checkBox1);
            yield return GetBackColor(checkBox2);
            yield return GetBackColor(checkBox3);
            yield return GetBackColor(checkBox4);
        }

        private static Color GetBackColor(CheckBox checkBox)
        {
            if (checkBox.CheckState == CheckState.Checked)
            {
                return checkBox.BackColor;
            }
            return Color.Empty;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var rect in _rectangles)
            {
                DrawRectangle(
                    e.Graphics, 
                    rect.Color,
                    true,
                    rect.TopLeft.X,
                    rect.TopLeft.Y,
                    rect.BotRight.X,
                    rect.BotRight.Y);
            }

            if (_selectRectangle != null)
            {
                DrawRectangle(
                   e.Graphics,
                   _selectRectangle.Color,
                   false,
                   _selectRectangle.TopLeft.X,
                   _selectRectangle.TopLeft.Y,
                   _selectRectangle.BotRight.X,
                   _selectRectangle.BotRight.Y);
            }

            if (IsMouseDown)
            {
                DrawRectangle(
                    e.Graphics,
                    _drawColor,
                    true,
                    DrawTopLeftX,
                    DrawTopLeftY,
                    DrawBotRightX,
                    DrawBotRightY);
            }
        }

        private void DrawRectangle(
            Graphics graphics, Color color, bool isFill, double topLeftX, double topLeftY, double botRightX, double botRightY)
        {
            _drawBrush.Color = color;

            var rect = new System.Drawing.Rectangle((int)topLeftX, (int)topLeftY, (int)(botRightX - topLeftX), (int)(botRightY - topLeftY));
            graphics.DrawRectangle(_drawPen, rect);
            if (isFill)
            {
                graphics.FillRectangle(_drawBrush, rect);
            }
        }

        private void RefreshPictureBox()
        {
            pictureBox1.Invalidate();
        }
    }
}
