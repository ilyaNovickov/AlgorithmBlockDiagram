using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    public abstract class AreaWithText : Area
    {
        #region Данные
        string text;
        protected StringFormat stringFormat = new StringFormat();
        Font font;
        Color fontColor;
        #endregion
        #region Конструкторы
        internal AreaWithText() : base()
        {
            text = "Empty Text";
            DefaultInitilization();
        }
        internal AreaWithText(string text) : base()
        {
            this.text = text;
            DefaultInitilization();
        }
        internal AreaWithText(string text, Rectangle rectangle) : base(rectangle)
        {
            this.text = text;
            DefaultInitilization();
        }
        private void DefaultInitilization()
        {
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            font = new Font("Times New Roman", 12);
            fontColor = Color.Black;
        }
        #endregion
        #region Свойства
        [DisplayName("Текст")]
        [Category("Формат текста")]
        [Description("Определяет внутренний текст элемента")]
        [DefaultValue("Empty Text")]
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        [DisplayName("Горизонтальное выравнивание")]
        [Category("Формат текста")]
        [Description("Определяет горизонтальное выравнивание текста элемента")]
        public StringAlignment HAligment
        {
            get { return stringFormat.Alignment; }
            set { stringFormat.Alignment = value; }
        }
        [DisplayName("Вертикальное выравнивание")]
        [Category("Формат текста")]
        [Description("Определяет вертикальное выравнивание текста элемента")]
        public StringAlignment VAligment
        {
            get { return stringFormat.LineAlignment; }
            set { stringFormat.LineAlignment = value; }
        }
        [DisplayName("Шрифт")]
        [Category("Формат текста")]
        [Description("Определяет шрифт текста элемента")]
        public Font Font
        {
            get { return font; }
            set { font = value; }
        }
        [DisplayName("Имя шрифта")]
        [Category("Формат текста")]
        [Description("Определяет Имя шрифта текста элемента")]
        public string FontName
        {
            get { return this.font.Name; }
            set
            {
                font = new Font(value, this.font.Size);
            }
        }
        [DisplayName("Размер шрифта")]
        [Category("Формат текста")]
        [Description("Определяет размер шрифта текста элемента")]
        public float FontSize
        {
            get { return font.Size; }
            set { font = new Font(this.font.Name, value); }
        }
        [DisplayName("Цвет шрифта")]
        [Category("Формат текста")]
        [Description("Определяет цвет шрифта текста элемента")]
        public Color FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }
        #endregion
        #region Методы
        protected void DrawString(Graphics g)
        {
            using (SolidBrush solidBrush = new SolidBrush(FontColor))
            {
                g.DrawString(Text, Font, solidBrush, Rectangle, stringFormat);
            }
        }
        #endregion
    }
}
