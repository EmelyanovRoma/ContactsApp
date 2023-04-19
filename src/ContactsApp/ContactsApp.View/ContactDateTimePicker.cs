using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает элемент управления ContactDateTimePicker, 
    /// унаследованный от DateTimePicker.
    /// </summary>
    public class ContactDateTimePicker : DateTimePicker
    {
        /// <summary>
        /// Изображени иконки на элементе.
        /// </summary>
        private static readonly Image _calendarIcon = Properties.Resources.calendar_21x14;

        /// <summary>
        /// Длина области с иконкой в пикселях.
        /// </summary>
        private const float _calendarIconWidth = 34;

        /// <summary>
        /// Область иконки на элементе.
        /// </summary>
        private RectangleF _iconButtonArea;

        /// <summary>
        /// Цвет поля элемента.
        /// </summary>
        private Color _backColor;

        /// <summary>
        /// Цвет текста на элементе.
        /// </summary>
        private Color _textColor;

        /// <summary>
        /// Цвет границы элемента.
        /// </summary>
        private Color _borderColor;

        /// <summary>
        /// Размер границы элемента.
        /// </summary>
        private int _borderSize;

        /// <summary>
        /// Флаг открытия выпадающего окна с выбором даты элемента управления.
        /// </summary>
        private bool _isDroppedDown = false;

        /// <summary>
        /// Флаг фокуса элемента управления.
        /// </summary>
        private bool _isEnter = false;

        /// <summary>
        /// Флаг наведения мыши на элемент управления.
        /// </summary>
        private bool _isMouseEnter = false;

        /// <summary>
        /// Флаг движения мыши по элементу управления.
        /// </summary>
        private bool _isMouseMove = false;      

        /// <summary>
        /// Возвращает или задает цвет поля элемента.
        /// </summary>
        public override Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Возвращает или задает цвет текста на элементе.
        /// </summary>
        public Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                _textColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Возвращает или задает цвет границы элемента.
        /// </summary>
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Возвращает или задает размер границы элемента.
        /// </summary>
        public int BorderSize
        {
            get
            {
                return _borderSize;
            }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="ContactDateTimePicker"/>.
        /// </summary>
        public ContactDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 23);
            this.Font = new Font(this.Font.Name, 9F);
            this.BorderSize = 1;
            this.BackColor = Color.White;
            this.TextColor = Color.Black;
            this._borderColor = Color.FromArgb(255, 122, 122, 122);
        }

        /// <summary>
        /// Вызывает событие <see cref="Paint"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            using (Pen penBorderEnter = new Pen(Color.FromArgb(255, 0, 120, 215), BorderSize))
            using (SolidBrush skinBrush = new SolidBrush(BackColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(255, 204, 228, 247)))
            using (SolidBrush textBrush = new SolidBrush(TextColor))
            using (StringFormat textFormat = new StringFormat())
            {
                PointF areaLocation = new PointF(0, 0);
                SizeF areaSize = new SizeF(this.Width - 0.5F, this.Height - 0.5F);
                RectangleF clientArea = new RectangleF(areaLocation, areaSize);

                areaLocation = new PointF(clientArea.Width - _calendarIconWidth, 0);
                areaSize = new SizeF(_calendarIconWidth, clientArea.Height);
                RectangleF iconArea = new RectangleF(areaLocation, areaSize);

                areaLocation = new PointF(
                    this.Width - _calendarIcon.Width - 7, 
                    (this.Height - _calendarIcon.Height) / 2);
                areaSize = new SizeF(_calendarIcon.Width, _calendarIcon.Height);
                RectangleF iconPlace = new RectangleF(areaLocation, areaSize);

                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString(this.Text, this.Font, textBrush, clientArea, textFormat);

                if (_isDroppedDown)
                {
                    graphics.FillRectangle(openIconBrush, iconArea);
                }
                if (BorderSize >= 1)
                {
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, 
                        clientArea.Width, clientArea.Height);
                }
                if (_isMouseMove && _isMouseEnter)
                {
                    graphics.FillRectangle(openIconBrush, iconArea);
                    graphics.DrawRectangle(penBorderEnter, iconArea.X, iconArea.Y, 
                        iconArea.Width, iconArea.Height);
                }                
                graphics.DrawImage(_calendarIcon, iconPlace);
            }
        } 

        /// <summary>
        /// Вызывает событие <see cref="DropDown"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            _isDroppedDown = true;
        }

        /// <summary>
        /// Вызывает событие <see cref="CloseUp"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCloseUp(EventArgs e)
        {
            base.OnCloseUp(e);
            _isDroppedDown = false;
        }

        /// <summary>
        /// Вызывает событие <see cref="KeyPress"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }      

        /// <summary>
        /// Вызывает событие <see cref="MouseEnter"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isMouseEnter = true;

            if (_isEnter)
            {
                this.BorderColor = Color.FromArgb(255, 0, 120, 215);
            }
            else
            {
                this.BorderColor = Color.Black;
            }            

        }

        /// <summary>
        /// Вызывает событие <see cref="MouseLeave"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isMouseEnter = false;

            if (_isEnter)
            {
                this.BorderColor = Color.FromArgb(255, 0, 120, 215);
            }
            else
            {
                this.BorderColor = Color.FromArgb(255, 122, 122, 122);
            }
        }


        /// <summary>
        /// Вызывает событие <see cref="MouseMove"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (_iconButtonArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
                _isMouseMove = true;
            }
            else
            {
                this.Cursor = Cursors.Default;
                _isMouseMove = false;
            }
        }

        /// <summary>
        /// Вызывает событие <see cref="HandleCreated"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            _iconButtonArea = new RectangleF(
                this.Width - _calendarIconWidth, 0, _calendarIconWidth, this.Height);
        }

        /// <summary>
        /// Вызывает событие <see cref="Enter"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BorderColor = Color.FromArgb(255, 0, 120, 215);
            _isEnter = true;
        }

        /// <summary>
        /// Вызывает событие <see cref="Leave"/>.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BorderColor = Color.FromArgb(255, 122, 122, 122);
            _isEnter = false;
        }          
    }
}
