using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Notepad_
{
    public partial class NotePad : Form
    {
        // Приватные переменные, хранящие период автосохранения и тему приложения.
        private int _time = 0;
        private string _theme = "Light";

        // Свойства для запоминания выделенного текста, при нажатии на кнопки форматирования.
        private int Start { get; set; }
        private int Length { get; set; }

        /// <summary>
        /// Аксессор к приватному полю _time.
        /// Возвращает значение поля.
        /// Записывает значение, переведенное из минут в миллисекунды, в поле.
        /// </summary>
        public int Time
        {
            get
            {
                try
                {
                    return _time;
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, попробуйте снова.");
                    return 0;
                }
            }
            set
            {
                try
                {
                    _time = value * 60 * 1000;
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, попробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Аксессор к приватному полю _time.
        /// Возвращает значение поля.
        /// Записывает значение в поле.
        /// </summary>

        public string Theme
        {
            get
            {
                try
                {
                    return _theme;
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, попробуйте снова.");
                    return "Light";
                }
            }
            set
            {
                try
                {
                    _theme = value;
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка, попробуйте снова.");
                }
            }
        }

        /// <summary>
        /// Базовый конструктор класса.
        /// </summary>
        public NotePad()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Рекурсивный метод для задания стиля всем элементам формы, 
        /// которые доступны напрямую.
        /// </summary>
        /// <param name="form">Форма, для которой нужно выполнить действие.</param>
        /// <param name="ctrls">Все ей подконтрольные элементы.</param>
        public void SetAllControlsColor(NotePad form, Control.ControlCollection ctrls)
        {
            try
            {
                foreach (Control ctrl in ctrls)
                {
                    if (ctrl.Controls != null)
                        SetAllControlsColor(form, ctrl.Controls);

                    if (form.Theme == "Light")
                    {
                        ctrl.BackColor = SystemColors.Window;
                        ctrl.ForeColor = SystemColors.ControlText;
                    }
                    else if (form.Theme == "Dark")
                    {
                        ctrl.BackColor = Color.FromArgb(39, 41, 45);
                        ctrl.ForeColor = SystemColors.Window;
                    }
                }
                foreach (Button button in Controls.OfType<Button>())
                {
                    button.BackColor = SystemColors.Window;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод для установки темы для всех контекстных меню формы.
        /// </summary>
        /// <param name="form">Форма, для которой нужно выполнить действие.</param>
        public void SetContextMenuColor(NotePad form)
        {
            try
            {
                if (form.Theme == "Light")
                {
                    foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
                    {
                        foreach (ToolStripMenuItem item in menuItem.DropDownItems)
                        {
                            item.BackColor = SystemColors.Window;
                            item.ForeColor = SystemColors.ControlText;
                        }

                    }

                    form.TextBox.ContextMenuStrip.BackColor = SystemColors.Window;
                    form.TextBox.ContextMenuStrip.ForeColor = SystemColors.ControlText;
                }
                else if (form.Theme == "Dark")
                {
                    foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
                    {
                        foreach (ToolStripMenuItem item in menuItem.DropDownItems)
                        {
                            item.BackColor = Color.FromArgb(39, 41, 45);
                            item.ForeColor = SystemColors.Window;
                        }
                    }
                    form.TextBox.ContextMenuStrip.BackColor = Color.FromArgb(39, 41, 45);
                    form.TextBox.ContextMenuStrip.ForeColor = SystemColors.Window;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Установка цвета для самой формы.
        /// </summary>
        /// <param name="notePad">Форма, из которой берется значение темы.</param>
        /// <param name="form">Форма, для которой нужно выполнить действие.</param>
        public void SetFormColor(NotePad notePad, Form form)
        {
            try
            {
                if (notePad.Theme == "Light")
                {
                    form.BackColor = SystemColors.Window;
                    form.ForeColor = SystemColors.ControlText;
                }
                else if (notePad.Theme == "Dark")
                {
                    form.BackColor = Color.FromArgb(39, 41, 45);
                    form.ForeColor = SystemColors.Window;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Запуск таймера для отсчета времени для автосохранения.
        /// </summary>
        public void LaunchTimer()
        {
            try
            {
                if (Time != 0)
                {
                    timer1.Enabled = true;
                    timer1.Interval = Time;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при каждом тике таймера.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
                foreach (NotePad form in forms)
                {
                    foreach (TabPage page in form.tabControl.TabPages)
                    {
                        if (File.Exists(((RichTextBox)page.Controls[0]).Name))
                        {
                            WriteToFile((RichTextBox)page.Controls[0]);
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, возникающее при изменении текста в поле для ввода.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Text[^1] != '*')
                {
                    tabControl.SelectedTab.Text += "*";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод для загрузки формы.
        /// В нем также устанавливаются Shortcut-ы для всех кнопок.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem[] menuItems = { createNewMenuItem, createNewWindowMenuItem, saveMenuItem,
                saveAllMenuItem, openMenuItem, closeMenuItem, closeFileMenuItem};
                Keys[] shorts = { Keys.N, Keys.W, Keys.S, Keys.D, Keys.O, Keys.E, Keys.Q };
                for (int i = 0; i < menuItems.Length; i++)
                {
                    menuItems[i].ShortcutKeys = Keys.Control | shorts[i];
                    menuItems[i].ShowShortcutKeys = false;
                }
                FormClosing += RaiseSaveBeforeClosing_FormClosing;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }

        }

        /// <summary>
        /// Событие для сохранения длины и индекс начала выделенного текста.
        /// Происходит, когда нажимается кнопка.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveSelection_MouseDown(object sender, MouseEventArgs e)
        {
            var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            Start = textBox.SelectionStart;
            Length = textBox.SelectionLength;
            textBox.Select(Start, Length);
        }

        /// <summary>
        /// Событие, происходящее при загрузке формы.
        /// В нем также устанавливаются Shortcut-ы для всех кнопок.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                float.Parse(FontSizeBox.SelectedItem.ToString()), textBox.SelectionFont.Style);
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии кнопки курсива.
        /// Добавляет или убирает это свойство у выделенного текста
        /// в зависимости от исходного значения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItalicButton_Click(object sender, EventArgs e)
        {
            var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            if (textBox.SelectionFont.Italic)
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style | FontStyle.Italic);
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии кнопки жирного шрифта.
        /// Добавляет или убирает это свойство у выделенного текста
        /// в зависимости от исходного значения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void BoldButton_Click(object sender, EventArgs e)
        {
            var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            if (textBox.SelectionFont.Bold)
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style | FontStyle.Bold);
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии кнопки подчеркивания.
        /// Добавляет или убирает это свойство у выделенного текста
        /// в зависимости от исходного значения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void UnderLineButton_Click(object sender, EventArgs e)
        {
            var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            if (textBox.SelectionFont.Underline)
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style | FontStyle.Underline);
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии кнопки зачеркивания.
        /// Добавляет или убирает это свойство у выделенного текста
        /// в зависимости от исходного значения.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void StrikeOutButton_Click(object sender, EventArgs e)
        {
            var textBox = (RichTextBox)tabControl.SelectedTab.Controls[0];
            if (textBox.SelectionFont.Strikeout)
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style & ~FontStyle.Strikeout);
            }
            else
            {
                textBox.SelectionFont = new Font(textBox.SelectionFont.FontFamily,
                textBox.SelectionFont.SizeInPoints, textBox.SelectionFont.Style | FontStyle.Strikeout);
            }
        }

        /// <summary>
        /// Событие, происходящее при закрытии какой-либо формы типа "NotePad".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CloseWindowMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод для сохранения настроек в файл.
        /// Позже из него будут загружаться настройки, при запуске приложения.
        /// </summary>
        private void SaveHiddenSettings()
        {
            try
            {
                StringBuilder text = new();
                text.Append($"{Time}\n{Theme}\n");
                foreach (TabPage page in tabControl.TabPages)
                {
                    if (File.Exists(((RichTextBox)page.Controls[0]).Name))
                    {
                        text.Append($"{((RichTextBox)page.Controls[0]).Name}\n");
                    }
                }
                File.WriteAllText("settings.txt", text.ToString());
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Считывание настрок из файла и выставление их для текущих форм.
        /// </summary>
        public void CollectSettingsData()
        {
            try
            {
                if (File.Exists("settings.txt"))
                {
                    string[] lines = File.ReadAllLines("settings.txt");
                    Time = int.Parse(lines[0]) / 60000;
                    Theme = lines[1];
                    foreach (string path in lines[2..])
                    {
                        if (File.Exists(path))
                        {
                            TabPage myTabPage = new TabPage($"{Path.GetFileName(path)}");
                            tabControl.TabPages.Add(myTabPage);
                            // Добавления поля для текста в новых вкладках, при загрузке файлов, которые были не закрыты при выходе в прошлый раз.
                            var textBox = new RichTextBox(); 
                            textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                            textBox.Location = new Point(-3, 0);
                            textBox.Margin = new Padding(0, 0, 0, 0);
                            textBox.Size = new Size(804, 399);
                            textBox.ContextMenuStrip = contextMenu;
                            textBox.Click += TextBox_TextChanged;
                            textBox.Name = path;
                            myTabPage.Controls.Add(textBox);
                            ReadBySavings(textBox);
                        }
                    }
                    SetFormColor(this, this);
                    SetContextMenuColor(this);
                    SetAllControlsColor(this, Controls);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }


        /// <summary>
        /// Событие, происходящее до момента закрытия какой-либо формы типа "NotePad".
        /// Вызывает окна, предлагающие сохранить каждый несохраненный файл в форме.
        /// Если закрывается корневое окно, то будет предложено сохранить файлы во всех окнах.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void RaiseSaveBeforeClosing_FormClosing(object sender, CancelEventArgs e)
        {
            try
            {
                foreach (TabPage page in tabControl.TabPages)
                {
                    if (page.Text[^1] == '*')
                    {
                        var saveWindow = new SaveForm();
                        saveWindow.Owner = this;
                        saveWindow.Text = page.Text[..^1];
                        SetFormColor(this, saveWindow);
                        SetAllControlsColor(this, saveWindow.Controls);
                        DialogResult result = saveWindow.ShowDialog();
                        if (result == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            return;
                        }
                        if (result == DialogResult.Yes)
                        {
                            WriteToFile((RichTextBox)page.Controls[0]);
                        }
                    }
                }
                SaveHiddenSettings();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }


        /// <summary>
        /// Событие, происходящее при изменении стиля элементов.
        /// Из-за этого изменения в темной теме кнопки стновятся плохо видны.
        /// Это событие устанавливает вновь им белый фон, чтобы их можно было различить.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItalicButton_StyleChanged(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку создания окна.
        /// Создает новое окно и передает ему все настройки родительского окна.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateWindowMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var window = new NotePad();
                window.Owner = this;
                IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
                window.Theme = forms.ElementAt(0).Theme;
                window.SetAllControlsColor(window, window.Controls);
                window.SetFormColor(window, window);
                window.SetContextMenuColor(window);
                window.Show();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку создания новой вкладки.
        /// Создает новую вкладку в текущей форме.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateTabMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage myTabPage = new TabPage($"Безымянный{tabControl.TabPages.Count}");
                tabControl.TabPages.Add(myTabPage);
                // Добавления поля для текста в новых вкладках.
                var textBox = new RichTextBox();
                textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
                textBox.Location = new Point(-3, 0);
                textBox.Margin = new Padding(0, 0, 0, 0);
                textBox.Size = new Size(804, 399);
                textBox.ContextMenuStrip = contextMenu;
                textBox.Click += TextBox_TextChanged;
                myTabPage.Controls.Add(textBox);
                SetAllControlsColor(this, Controls);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку закрытия текущей вкладки.
        /// Закрывает вкладку и перед этим предлагает сохраниться.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CloseTabMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var page = tabControl.SelectedTab;
                if (page.Text[^1] == '*')
                {
                    var saveWindow = new SaveForm();
                    saveWindow.Owner = this;
                    saveWindow.Text = page.Text[..^1];
                    SetFormColor(this, saveWindow);
                    SetAllControlsColor(this, saveWindow.Controls);
                    DialogResult result = saveWindow.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        WriteToFile((RichTextBox)page.Controls[0]);
                        tabControl.TabPages.Remove(page);
                    }
                    if (result == DialogResult.No)
                    {
                        tabControl.TabPages.Remove(page);
                    }
                }
                else
                {
                    tabControl.TabPages.Remove(page);
                }
                if (tabControl.TabPages.Count == 0)
                {
                    CreateTabMenuItem_Click(sender, e);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку настроек.
        /// Вызывает окно настроек и передает ему тему родительского окна.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var settings = new Settings();
                settings.Owner = this;
                SetAllControlsColor(this, settings.Controls);
                SetFormColor(this, settings);
                settings.ShowDialog();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку открытия файла.
        /// Вызывает метод для считывания файла.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ReadFile(GetTextBox());
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку сохранения всех файлов(включая безымянных!).
        /// Запускает метод для сохранения файлов.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveAllMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile(false);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку сохранения файла в текущей вкладке.
        /// Вызывает метод для сохранения этого файла.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFile();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нету доступа к этому файлу.");
            }
            catch (IOException)
            {
                MessageBox.Show("Файл занят другим процессом.");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку выделения всего текста.
        /// Выделяет весь текст.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void ChooseAll_Click(object sender, EventArgs e)
        {
            try
            {
                SendKeys.SendWait("^(a)");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку вырезать.
        /// Вырезает выделенный текст.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Cut_Click(object sender, EventArgs e)
        {
            try
            {
                SendKeys.SendWait("^(x)");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку скопировать.
        /// Копирует выделенный текст.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Copy_Click(object sender, EventArgs e)
        {
            try
            {
                SendKeys.SendWait("^(c)");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Событие, происходящее при нажатии на кнопку вставить.
        /// Вставляет текст из буфера обмена.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Paste_Click(object sender, EventArgs e)
        {
            try
            {
                SendKeys.SendWait("^(v)");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод для получения поля для печатания, в текущей форме.
        /// </summary>
        /// <returns></returns>
        private RichTextBox GetTextBox()
        {
            try
            {
                return (RichTextBox)tabControl.SelectedTab.Controls[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Возникла ошибка, попробуйте еще раз.");
                return new RichTextBox();
            }
        }

        /// <summary>
        /// Метод для вызова записи в файл.
        /// Может сохранить один или несколько файлов.
        /// </summary>
        /// <param name="flag">Индикатор для обозначения, множественного и единственного сохранения</param>
        private void SaveFile(bool flag = true)
        {
            if (flag)
            {
                WriteToFile(GetTextBox());
            }
            else
            {
                IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
                foreach (NotePad form in forms)
                {
                    foreach (TabPage page in form.tabControl.TabPages)
                    {
                        WriteToFile((RichTextBox)page.Controls[0]);
                    }
                }
            }
        }

        /// <summary>
        /// Запись в файл в случае, если файл существует.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="textBox">Поле, из которого берется текст.</param>
        private void WriteIfExist(string filePath, RichTextBox textBox)
        {
            if (filePath[filePath.LastIndexOf(".")..] == ".txt")
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    textBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
                    writer.Write(textBox.Text);
                }
                textBox.Parent.Text = Path.GetFileName(textBox.Name);
            }
            else
            {
                textBox.ForeColor = SystemColors.ControlText;
                textBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                var form = textBox.FindForm();
                SetAllControlsColor((NotePad)form, form.Controls);
                textBox.Parent.Text = Path.GetFileName(textBox.Name);
            }
        }

        /// <summary>
        /// Запись в файл в случае, если файл не существует.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="textBox">Поле, из которого берется текст.</param>
        /// <param name="openFileDialog">Диалоговое окно для сохранения файла.</param>
        private void WriteIfNotExist(string filePath, RichTextBox textBox, SaveFileDialog openFileDialog)
        {
            if (textBox.SelectedRtf.Length == 0)
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
            }
            else
            {
                openFileDialog.Filter = "rtf files (*.rtf)|*.rtf";
            }
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileStream = openFileDialog.OpenFile();
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    if (textBox.Rtf.Length == 0)
                    {
                        writer.Write(textBox.Text);
                    }
                    else
                    {
                        MessageBox.Show(textBox.Rtf);
                        textBox.ForeColor = SystemColors.ControlText;
                        writer.Write(textBox.Rtf);
                        var form = textBox.FindForm();
                        SetAllControlsColor((NotePad)form, form.Controls);
                    }
                }
                textBox.Name = openFileDialog.FileName;
                textBox.Parent.Text = Path.GetFileName(textBox.Name);
            }
        }

        /// <summary>
        /// Метод для запуска сохранения файла. 
        /// Может вызвать сохранение для файла, который существует и не существует.
        /// </summary>
        /// <param name="textBox">Поле, из которого берется текст.</param>
        private void WriteToFile(RichTextBox textBox)
        {
            var fileContent = textBox.Text;
            var filePath = textBox.Name;
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                if (File.Exists(filePath))
                {
                    WriteIfExist(filePath, textBox);
                }
                else
                {
                    WriteIfNotExist(filePath, textBox, openFileDialog);
                }

            }
        }

        /// <summary>
        /// Метод для считывания файлов, по их полному пути из файла настроек.
        /// </summary>
        /// <param name="textBox">Поле для заполнения текстом из файла.</param>
        private void ReadBySavings(RichTextBox textBox)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            if (File.Exists(textBox.Name))
            {
                if (textBox.Name[textBox.Name.LastIndexOf(".")..] == ".txt")
                {
                    textBox.Text = File.ReadAllText(textBox.Name);
                }
                else
                {
                    textBox.LoadFile(textBox.Name);
                }
            }
            var form = textBox.FindForm();
            SetAllControlsColor((NotePad)form, form.Controls);
        }

        /// <summary>
        /// Метод для пользовательского считывания файла
        /// </summary>
        /// <param name="textBox">Поле для заполнения текстом из файла.</param>
        private void ReadFile(RichTextBox textBox)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt, rtf files (*.txt, *.rtf)|*.txt;*.rtf";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    textBox.Name = filePath;
                    tabControl.SelectedTab.Text = Path.GetFileName(filePath);
                    if (filePath[filePath.LastIndexOf(".")..] == ".txt")
                    {
                        var fileStream = openFileDialog.OpenFile();
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                        }
                        textBox.Text = fileContent;
                    }
                    else
                    {
                        textBox.LoadFile(filePath);
                        var form = textBox.FindForm();
                        WriteToFile(textBox);
                    }
                    textBox.Name = filePath;
                    tabControl.SelectedTab.Text = Path.GetFileName(filePath);
                }
            }
        }
    }
}
