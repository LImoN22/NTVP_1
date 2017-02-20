using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
  
  public  class CreateInnerForms
    {
      private BindingList<TextBox> TextBoxList = new BindingList<TextBox>(); 
      /// <summary>
      /// Текст бокс возвращает Controls 
      /// </summary>
      /// <param name="name"></param>
      /// <param name="locationX"></param>
      /// <param name="locationY"></param>
      /// <param name="control"></param>
      /// <param name="enabledTextBox"></param>
      /// <returns></returns>
      private TextBox CreatingTextBox(string name, int locationX, int locationY, bool enabledTextBox)
      {
          TextBox textBox = new TextBox();
          textBox.Name = name;
          textBox.Location = new System.Drawing.Point(locationX, locationY);
          textBox.Size = new System.Drawing.Size(100, 20);
          textBox.Visible = true;
          textBox.Enabled = enabledTextBox;
          //не обязательно передавать в обычнх контрол можно сразу передедать через groupBox
          //control[0].Add(textBox);
         // TextBoxList.Add(textBox);
          return (textBox);

      }
      /// <summary>
      /// Конструктор для текстбоксов
      /// </summary>
      int _textBoxAmount;
      
      public  CreateInnerForms(int TextBoxAmount)  
      {
          _textBoxAmount = TextBoxAmount; 
      }

     
     /// <summary>
     /// Циклический метод создания текст боксов 
     /// </summary>
      private void CycleCreationOfTextBox( ) 
      {
          
          for (int i = 0; _textBoxAmount == i; i++)
          {
              TextBoxList.Add(CreatingTextBox(i.ToString(), 20, (20 + 40 * i),true));
          }
 
      }
      public BindingList<TextBox> ReturnParametr
      {
          get 
          {
              CycleCreationOfTextBox ();
              return TextBoxList; 
          }
         
      }
      private BindingList<Control> _bindingListControls;
      public BindingList<Control> ReciveParametr
      {

          set
          {
              _bindingListControls = value; 

              
          }

      }

    }
}
