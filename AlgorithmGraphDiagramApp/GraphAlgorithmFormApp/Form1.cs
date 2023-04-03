using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoomAndDragContolLib;
using BlocksOfAlgorithmDiagramLib;
using System.Reflection;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace GraphAlgorithmFormApp
{
    public partial class MainFrom : Form
    {
        BlockDiagram diagram = new BlockDiagram();
        Point offset = Point.Empty;
        Point oldMousePoint = Point.Empty;
        Stream fileStream;

        public MainFrom()
        {
            InitializeComponent();
            dashStyleComboBox.SelectedIndex = 0;
            zoomAndDragControl1.MouseWheel+= zoomAndDragControl1_MouseWheel;
            diagram.SelectedItemChanged += diagram_SelectedItemChanged;
        }
        
        private void zoomAndDragControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            zoomAndDragControl1.Zoom *= (float)Math.Pow(2, e.Delta / 480f);
            zoomStatusLabel.Text = $"Маштаб : {zoomAndDragControl1.Zoom * 100f}%";
        }
        #region Работа с мышью
        private void zoomAndDragControl1_MouseDown(object sender, TransformedMouseEventArgs e)
        {
            oldMousePoint = e.Location;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (cursorRadioButton.Checked)
                    {
                        if (diagram.SelectedItems == null)
                        {
                            if (diagram.GetElement(e.Location, out object element))
                                diagram.SelectedItem = element;
                            else
                                diagram.SelectedItem = null;
                        }
                        else if (diagram.SelectedItems != null && !diagram.SelectedItems.Contains(diagram.GetElement(e.Location)))
                        {
                            diagram.SelectedItems = null;
                        }
                    }
                    else if (resizeRadioButton.Checked)
                    {
                        if (diagram.GetElement(e.Location, out object element))
                            diagram.SelectedItem = element;
                        else
                            diagram.SelectedItem = null;
                    }
                    else
                    {
                        CreateDiagramElement(e.Location);
                    }
                    break;
                case MouseButtons.Right:
                    if (cursorRadioButton.Checked) 
                    {
                        if (diagram.SelectedItems == null)
                        {
                            if (diagram.GetElement(e.Location, out object element))
                                diagram.SelectedItem = element;
                            else
                                diagram.SelectedItem = null;
                        }
                        if (diagram.SelectedItem is Area)
                            zoomAndDragControl1.ContextMenuStrip = blockContexMenuStrip;
                        else if (diagram.SelectedItem is Line)
                            zoomAndDragControl1.ContextMenuStrip = lineContexMenuStrip;
                    }
                    break;
                case MouseButtons.Middle:
                    break;
            }
            
        }
        private void CreateDiagramElement(Point point)
        {
            object element = null;
            if (operationalRadioButton.Checked)
                element = new OperationalBlock(point);
            else if (logicalRadioButton.Checked)
                element = new LogicalBlock(point);
            else if (beginEndRadionButton.Checked)
                element = new BeginEndBlock(point);
            else if (commentRadioButton.Checked)
                element = new Comment(point);
            else if (lineRadioButton.Checked)
                element = new Line(point);
            else if (arrowRadionButton.Checked)
                element = new LineWithArrow(point);
            if (element != null)
            {
                InitilizateProperties(element);
                diagram.AddElement(element);
            }
            diagram.SelectedItem = element;
        }
        private void zoomAndDragControl1_MouseMove(object sender, TransformedMouseEventArgs e)
        {
            if (oldMousePoint.X != (int)e.X || oldMousePoint.Y != (int)e.Y)
            {
                
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        offset.X += (int)e.X - oldMousePoint.X;
                        offset.Y += (int)e.Y - oldMousePoint.Y;
                        if (diagram.SelectedItem != null && cursorRadioButton.Checked)
                        {
                            ClickAndMoveDiagramElement(diagram.SelectedItem, oldMousePoint, e.Location);
                            zoomAndDragControl1.Refresh();
                            propertyGrid1.Refresh();
                        }
                        else if (diagram.SelectedItems != null && cursorRadioButton.Checked)
                        {
                            diagram.MoveElements((int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y, diagram.SelectedItems);
                            zoomAndDragControl1.Refresh();
                            propertyGrid1.Refresh();
                        }
                        else if (diagram.SelectedItems == null && cursorRadioButton.Checked)
                        {
                            zoomAndDragControl1.Refresh();
                            Point firstPoint = e.Location;
                            firstPoint.Offset(-offset.X, -offset.Y);
                            Rectangle rectangle = GetRectangle(e.Location, firstPoint);
                            DrawHightlightRectangle(rectangle);
                        }
                        else if (diagram.SelectedItem != null && !cursorRadioButton.Checked && !resizeRadioButton.Checked)
                        {
                            if (diagram.SelectedItem is Area)
                            {
                                Point point = new Point((int)e.X, (int)e.Y);
                                point.Offset(-offset.X, -offset.Y);
                                Rectangle rectangle = GetRectangle(e.Location, point);
                                ((Area)diagram.SelectedItem).Rectangle = rectangle;
                            }
                            else if (diagram.SelectedItem is Line)
                            {
                                ((Line)diagram.SelectedItem)[1] = e.Location;
                            }
                            zoomAndDragControl1.Refresh();
                            propertyGrid1.Refresh();
                        }
                        else if (resizeRadioButton.Checked && diagram.SelectedItem is Area)
                        {
                            ResizeRectangle(((Area)diagram.SelectedItem), (int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y);
                        }
                        oldMousePoint = e.Location;
                        break;
                    case MouseButtons.Right:
                        break;
                    case MouseButtons.Middle:
                        break;
                    default:
                        break;
                }   
            }
        }
        private void ClickAndMoveDiagramElement(object element, Point firstPoint, Point secondPoint)
        {
            if (cursorRadioButton.Checked)
            {
                if (element is Area)
                {
                    Area area = (Area)element;
                    area.Move(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                }
                else if (element is Line)
                {
                    Line line = (Line)element;
                    int index = line.GetIndexofPoint(firstPoint, 5);
                    if (index != -1)
                        line.MovePoint(index, secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                    else
                        line.MoveAllPoints(secondPoint.X - firstPoint.X, secondPoint.Y - firstPoint.Y);
                }
            }
        }
        private void DrawHightlightRectangle(Rectangle rectangle)
        {
            var g = zoomAndDragControl1.CreateTransformedGraphics();
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(126, Color.LightBlue));
            g.FillRectangle(solidBrush, rectangle);
            solidBrush.Dispose();
            g.DrawRectangle(new Pen(Color.SkyBlue, 2), rectangle);
        }
        private void ResizeRectangle(Area area, int deltaX, int deltaY)
        {
            Rectangle rect = area.Rectangle;
            rect.Width += deltaX;
            rect.Height += deltaY;
            area.Rectangle = rect;
            zoomAndDragControl1.Refresh();

        }
        private void zoomAndDragControl1_MouseUp(object sender, TransformedMouseEventArgs e)
        {
            if (offset != Point.Empty)
            {
                Point firstPoint = e.Location;
                firstPoint.Offset(-offset.X, -offset.Y);
                if (diagram.SelectedItem == null && diagram.SelectedItems == null)
                {
                    diagram.SelectedItems = diagram.GetElements(GetRectangle(e.Location, firstPoint)).ToArray();
                }
            }
            else if (offset == Point.Empty && !cursorRadioButton.Checked)
            {
                if (diagram.SelectedItem is Area)
                    ((Area)diagram.SelectedItem).Rectangle = CenterRectangle(((Area)diagram.SelectedItem).Rectangle);
                else if (diagram.SelectedItem is Line)
                    ((Line)diagram.SelectedItem).MoveAllPoints(-((Line)diagram.SelectedItem).Rectangle.Width / 2,
                        -((Line)diagram.SelectedItem).Rectangle.Height / 2);
                
            }
            //if (e.Button != MouseButtons.Right)
            //    oldMousePoint = Point.Empty;
            offset = Point.Empty;
            cursorRadioButton.PerformClick();
            cursorRadioButton.Focus();
            zoomAndDragControl1.Invalidate();
        }
        #endregion
        #region Рисование
        private void zoomAndDragControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Transform = zoomAndDragControl1.GetTransformMatrix();
            diagram.Draw(e.Graphics);
            DrawSelectedItems(e.Graphics);
        }
        private void DrawSelectedItems(Graphics g)
        {
            if (diagram.SelectedItem != null)
            {
                if (diagram.SelectedItem is Area)
                    DrawSelectedArea(g, (Area)diagram.SelectedItem);
                else if (diagram.SelectedItem is Line)
                    DrawSelectedLine(g, (Line)diagram.SelectedItem);
            }
            else if (diagram.SelectedItems != null)
            {
                foreach (var element in diagram.SelectedItems)
                {
                    if (element is Area)
                        DrawSelectedArea(g, (Area)element);
                    else if (element is Line)
                        DrawSelectedLine(g, (Line)element);
                }
            }
        }
        private void DrawSelectedLine(Graphics g, Line line)
        {
            Rectangle[] rectangles = new Rectangle[line.GetAllPoints().Length];
            for (int i = 0; i < line.GetAllPoints().Length; i++)
            {
                rectangles[i] = new Rectangle(line[i].X - 5, line[i].Y - 5, 10, 10);
            }
            SolidBrush solidBrush = new SolidBrush(Color.Blue);
            g.FillRectangles(solidBrush, rectangles);
            solidBrush.Dispose();
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            g.DrawRectangles(pen, rectangles);
            pen.Dispose();
        }
        private void DrawSelectedArea(Graphics g, Area area)
        {
            Pen pen = new Pen(Color.Black);
            pen.DashStyle = DashStyle.DashDot;
            g.DrawRectangle(pen, area.Rectangle);
            pen.Dispose();

        }
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            zoomAndDragControl1.Refresh();
        }
        
        #endregion
        #region Иницилизация свойст элементов схемы
        private void InitilizateProperties(object element)
        {
            if (element is Shape)
            {
                Shape shape = (Shape)element;
                shape.FillColor = fillColorControl.Color;
                shape.ContourColor = contourColorControl.Color;
                shape.ContourThick = Int32.Parse(thickUpDownButton.Text);
                shape.DashStyle = GetDashStyleFromControl();
            }
            else if (element is Line) 
            {
                Line line = (Line)element;
                line.ContourColor = contourColorControl.Color;
                line.ContourThick = Int32.Parse(thickUpDownButton.Text);
                line.DashStyle = GetDashStyleFromControl();
            }
        }
        private DashStyle GetDashStyleFromControl()
        {
            switch (dashStyleComboBox.SelectedIndex)
            {
                case 0:
                    return DashStyle.Solid;
                case 1:
                    return DashStyle.Dash;
                case 2:
                    return DashStyle.DashDot;
                case 3:
                    return DashStyle.DashDotDot;
                case 4:
                    return DashStyle.Dot;
                default:
                    return DashStyle.Solid;
            }
        }
        #endregion
        #region Установка свойств в элементы управления
        private void diagram_SelectedItemChanged(object sender, EventArgs e)
        {
            if (diagram.SelectedItem != null && diagram.SelectedItems == null)
                propertyGrid1.SelectedObject = diagram.SelectedItem;
            else if (diagram.SelectedItem == null && diagram.SelectedItems != null)
                propertyGrid1.SelectedObjects = diagram.SelectedItems;
            else
                propertyGrid1.SelectedObject = null;
        }
        //private void ReinitilizateProperties(object element)
        //{
        //    if (element is Shape)
        //    {
        //        Shape shape = (Shape)element;
        //        fillColorControl.Color = shape.FillColor;
        //        contourColorControl.Color = shape.ContourColor;
        //        thickUpDownButton.Text = shape.ContourThick.ToString();
        //        SetDashStyleInControl(shape.DashStyle);
        //    }
        //    else if (element is Line)
        //    {
        //        Line line = (Line)element;
        //        line.ContourColor = contourColorControl.Color;
        //        line.ContourThick = Int32.Parse(thickUpDownButton.Text);
        //        line.DashStyle = GetDashStyleFromControl();
        //    }
        //}
        //private void SetDashStyleInControl(DashStyle dashStyle)
        //{
        //    switch (dashStyle)
        //    {
        //        case DashStyle.Solid:
        //            dashStyleComboBox.SelectedIndex = 0;
        //            break;
        //        case DashStyle.Dash:
        //            dashStyleComboBox.SelectedIndex = 1;
        //            break;
        //        case DashStyle.Dot:
        //            dashStyleComboBox.SelectedIndex = 4;
        //            break;
        //        case DashStyle.DashDot:
        //            dashStyleComboBox.SelectedIndex = 2;
        //            break;
        //        case DashStyle.DashDotDot:
        //            dashStyleComboBox.SelectedIndex = 3;
        //            break;
        //        default:
        //            dashStyleComboBox.SelectedIndex = 0;
        //            break;
        //    }
        //}
        #endregion
        #region Работа к прямоугольником
        private Rectangle GetRectangle(Point point1, Point point2)
        {
            Point leftTop = new Point();
            Point rightBottom = new Point();
            if (point1.X > point2.X)
            {
                leftTop.X = point2.X;
                rightBottom.X = point1.X;
            }
            else
            {
                leftTop.X = point1.X;
                rightBottom.X = point2.X;
            }
            if (point1.Y > point2.Y)
            {
                leftTop.Y = point2.Y;
                rightBottom.Y = point1.Y;
            }
            else
            {
                leftTop.Y = point1.Y;
                rightBottom.Y = point2.Y;
            }
            return new Rectangle(leftTop, new Size(rightBottom.X - leftTop.X, rightBottom.Y - leftTop.Y));
        }
        private Rectangle CenterRectangle(Rectangle rectangle)
        {
            return new Rectangle(rectangle.X - rectangle.Width / 2, rectangle.Y - rectangle.Height / 2, rectangle.Width, rectangle.Height);
        }
        #endregion
        #region Доп кнопки
        private void centerButton_Click(object sender, EventArgs e)
        {
            zoomAndDragControl1.ResetMatrix();
            zoomAndDragControl1.Invalidate();
        }

        private void resetDrawSettingsButton_Click(object sender, EventArgs e)
        {
            fillColorControl.Color = Color.White;
            contourColorControl.Color = Color.Black;
            dashStyleComboBox.SelectedIndex = 0;
            thickUpDownButton.SelectedIndex = 14;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (diagram.SelectedItem != null)
                diagram.DeleteElement(diagram.SelectedItem);
            else if (diagram.SelectedItems != null)
                diagram.DeleteRange(diagram.SelectedItems);
            zoomAndDragControl1.Refresh();
            propertyGrid1.SelectedObject = null;
            diagram.SelectedItems = null;
            diagram.SelectedItem = null;
        }


        private void cursorRadioButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                deleteButton_Click(this, EventArgs.Empty);
            }
        }
        #endregion
        private void addPointButton_Click(object sender, EventArgs e)
        {
            if (diagram.SelectedItem is Line)
                ((Line)diagram.SelectedItem).InsertPoint(oldMousePoint, ((Line)diagram.SelectedItem).GetAllPoints().Length - 1);
            zoomAndDragControl1.Refresh();
        }

        private void удалитьТочкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (diagram.SelectedItem is Line)
            {
                int index = ((Line)diagram.SelectedItem).GetAllPoints().Length - 1;
                if (index > 1)
                    ((Line)diagram.SelectedItem).DeletePoint(index - 1);
                zoomAndDragControl1.Refresh();
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Бинарный файл (*.dat)|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileStream = new FileStream(sfd.FileName, FileMode.CreateNew, FileAccess.Write);
            }
        }

        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileStream == null)
                return;
            fileStream.Close();
            fileStream.Dispose();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Бинарный файл (*.dat)|*.dat";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object deserializedObject = binaryFormatter.Deserialize(fileStream);
                if (!(deserializedObject is BlockDiagram))
                {
                    fileStream.Close();
                    MessageBox.Show("Сохрянённый файл не является блок-схемой");
                }
                else
                {
                    diagram = (BlockDiagram)deserializedObject;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileStream == null)
                return;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, diagram);
        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Png (*.png)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = GetBitmap(diagram);
                bitmap.Save(sfd.FileName);
                bitmap.Dispose();
            }
        }
        private Bitmap GetBitmap(BlockDiagram diagram)
        {
            Rectangle rectangle = diagram.Rectangle;
            rectangle.Width += 20;
            rectangle.Height += 20;
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            var g = Graphics.FromImage(bitmap);
            Matrix matrix = new Matrix();
            matrix.Translate(-10, -10);
            g.Transform = matrix;
            g.Clear(Color.White);
            diagram.MoveAllElements(-(diagram.Rectangle.X - 20), -(diagram.Rectangle.Y - 20));
            diagram.Draw(g);
            diagram.MoveAllElements(rectangle.X, rectangle.Y);
            return bitmap;
        }
        //Подумать об сериализации
    }
}
