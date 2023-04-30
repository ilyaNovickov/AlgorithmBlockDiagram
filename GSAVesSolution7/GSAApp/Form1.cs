using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using GSAVelLib;

namespace GSAApp
{
    public partial class Form1 : Form
    {
        #region Данные
        Point oldMousePoint;//Начальное положение мыши
        IDiagramElement selectedElement;//Элемент блок-схемы, с которым работают в данным момент 
        Diagram diagram = new Diagram();//Блок-схема
        FileStream fileStream;//Поток файла
        #endregion
        #region Конструктор формы
        //Конструктор формы
        public Form1()
        {
            //Иницилизация компонентов формы
            InitializeComponent();
            //Установка индекса ComboBox на значение 0
            dashStyleComboBox.SelectedIndex = 0;
            //Подключение события скролла колёсика мыши
            zoomAndDragControl1.MouseWheel += zoomAndDragControl1_MouseWheel;
        }
        #endregion
        #region Выбранный элемент блок-схемы для редактирования
        /// <summary>
        /// Выбранный элемент блок-схемы для редактирования
        /// </summary>
        private IDiagramElement SelectedElement
        {
            //Метод возвращающий выбранный элемент блок-схеиы
            get { return selectedElement; }
            //Метод установки элемента для редактирования
            set
            {
                //Установка значения
                selectedElement = value;
                //Вызов метода для обработки события
                SetSelectedElement();
            }
        }
        #endregion
        #region Методы
        //Метод установки нового элемента для редактирования
        private void SetSelectedElement()
        {
            //Установка в propertyGrid элемента блок-схемы для редактирования
            propertyGrid1.SelectedObject = selectedElement;
            //Вызов перерисовки элементов управления
            zoomAndDragControl1.Refresh();
            propertyGrid1.Update();
        }
        #region Работа с маштабом
        //Обработчик события скролла колёсика мыши
        private void zoomAndDragControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            //Увеличение или уменьшения маштаба при прокрутки колёсика мыши
            zoomAndDragControl1.Zoom *= (float)Math.Pow(2, e.Delta / 480f);
            //Устновка в трэк бар значения соотведстввующего маштабу элемента управления
            zoomTrackBar.Value = (int)(zoomAndDragControl1.Zoom * 100f);
        }
        //Обработчик события скролла трэк бара
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Увеличение или уменьшения маштаба при изменении значения трэк бара
            zoomAndDragControl1.Zoom = zoomTrackBar.Value * 0.01f;
        }
        //Обработчик события изменения маштаба элемента управления
        private void zoomAndDragControl1_ZoomChanged(object sender, EventArgs e)
        {
            //Установка строки в надпись панели элементов
            zoomStripLabel.Text = $"Маштаб : {zoomAndDragControl1.Zoom * 100f} %";
        }
        //Обработчик события нажатия на кпопку centerButton
        private void centerButton_Click(object sender, EventArgs e)
        {
            //Сброс матрицы преобразования у элемента управления
            zoomAndDragControl1.ResetMatrix();
            //Вызов перерисовки элемента управления
            zoomAndDragControl1.Invalidate();
            //Сброс значений в трэк баре
            zoomTrackBar.Value = (int)(zoomAndDragControl1.Zoom * 100f);
        }
        #endregion
        #region Рисование
        //Обработчик события рисования элемента управления
        private void zoomAndDragControl1_Paint(object sender, PaintEventArgs e)
        {
            //Установка в класс Graphics матрицы трансформации
            e.Graphics.Transform = zoomAndDragControl1.GetTransformMatrix();
            //Установка рисования со сглаживанием
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //Рисование блок-схемы
            diagram.Draw(e.Graphics);
            //Если выбранный элемент блок-схемы - область или текст
            if (SelectedElement is AreaWithText || SelectedElement is AreaWithText)
                //Рисовать выделение
                DrawSelectedArea(e.Graphics, SelectedElement);
            //Иначе если выбранный элемент блок-схемы - линия
            else if (SelectedElement is Line)
                //Рисовать выделение для линии
                DrawSelectedLine(e.Graphics, (Line)SelectedElement);
        }
        //Рисование выбранной в данной момент линии
        private void DrawSelectedLine(Graphics g, Line line)
        {
            //Иницилизация массива прямоугольников
            //Размер массива равень кол-во точек ломанной линии
            Rectangle[] rectangles = new Rectangle[line.GetAllPoints().Length];
            //Цикл с параметром для иницилизации каждого прямоугольника
            for (int i = 0; i < line.GetAllPoints().Length; i++)
            {
                //Прямоугольники имеют размер 10Х10 и распологаются на месте точек ломанной линии
                rectangles[i] = new Rectangle(line[i].X - 5, line[i].Y - 5, 10, 10);
            }
            //Создание экземпляра класса SolidBrush
            SolidBrush solidBrush = new SolidBrush(Color.Blue);
            //Рисование закрашенный прямоугольников
            g.FillRectangles(solidBrush, rectangles);
            //Очищение неуправляемых ресурсов экземпляра класса SolidBrush
            solidBrush.Dispose();
            //Создание объекта класа Pen
            Pen pen = new Pen(Color.Black);
            //Установка свойства толщины объекта Pen
            pen.Width = 2;
            //Рисование контуров прямоугольников
            g.DrawRectangles(pen, rectangles);
            //Очищение неуправляемых ресурсов экземпляра класса Pen
            pen.Dispose();
        }
        //Рисование выбранного в данный момент блока 
        private void DrawSelectedArea(Graphics g, IDiagramElement area)
        {
            //Создание экземпляра класса Pen
            Pen pen = new Pen(Color.Black);
            //Установка свойства типа линии как штрих-точка
            pen.DashStyle = DashStyle.DashDot;
            //Рисование прямоугольника, в который вписан элемент-блок-схемы
            g.DrawRectangle(pen, area.Rectangle);
            //Очистака неуправляемых ресурсов класса Pen
            pen.Dispose();

        }
        #endregion
        #region Работа с мышью
        //Обработчик события нажатия на кнопку мыши по элементу управления
        private void zoomAndDragControl1_MouseDown(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {
            //Установка фокуса на элементе управления
            zoomAndDragControl1.Focus();
            //Запоминание координат положения мыши
            oldMousePoint = e.Location;
            //Выбор какая кнопка мыши была нажата
            switch (e.Button)
            {
                //Нажата левая кнопка мыши
                case MouseButtons.Left:
                    //Если включен режим курсопа или изменения маштаба элемента
                    if (cursorRadioButton.Checked || resizeRadioButton.Checked)
                    {
                        //Установка выбранного элемента блок-схемы
                        SelectedElement = diagram.GetElement(e.Location);
                    }
                    else//Иначе включен режим создания элемента блок-схемы
                    {
                        //Вызов метода создания элемента блок-схемы
                        CreateDiagramElement(e.Location);
                    }
                    break;
                //Нажата правая кнопка мыши
                case MouseButtons.Right:
                    //Если нажат элемент блок-схемы
                    if (diagram.GetElement(e.Location, out IDiagramElement element))
                    {
                        //Установка выбранного элемента блок-схемы
                        SelectedElement = element;
                        //Если выбранный элемент блок-схемы - это область или текст
                        if (element is AreaWithText || element is AreaWithText)
                            //Установка одного контекстного меню для элемента управления
                            zoomAndDragControl1.ContextMenuStrip = blockContexMenu;
                        //Иначе если элемент - линия
                        else if (element is Line)
                            //Установка другого контекстного меню для элемента управления
                            zoomAndDragControl1.ContextMenuStrip = lineContexMenu;
                    }
                    else//Иначе установка того, что элемент блок-схемы не выбран
                    {
                        //Установка того, что у элемента управления нет контекстного меню
                        zoomAndDragControl1.ContextMenuStrip = null;
                        if (SelectedElement != null)
                            SelectedElement = null;
                    }
                    break;
                //Нажата средняя кнопка мыши
                case MouseButtons.Middle:
                    //Установка того, что элемент блок-схемы не выбран
                    if (SelectedElement != null)
                        SelectedElement = null;
                    break;
            }
        }
        //Обработчик события движения мыши по элементу управления
        private void zoomAndDragControl1_MouseMove(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {
            //Если нынешнее положение мыши не равно прошлому (т. е. мышь двинуласть)
            if (e.Location != oldMousePoint)
            {
                //установка того, что элемент блок-схемы
                if (SelectedElement != null)
                {
                    //Если включен режим курсора
                    if (cursorRadioButton.Checked)
                    {
                        //Если выбранный элемент блок-схемы - линия и нажата точка линии
                        if (SelectedElement is Line line && line.GetIndexofPoint(oldMousePoint, 5) != -1)
                            //Двинуть нажатую точку ломанной линии блок-схемы
                            line.MovePoint(line.GetIndexofPoint(oldMousePoint, 5),
                                (int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y);
                        else//Иначе если просто нажат элемент блок-схемы
                            //То двинуть его
                            SelectedElement.Move((int)e.X - oldMousePoint.X, (int)e.Y - oldMousePoint.Y);
                        //Сохранение нового положения курсора мыши
                        oldMousePoint = e.Location;
                    }
                    //Иначе если включён режим изменения размера элемента блок-схемы
                    else if (resizeRadioButton.Checked)
                    {
                        //Если выбранный элемент - ClassWithRect
                        if (SelectedElement is AreaWithText || SelectedElement is AreaWithText)
                        {
                            //Вызов метода изменения размера выбранного элемент блок-схемы
                            ResizeElement(SelectedElement, e.Location);
                        }
                    }
                    else//Иначе если включены режимы создание элемента блок-схемы
                        ResizeElement(SelectedElement, e.Location);
                    //Вызов перерисовок элементов управления
                    zoomAndDragControl1.Refresh();
                    propertyGrid1.Refresh();
                }
            }
        }
        //Обработчик события отпускания кнопки мыши с элемента управленя
        private void zoomAndDragControl1_MouseUp(object sender, ZoomAndDragContolLib.TransformedMouseEventArgs e)
        {
            //Если кнопка мыши отпущена, то установка режима курсора
            cursorRadioButton.Checked = true;
        }
        //Метод создание элемента блок-схемы
        private void CreateDiagramElement(Point point)
        {
            //Создание вспомогательной переменной типа IDiagramElement
            IDiagramElement element = null;
            //Если включен режим создания операцинного блока
            if (operationalRadioButton.Checked)
                //Иницилизация в спомогательную переменную операцинного блока
                element = new OperationalBlock(point);
            //Если включен режим создания логического блока
            else if (logicalRadioButton.Checked)
                //Иницилизация в спомогательную переменную логического блока
                element = new LogicalBlock(point);
            //Если включен режим создания блока начало-конца
            else if (beginEndRadionButton.Checked)
                //Иницилизация в спомогательную переменную блока начало-конца
                element = new BeginEndBlock(point);
            //Если включен режим создания комментария
            else if (commentRadioButton.Checked)
                //Иницилизация в спомогательную переменную текста
                element = new AreaWithText(point);
            //Если включен режим создания линии
            else if (lineRadioButton.Checked)
                //Иницилизация в спомогательную переменную линии
                element = new Line(point);
            //Если включен режим создания стрелки
            else if (arrowRadionButton.Checked)
                //Иницилизация в спомогательную переменную стрелки
                element = new Arrow(point);
            //Если вспомогательная переменная не равна null
            if (element != null)
            {
                //Иницилизация некоторых свойств элемента 
                InitilizateProperties(element);
                //Центрирование его
                CenterElement(element);
                //добавление элемента в блок-схему
                diagram.AddElement(element);
            }
            //Устновка выбранного элемента блок-схемы
            SelectedElement = element;
        }
        //Метод иницилизации свойств элемента блок-схемы
        private void InitilizateProperties(object element)
        {
            //Если элемент - объект класса Area
            if (element is OperationalBlock block)
            {
                //Иницилизация его свойств в соотведствии с данными элементов управления формы
                block.FillColor = fillColorPanel.BackColor;
                block.ContourColor = contourColorPanel.BackColor;
                block.ContourThick = Int32.Parse(thickUpDownButton.Text);
                block.DashStyle = GetDashStyleFromControl();
            }
            //Если элемент - объект класса Line
            else if (element is Line line)
            {
                //Иницилизация его свойств в соотведствии с данными элементов управления формы
                line.ContourColor = contourColorPanel.BackColor;
                line.ContourThick = Int32.Parse(thickUpDownButton.Text);
                line.DashStyle = GetDashStyleFromControl();
            }
        }
        //Метод получение вида линии из списка ComboBox
        private DashStyle GetDashStyleFromControl()
        {
            //Выбор между индексами элемента управления ComboBox
            switch (dashStyleComboBox.SelectedIndex)
            {
                //Если выбранный индекс равень 0
                case 0:
                    //то вернуть сплошной тип контура
                    return DashStyle.Solid;
                //Если выбранный индекс равень 1
                case 1:
                    //то вернуть тип контура штрихами
                    return DashStyle.Dash;
                //Если выбранный индекс равень 2
                case 2:
                    //то вернуть штрих-точка тип контура
                    return DashStyle.DashDot;
                //Если выбранный индекс равень 3
                case 3:
                    //то вернуть штрих-точка-точка тип контура
                    return DashStyle.DashDotDot;
                //Если выбранный индекс равень 4
                case 4:
                    //то вернуть точеный тип контура
                    return DashStyle.Dot;
                //Если выбранный индекс не соотведствует ни одному из верхних
                default:
                    //то вернуть сплошной тип контура
                    return DashStyle.Solid;
            }
        }
        //Метод изменение размера элемента блок схемы
        private void ResizeElement(IDiagramElement element, Point point)
        {
            //Иницилизация смещения курсора мыши по осям XY
            int deltaX = point.X - oldMousePoint.X;
            int deltaY = point.Y - oldMousePoint.Y;
            //Если элемент блок-схемы - область
            if (element is AreaWithText area)
            {
                //Иницилизация размера 
                Size newSize = area.Size;
                //Увеличение размер на смещение курсора мыши умноженное на 2
                newSize.Width += deltaX * 2 ;
                newSize.Height += deltaY * 2 ;
                //Установка нового размера элемента блок-схемы
                area.Size = newSize;
                //Если размер был изменён
                if (newSize == area.Size)
                {
                    //то создание вспомогательной переменной положения элемента блок-схемы
                    Point newPoint = area.Point;
                    //Смещение точки, чтобы центр элемента блок-схемы не перемещался
                    newPoint.Offset(-deltaX, -deltaY);
                    //Установка новаого положения элемента блок-схемы
                    area.Point = newPoint;
                }
                //Сохранение нового положения курсора мыши
                oldMousePoint = point;
            }
            //Иначе если элемент-блок-схемы - линия
            else if (element is Line line)
            {
                //Первая точка линии распологается в старом положении курсора мыши
                line[0] = oldMousePoint;
                //Вторая точка мыши распологается в месте курсора мыши
                line[1] = point;
            }
        }      
        //Метод центрирования элемента блок-схемы
        private void CenterElement(IDiagramElement element)
        {
            if (element is AreaWithText area)
                area.Rectangle = new Rectangle(area.Rectangle.X - area.Rectangle.Width / 2, area.Rectangle.Y - area.Rectangle.Height / 2,
                    area.Rectangle.Width, area.Rectangle.Height);
            else if (element is Line line)
                line.Move(-line.Rectangle.Width / 2, -line.Rectangle.Height / 2);
        }
        #endregion
        //Обработчик события нажатия на клавиши
        private void zoomAndDragControl_KeyPress(object sender, KeyEventArgs e)
        {
            //Если нажаты клавиши Backspace или Delete
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                //Если есть выбранный элемент блок-схемы
                if (SelectedElement != null)
                {
                    //Удаление этого элемента из блок-схемы
                    diagram.DeleteElement(SelectedElement);
                    SelectedElement = null;
                }
            }
        }
        //Обработчик события нажатия на панель выбора цвета
        private void fillColorPanel_Click(object sender, EventArgs e)
        {
            //Если объект, вызвавший событие - это панель
            if (sender is Panel panel)
            {
                //Создание диалогового окна выбора цвета
                var cd = new ColorDialog();
                //Если диалоговое окно закрыто нажатием кнопки Ok
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    //Установка цвета панели на тот, который был избран в диалоговом окне
                    panel.BackColor = cd.Color;
                }
                //Очистка ресурсов диалового окна
                cd.Dispose();
            }
        }
        //Обработчик события изменения свойства в элементе propertyGrid
        private void propertyGrid1_PropertyValueChanged_1(object s, PropertyValueChangedEventArgs e)
        {
            //Вызов перерисовки элемента управления, где происходит рисование блок-схемы
            zoomAndDragControl1.Refresh();
        }
        #region Методы кнопок контекстного меню
        //Нажатие на кнопку удаления элемента
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Если есть выбранный для редактирования элемент блок-схемы
            if (SelectedElement != null)
            {
                //Удалить этот элемент из блок-схемы
                diagram.DeleteElement(SelectedElement);
                SelectedElement = null;
            }
        }
        //Обработчик события нажатия на кнопку добавления точки в линию
        private void addPointButton_Click(object sender, EventArgs e)
        {
            //Элемент блок-схемы для редактрирования - это линия
            if (SelectedElement is Line line)
                //Вставить точку
                line.InsertPoint(oldMousePoint, line.GetAllPoints().Length - 1);
            //Вызов перерисовки элемента управления
            zoomAndDragControl1.Refresh();
        }
        //Обработчик события нажатия на кнопку удаления точки из линию
        private void удалитьТочкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectedElement is Line line)
            {
                //Индекс последней точки ломанной линии
                int index = line.GetAllPoints().Length - 1;
                //Если индекс предпоследней точки линии больше 1
                if (index > 1)
                    //Удалить предпоследнюю точку линии
                    line.DeletePoint(index - 1);
                //Вызов перерисоки элемента управления
                zoomAndDragControl1.Refresh();
            }
        }
        //Обработчик события нажатия на кнопку перемещения элемента на передний план
        private void toForegroundButton_Click(object sender, EventArgs e)
        {
            //Если нет выбранного элемента
            if (SelectedElement == null)
                return;//Выйти из метода
            //Вызов метода переноса элемента блок-схемы на переднрий план
            diagram.ToForeground(SelectedElement);
            //Вызов перерисовки элемента управления
            zoomAndDragControl1.Refresh();
        }
        //Обработчик события нажатия на кнопку перемещения элемента на задний план
        private void toBackgroundButton_Click(object sender, EventArgs e)
        {
            //Если нет выбранного элемента
            if (SelectedElement == null)
                return;//Выйти из метода
            //Вызов метода переноса элемента блок-схемы на задний план план
            diagram.ToBackground(SelectedElement);
            //Вызов перерисовки элемента управления
            zoomAndDragControl1.Refresh();
        }
        #endregion
        #region Методы кнопок меню
        //Обработчик события нажатия на кнопку создания файла блок-схемы
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создание диалогово окна сохранения файла
            var sfd = new SaveFileDialog();
            //Установка фильра для диалогово окна
            sfd.Filter = "Бинарный файл (*.dat)|*.dat";
            //Попытка выполнения кода
            try
            {
                //Если диалогое окно закрыто нажатием кнопки Ok
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Если есть поток файла и выбранный файл уже находится в потоке
                    if (fileStream != null && fileStream.Name == sfd.FileName)
                        return;//Выход из метода
                    //Иначе иницилизация потока файла для чтения/записи из выбранного файла
                    fileStream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.ReadWrite);
                }
            }
            //Если полуена ошибка, то вывод сообщения
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось открыть файл");
            }
        }
        //Обработчик события закрытия формы
        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если пользователь зацрывает окно и в блок-схеме есть элементы
            if (e.CloseReason == CloseReason.UserClosing && diagram.Count != 0)
            {
                //То вывод сообщения
                //Если пользователь нажмёт кнопку No в сообщение
                if (MessageBox.Show("Вы уверенны, что хотите закрыть программу. Ваши данные не будут сохранены", 
                    "Внимание", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    //то отмена события закрытия формы
                    e.Cancel = true;
                    //Выход из метода
                    return;
                }
            }
            //Если пользователь закрывает форму
            //и если нет потока файла
            if (fileStream == null)
                return;//то выход из метода
            //Иначе если есть поток файлов,
            //то закрыть его и очистить его ресурсы
            fileStream.Close();
            fileStream.Dispose();
        }
        //Обработчик события нажатия на кнопку открытия файла
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создание диалогового окна открытия файла
            var ofd = new OpenFileDialog();
            //Установка фильтра диалогово окна
            ofd.Filter = "Бинарный файл (*.dat)|*.dat";
            //Если диалоговое окно закрыто с помощью кнопки Ok
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Объявление строковой переменной с путём к старому файлу
                string oldStreamName = "";
                //Попытка выполнения кода 
                try
                {
                    //Если поток фала равень null или выбранный для открытия файл не в потоке
                    if (fileStream == null || fileStream.Name != ofd.FileName)
                    {
                        //Если поток файла не равень null
                        if (fileStream != null)
                            //то сохранение пути к старому файлу
                            oldStreamName = fileStream.Name;
                        //то создание нового потока для чтения и записи в файл
                        fileStream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.ReadWrite);
                    }
                    //Создание бинарного форматора для десериализации
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    //Десериализация объекта в переменную
                    object deserializedObject = binaryFormatter.Deserialize(fileStream);
                    //Если десериализованный объект - не экземпляр класса Diagram
                    if (!(deserializedObject is Diagram))
                    {
                        //Закрытие потока и вывод сообщения
                        fileStream.Close();
                        MessageBox.Show("Сохрянённый файл не является блок-схемой");
                    }
                    else
                    {
                        //Иначе установка новой блок-схемы
                        diagram = (Diagram)deserializedObject;
                        SelectedElement = null;
                    }
                }
                //Если была получена ошибка, то 
                catch (Exception ex) 
                {
                    //Если файл по старому пути существует, то
                    if (File.Exists(oldStreamName))//Восстановления старого потока
                        fileStream = new FileStream(oldStreamName, FileMode.Open, FileAccess.ReadWrite);
                    //Если файла не существует, то
                    else
                    {
                        //освободить все ресурсы потока и обнулить его
                        fileStream.Close();
                        fileStream.Dispose();
                        fileStream = null;
                    }
                    //вывод сообщения
                    MessageBox.Show($"Не удолось открыть файл или файл уже открыт\nОшибки: {ex.Message}");
                }
            }
        }
        //Обработчик события нажатия на кнопку сохранения блок-схемы в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Если нет потока
            if (fileStream == null)
            {
                //то вызов метода создания файла
                создатьToolStripMenuItem_Click(sender, EventArgs.Empty);
                //Если поток не был создан, то выход из метода
                if (fileStream == null)
                    return;
            }
            //Создание бинарного форматора для сериализации
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            //Сериализация блок-схемы в поток
            binaryFormatter.Serialize(fileStream, diagram);
        }
        //Обработчик события нажатия на кнопку экспорта блок-схемы в файл
        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создание диалогово окна сохранения файла
            var sfd = new SaveFileDialog();
            //Установка фильтров для диалогового окна
            sfd.Filter = "Png (*.png)|*.png|Jpeg (*.jpeg)|*.jpeg|Bmp (*.bmp)|*.bmp";
            //Если диалоговое окно закрыто через нажатие на кнопку ok
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //Создание картинки
                Bitmap bitmap = GetBitmap(diagram);
                //Сохранение картинки в файл
                bitmap.Save(sfd.FileName);
                //Очистка неуправяемых ресурсов картинки
                bitmap.Dispose();
            }
        }
        //Метод получения картинки с блок-схемой
        private Bitmap GetBitmap(Diagram diagram)
        {
            //Получение прямоугольника в котором находится блок-схемы
            Rectangle rectangle = diagram.Rectangle;
            //Изменение размера и положения этого прямоугольника
            rectangle.Width += 20;
            rectangle.Height += 20;
            rectangle.X -= 10;
            rectangle.Y -= 10;
            //Создание картинки размером с этот прямоугольник
            Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            //Создание экземпляра класса Graphics из картики
            var g = Graphics.FromImage(bitmap);
            //Иницилизация матрицы преобразования
            Matrix matrix = new Matrix();
            //Ввод в матрицу смещения
            matrix.Translate(-rectangle.X, -rectangle.Y);
            //Установка матрицы преобразования в экземпляр класса Graphics
            g.Transform = matrix;
            //Установка режима рисования
            g.SmoothingMode = SmoothingMode.HighQuality;
            //Заполнение картинки белым цветом
            g.Clear(Color.White);
            //Рисование блок-схемы на картинке
            diagram.Draw(g);
            //Очистка ресурсов класса Graphics
            g.Dispose();
            //Вовращение полученной картинки
            return bitmap;
        }
        //Обработчик события нажатия на кнопку выхода из программы
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызов метода закрытия формы
            this.Close();
        }

        #endregion
        #endregion    
    }
}