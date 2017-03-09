using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ClassLibrary1;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{
    public partial class AddElementForm : Form
    {
      public AddElementForm()
        {
            InitializeComponent();
            listControl.Add(Controls);
            listControl.Add(groupBox1.Controls);
        }
     private BindingList<Control.ControlCollection> listControl = new BindingList<Control.ControlCollection>();
     private BindingList<TextBox> _textBoxList = new BindingList<TextBox>();
     private Point textBoxCoordinates = new Point(10, 68);
     private Point labelCoordinates = new Point(10, 50);
     private BindingList<Label> _labelList = new BindingList<Label>(); 

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            CreateInnerForms cr = new CreateInnerForms(listControl);
            switch (comboBox1.SelectedIndex)
            {

                case 0 :
                    {
                        cr.ClearBindingListLabel(_labelList, listControl);
                        cr.ClearBindingListTextBox(_textBoxList, listControl);
                        List<string> name = new List<string>();
                        name.Add("one");
                        name.Add("two");
                        name.Add("three");
                        _labelList = cr.CreatingLabel(name, labelCoordinates);
                     _textBoxList = cr.CreatingTextBox(name, textBoxCoordinates);
                        break; 
                    }
                case 1:
                    {
                        cr.ClearBindingListLabel(_labelList, listControl);
                        cr.ClearBindingListTextBox(_textBoxList, listControl);
                        List<string> name = new List<string>();
                        name.Add("one1");
                        name.Add("two1");
                        name.Add("three1");
                        _labelList = cr.CreatingLabel(name, labelCoordinates);
                       _textBoxList=cr.CreatingTextBox(name,textBoxCoordinates);
                        break; 

                    }
                case 2:
                    {
                        cr.ClearBindingListLabel(_labelList, listControl);
                        cr.ClearBindingListTextBox(_textBoxList, listControl);
                        List<string> name = new List<string>();
                        name.Add("one2");
                        _labelList = cr.CreatingLabel(name, labelCoordinates);
                        _textBoxList = cr.CreatingTextBox(name, textBoxCoordinates);
                        break; 
                    }
                
                default: break; 
            }

        }

    }


}
