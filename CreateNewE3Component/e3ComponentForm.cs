using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateNewE3Component
{
    public partial class e3ComponentForm : Form
    {
        public e3ComponentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this.componentAttributeTableAdapter.FillBy(this.componentAttribute._ComponentAttribute);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkInE3Button_Click(object sender, EventArgs e)
        {
            try
            {
                this.componentAttributeTableAdapter.FillBy(this.componentAttribute._ComponentAttribute);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBySelectedImbaseKeysToolStripButton_Click(object sender, EventArgs e)
        {
            // Парсим введенный текст в массив
            inputTextBox.Text = inputTextBox.Text.Replace("\t", "").Replace(" \nIMBASE_KEY", "");
            string[] imbaseKeys = inputTextBox.Text.Replace("\nI","").Replace("\t", "").Replace("  ", "").Trim().Split();
          
            foreach (string imbaseKey in imbaseKeys)
            {
                try
                {
                    //временный компонент, нигде не использую
                    ComponentAttribute.ComponentAttributeDataTable dataTable = new ComponentAttribute.ComponentAttributeDataTable();
                    this.componentAttributeTableAdapter.FillBySelectedImbaseKeys(this.componentAttribute._ComponentAttribute, imbaseKey);
                    this.componentAttributeTableAdapter.ClearBeforeFill = false;
                    this.componentAttributeTableAdapter.FillBySelectedImbaseKeys(dataTable, imbaseKey);
                    if (dataTable.Count() > 0)
                    {                        
                        inputTextBox.Text = inputTextBox.Text.Replace(imbaseKey, "");
                    }
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }  
        }

        private void fillBySelectedImbaseKeysToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
