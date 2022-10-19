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
    public partial class SaveForm : Form
    {

        /// <summary>
        ///  Базовый конструктор класса.
        /// </summary>
        public SaveForm()
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
        /// Событие, происходящее при нажатие на кнопку отмены.
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
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
