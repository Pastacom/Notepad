using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_
{
    public partial class Settings : Form
    {

        /// <summary>
        /// Базовый конструктор класса.
        /// </summary>
        public Settings()
        {
            try
            {
                InitializeComponent();
                comboBox1.Text = ConstructStringTime();
                GetTheme();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }
        }

        /// <summary>
        /// Метод для выделения времени в минутах из строки.
        /// </summary>
        /// <param name="input">Подаваемая строка.</param>
        /// <returns></returns>
        private static int ExtractIntTime(string input)
        {
            try
            {
                if (input != "никогда")
                {
                    return int.Parse(input[6..8]);
                }
                return 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
                return 0;
            }
        }

        /// <summary>
        /// Метод для сборки строки из числового значения.
        /// </summary>
        /// <returns></returns>
        private static string ConstructStringTime()
        {
            try
            {
                IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
                int input = forms.ElementAt(0).Time;
                if (input != 0 && input != 60000)
                {
                    return $"раз в {input/60000} минут";
                }
                else if(input == 60000)
                {
                    return $"раз в 1 минуту";
                }
                return "никогда";
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
                return "никогда";
            }
        }

        /// <summary>
        /// Метод для получения темы из значений нажатых кнопок.
        /// </summary>
        /// <returns></returns>
        private string ExtractTheme()
        {
            if (radioButton1.Checked == true)
            {
                return "Light";
            }
            else
            {
                return "Dark";
            }
        }

        /// <summary>
        /// Метод для установки значения кнопок, зависящие от значения темы.
        /// </summary>
        private void GetTheme()
        {
            IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
            string input = forms.ElementAt(0).Theme;
            if(input == "Light")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        /// <summary>
        /// Событие, возникающее при нажатии на кнопку сохранить.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void SaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<NotePad> forms = Application.OpenForms.OfType<NotePad>();
                var time = ExtractIntTime(comboBox1.Text);
                foreach (NotePad form in forms)
                {
                    form.Time = time;
                    form.LaunchTimer();
                    form.Theme = ExtractTheme();
                    form.SetAllControlsColor(form, form.Controls);
                    form.SetFormColor(form, form);
                    form.SetContextMenuColor(form);
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка, попробуйте снова.");
            }

        }

        /// <summary>
        /// Событие, возникающее при нажатии на кнопку отменить.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void Cancel_Click(object sender, EventArgs e)
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
    }
}
