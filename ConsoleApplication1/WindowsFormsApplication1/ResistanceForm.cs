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
using System.Xml.Serialization;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class ResistanceForm : Form
    {
        /// <summary>
        /// Привязка Label 
        /// </summary>
        private BindingList<Label> LabelList = new BindingList<Label>();
        /// <summary>
        /// Привязка текстбокса
        /// </summary>
        private BindingList<TextBox> TextBoxList = new BindingList<TextBox>();
        /// <summary>
        /// Создание самого списка
        /// </summary>
        private List<MathCount> ListElement = new List<MathCount>(); 
        public ResistanceForm()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            AddElementForm AddForm = new AddElementForm();
           AddForm.ShowDialog(); 
        }
    }
}
