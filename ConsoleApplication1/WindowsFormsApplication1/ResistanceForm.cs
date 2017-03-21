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
    public partial class ResistanceForm : Form, IAddFiguresDelegate
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
        private List<IMathCount> ListElement = new List<IMathCount>(); 
        public ResistanceForm()
        {
            InitializeComponent();
        }

       private IMathCount _figure;
      /// <summary>
      /// Коструктор для делигата 
      /// </summary>
      /// <param name="figure"></param>
        public void DelegateInnerFunc(IMathCount figure)
        {
            _figure = figure;
        }
   
       private void AddObject_Click(object sender, EventArgs e)
        {
            AddElementForm AddForm = new AddElementForm();
           AddForm.ShowDialog(); 
        }
        /// <summary>
        /// запись в грид
        /// </summary>
        private void WriteInGrid()
        {
            GridView.Rows.Clear();
            foreach ( var figure in ListElement)
            {
                GridView.Rows.Add(figure.ElementType, figure.ResistanceCalculation);
            }
        }

        private void RemoveObject_Click(object sender, EventArgs e)
        {
            if (GridView.CurrentRow != null)
            {
                try
                {
                    ListElement.RemoveAt(GridView.CurrentRow.Index);
                    GridView.Rows.Remove(GridView.CurrentRow);
                }
                catch (System.InvalidOperationException) { }
            }
        }
    }
}
