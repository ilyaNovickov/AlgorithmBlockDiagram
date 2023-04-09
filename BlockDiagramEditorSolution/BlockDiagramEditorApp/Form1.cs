using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlocksOfAlgorithmDiagramLib;

namespace GSAApp
{
    public partial class Form1 : Form
    {
        Point oldMousePoint;
        IDiagramElement selectedElement;
        int indexofPoint = -1;
        BlockDiagram diagram = new BlockDiagram();
        public Form1()
        {
            InitializeComponent();
            dashStyleComboBox.SelectedIndex = 0;
            zoomAndDragControl1.MouseWheel += zoomAndDragControl1_MouseWheel;

            diagram.AddElement(new OperationalBlock(100, 100));
        }
        private IDiagramElement SelectedElement
        {
            get { return selectedElement; }
            set
            {
                if (value == null)
                {
                    selectedElement = null;
                }
                selectedElement = value;
                SetSelectedElement();
            }
        }
        private void SetSelectedElement()
        {
            propertyGrid1.SelectedObject = selectedElement;
            zoomAndDragControl1.Refresh();
            propertyGrid1.Update();
        }
        private void zoomAndDragControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            zoomAndDragControl1.Zoom *= (float)Math.Pow(2, e.Delta / 480f);
        }
        private void zoomAndDragControl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Transform = zoomAndDragControl1.GetTransformMatrix();
            diagram.Draw(e.Graphics);
            if (SelectedElement is Area)
                DrawSelectedArea(e.Graphics, (Area)SelectedElement);
            else if (SelectedElement is Line)
                DrawSelectedLine(e.Graphics, (Line)SelectedElement);
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
        private void zoomAndDragControl1_MouseDown(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {
            zoomAndDragControl1.Focus();
            oldMousePoint = e.Location;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (cursorRadioButton.Checked)
                    {
                        SelectedElement = diagram.GetElement(e.Location);
                    }
                    else
                    {
                        CreateDiagramElement(e.Location);
                    }
                    break;
                case MouseButtons.Right:
                    if (diagram.GetElement(e.Location, out IDiagramElement element))
                    {
                        SelectedElement = element;
                        if (element is Area)
                            zoomAndDragControl1.ContextMenuStrip = blockContexMenu;
                        else if (element is Line)
                            zoomAndDragControl1.ContextMenuStrip = lineContexMenu;
                    }
                    else
                    {
                        if (SelectedElement != null)
                            SelectedElement = null;
                        zoomAndDragControl1.ContextMenuStrip = standartContexMenu;
                    }
                    break;
                case MouseButtons.Middle:
                    if (SelectedElement != null)
                        SelectedElement = null;
                    break;
            }
        }
        private void zoomAndDragControl1_MouseMove(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {
            if (e.Location != oldMousePoint)
            {
                if (SelectedElement != null)
                {
                    if (cursorRadioButton.Checked)
                    {
                        if (SelectedElement is Line && ((Line)SelectedElement).GetIndexofPoint(oldMousePoint, 5) != -1)
                            ((Line)SelectedElement).MovePoint(((Line)SelectedElement).GetIndexofPoint(oldMousePoint, 5), 
                                (int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y);
                        else
                            SelectedElement.Move((int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y);
                        oldMousePoint = e.Location;
                    }
                    else
                        ResizeElement(SelectedElement, e.Location);
                    zoomAndDragControl1.Invalidate();
                }
            }
        }

        private void zoomAndDragControl1_MouseUp(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {

        }
        private void CreateDiagramElement(Point point)
        {
            IDiagramElement element = null;
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
                element = new Arrow(point);
            if (element != null)
            {
                InitilizateProperties(element);
                CenterElement(element);
                diagram.AddElement(element);
            }
            SelectedElement = element;
        }
        private void InitilizateProperties(object element)
        {
            if (element is Shape)
            {
                Shape shape = (Shape)element;
                shape.FillColor = fillColorPanel.BackColor;
                shape.ContourColor = contourColorPanel.BackColor;
                shape.ContourThick = Int32.Parse(thickUpDownButton.Text);
                shape.DashStyle = GetDashStyleFromControl();
            }
            else if (element is Line)
            {
                Line line = (Line)element;
                line.ContourColor = contourColorPanel.BackColor;
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
        private void ResizeElement(IDiagramElement element, Point point)
        {
            if (element is Area)
            {
                ((Area)element).Rectangle = GetRectangle(oldMousePoint, point);
            }
            else if (element is Line)
            {
                ((Line)element)[0] = oldMousePoint;
                ((Line)element)[1] = point;
            }
        }
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
        private void CenterElement(IDiagramElement element)
        {
            if (element is Area)
                ((Area)element).Rectangle = new Rectangle(element.Rectangle.X - element.Rectangle.Width / 2, element.Rectangle.Y - element.Rectangle.Height / 2,
                    element.Rectangle.Width, element.Rectangle.Height);
            else if (element is Line)
                ((Line)element).Move(-element.Rectangle.Width / 2, -element.Rectangle.Height / 2);
        }
        private void centerButton_Click(object sender, EventArgs e)
        {
            zoomAndDragControl1.ResetMatrix();
            zoomAndDragControl1.Invalidate();
        }
        private void zoomAndDragControl_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                if (SelectedElement != null)
                {
                    diagram.DeleteElement(SelectedElement);
                    SelectedElement = null;
                }
            }
        }
        private void fillColorPanel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                var cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    panel.BackColor = cd.Color;
                }
                cd.Dispose();
            }
        }
        //private void addPointButton_Click(object sender, EventArgs e)
        //{
        //    if (propertyGrid1.SelectedObject is Line)
        //        ((Line)propertyGrid1.SelectedObject).InsertPoint(oldMousePoint, ((Line)propertyGrid1.SelectedObject).GetAllPoints().Length - 1);
        //    zoomAndDragControl1.Refresh();
        //}
        //private void удалитьТочкуToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (propertyGrid1.SelectedObject is Line)
        //    {
        //        int index = ((Line)propertyGrid1.SelectedObject).GetAllPoints().Length - 1;
        //        if (index > 1)
        //            ((Line)propertyGrid1.SelectedObject).DeletePoint(index - 1);
        //        zoomAndDragControl1.Refresh();
        //    }
        //}
        //private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var sfd = new SaveFileDialog();
        //    sfd.Filter = "Бинарный файл (*.dat)|*.dat";
        //    if (sfd.ShowDialog() == DialogResult.OK)
        //    {
        //        fileStream = new FileStream(sfd.FileName, FileMode.CreateNew, FileAccess.Write);
        //    }
        //}

        //private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (fileStream == null)
        //        return;
        //    fileStream.Close();
        //    fileStream.Dispose();
        //}

        //private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var ofd = new OpenFileDialog();
        //    ofd.Filter = "Бинарный файл (*.dat)|*.dat";
        //    if (ofd.ShowDialog() == DialogResult.OK)
        //    {
        //        fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
        //        BinaryFormatter binaryFormatter = new BinaryFormatter();
        //        object deserializedObject = binaryFormatter.Deserialize(fileStream);
        //        if (!(deserializedObject is BlockDiagram))
        //        {
        //            fileStream.Close();
        //            MessageBox.Show("Сохрянённый файл не является блок-схемой");
        //        }
        //        else
        //        {
        //            diagram = (BlockDiagram)deserializedObject;
        //        }
        //    }
        //}

        //private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (fileStream == null)
        //        return;
        //    BinaryFormatter binaryFormatter = new BinaryFormatter();
        //    binaryFormatter.Serialize(fileStream, diagram);
        //}

        //private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var sfd = new SaveFileDialog();
        //    sfd.Filter = "Png (*.png)|*.png";
        //    if (sfd.ShowDialog() == DialogResult.OK)
        //    {
        //        Bitmap bitmap = GetBitmap(diagram);
        //        bitmap.Save(sfd.FileName);
        //        bitmap.Dispose();
        //    }
        //}
        //private Bitmap GetBitmap(BlockDiagram diagram)
        //{
        //    Rectangle rectangle = diagram.Rectangle;
        //    rectangle.Width += 20;
        //    rectangle.Height += 20;
        //    Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
        //    var g = Graphics.FromImage(bitmap);
        //    Matrix matrix = new Matrix();
        //    matrix.Translate(-10, -10);
        //    g.Transform = matrix;
        //    g.Clear(Color.White);
        //    diagram.MoveAllElements(-(diagram.Rectangle.X - 20), -(diagram.Rectangle.Y - 20));
        //    diagram.Draw(g);
        //    diagram.MoveAllElements(rectangle.X, rectangle.Y);
        //    return bitmap;
        //}
    }
}
