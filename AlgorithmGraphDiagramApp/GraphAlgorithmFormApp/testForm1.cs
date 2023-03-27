using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlocksOfAlgorithmDiagramLib;

namespace ExampleForm
{
    public partial class Form1 : Form
    {
        //ProcessBlock et;
        //ExternalText ext;
        //ConditionalBlock cb;
        //TerminatorBlock tb;
        AlgorithmBlockDiagram al = new AlgorithmBlockDiagram();
        Point prevLoc;
        Rectangle rect;
        bool cl=false;
        public Form1()
        {
            InitializeComponent();
            //et = new ProcessBlock();
            //cb = new ConditionalBlock();
            //ext = new ExternalText();
            //tb = new TerminatorBlock();
            //propertyGrid1.SelectedObject = tb;
            al.AddBlock(new ProcessBlock());
            al.AddBlock(new ConditionalBlock());
            al.AddBlock(new Comment());
            al.AddBlock(new TerminatorBlock());
            //radioButton1.Checked
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //et.Draw(e.Graphics);
            //ext.Draw(e.Graphics);
            //cb.Draw(e.Graphics);
            //tb.Draw(e.Graphics);
            al.Draw(e.Graphics);
            propertyGrid1.Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //if (et.IsOnto(e.Location))
            //    et.Selected = true;
            //else if (ext.IsOnto(e.Location))
            //    ext.Selected = true;
            //else if (cb.IsOnto(e.Location))
            //    cb.Selected = true;
            //else if (tb.IsOnto(e.Location))
            //    tb.Selected = true;
            
            prevLoc = e.Location;
            al.ChooseElement(e.Location);
            propertyGrid1.SelectedObject = al.SelectedElement;

            /*
            prevLoc = e.Location;
            cl = true;
            */
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if (!cl)
                return;
            var g = this.CreateGraphics();
            rect = new Rectangle(prevLoc, new Size(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y));
            g.DrawRectangle(new Pen(Color.Black), rect) ;
            */
            if (al.SelectedElement == null)
                return;//Вырубить если надо двигать все элементы
            if (e.Button == MouseButtons.Left)
            {
                al.SelectedElement.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
                prevLoc = e.Location;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Size size = new Size(al.SelectedElement.Size.Width + (e.Location.X - prevLoc.X), al.SelectedElement.Size.Height +
                            +(e.Location.Y - prevLoc.Y));
                al.SelectedElement.Size = size;
                prevLoc = e.Location;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                al.SelectAll();
                al.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
                prevLoc = e.Location;
            }
            //if (et.Selected)
            //    switch (e.Button)
            //    {
            //        case MouseButtons.Left:
            //            et.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
            //            prevLoc = e.Location;
            //            break;
            //        case MouseButtons.Right:
            //            Size size = new Size(et.Size.Width + (e.Location.X - prevLoc.X), et.Size.Height +
            //            +(e.Location.Y - prevLoc.Y));
            //            et.Size = size;
            //            prevLoc = e.Location;
            //            break;
            //    }
            //else if (ext.Selected)
            //    switch (e.Button)
            //    {
            //        case MouseButtons.Left:
            //            ext.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
            //            prevLoc = e.Location;
            //            break;
            //        case MouseButtons.Right:
            //            Size size = new Size(ext.Size.Width + (e.Location.X - prevLoc.X), ext.Size.Height +
            //            +(e.Location.Y - prevLoc.Y));
            //            ext.Size = size;
            //            prevLoc = e.Location;
            //            break;
            //    }
            //else if (cb.Selected)
            //    switch (e.Button)
            //    {
            //        case MouseButtons.Left:
            //            cb.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
            //            prevLoc = e.Location;
            //            break;
            //        case MouseButtons.Right:
            //            Size size = new Size(cb.Size.Width + (e.Location.X - prevLoc.X), cb.Size.Height +
            //            +(e.Location.Y - prevLoc.Y));
            //            cb.Size = size;
            //            prevLoc = e.Location;
            //            break;
            //    }
            //else if (tb.Selected)
            //    switch (e.Button)
            //    {
            //        case MouseButtons.Left:
            //            tb.Move(e.Location.X - prevLoc.X, e.Location.Y - prevLoc.Y);
            //            prevLoc = e.Location;
            //            break;
            //        case MouseButtons.Right:
            //            Size size = new Size(tb.Size.Width + (e.Location.X - prevLoc.X), tb.Size.Height +
            //            +(e.Location.Y - prevLoc.Y));
            //            tb.Size = size;
            //            prevLoc = e.Location;
            //            break;
            //    }
            this.Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //et.Selected = false;
            //ext.Selected = false;
            //cb.Selected = false;
            //tb.Selected = false;

            //al.SelectedElement.Selected = false;

            //al.SelectedElement = null;
            //propertyGrid1.SelectedObject = null;
            
            /*
            al.ChooseSeveralElements(rect);
            cl = false;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (al.SelectedElement == null)
                return;
            //al.DeleteSelectedElement();
            al.ToForeground();
            //al.DeleteSeveralSelectedElements();
        }

        private void customControl21_CheckedChanged(object sender, EventArgs e)
        {
                    }

        private void customControl11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
