using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    [Serializable]
    public class Text
    {
        #region Данные
        string text;
        Font font;
        Color fontColor;
        StringFormat format;
        #endregion
        #region Конструкторы
        //public Text(IRectangle container)
        public Text()
        {
            text = "";
            fontColor = Color.Black;
            font = new Font("Times New Roman", 12f);
            format = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
        }
        #endregion
        #region Свойства
        public string String
        {
            get { return text; }
            set { text = value; }
        }
        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }  
        }
        public string FontName
        {
            get { return font.Name; }
            set { font = new Font(value, font.Size); }
        }
        public float FontSize
        {
            get { return font.Size; }
            set { font = new Font(font.Name, value); }
        }
        public StringAlignment VerticalAligment
        {
            get { return format.LineAlignment; }
            set { format.LineAlignment = value; }
        }
        public StringAlignment HorintalAligment
        {
            get { return format.Alignment; }
            set { format.Alignment = value; }
        }
        #endregion
        #region Методы
        public void Draw(Graphics g, Rectangle rectangle)
        {
            if (rectangle.Size == Size.Empty)
                Draw(g, rectangle.Location);
            else
                using (SolidBrush solidBrush = new SolidBrush(fontColor))
                {
                    g.DrawString(text, font, solidBrush, rectangle, format);
                }
        }
        public void Draw(Graphics g, Point point)
        {
            using (SolidBrush solidBrush = new SolidBrush(fontColor))
            {
                g.DrawString(text, font, solidBrush, point);
            }
        }
        #endregion
    }
}
