using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace ReflectionUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Assembly myAPp = null;
        Type[] myClasses = null;
        ConstructorInfo[] myConstructor = null;
        MethodInfo[] myMethods = null;
        ParameterInfo[] myParameters = null;
        Type selectedClass = null;
        private void button1_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            myAPp = Assembly.LoadFrom(openFileDialog1.FileName);

            listBox1.Items.Clear();
            label6.Text = myAPp.FullName;
           
            myClasses = myAPp.GetTypes();

            foreach (var item in myClasses)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  string selectedClass = listBox1.Text;
            selectedClass = myAPp.GetType(listBox1.Text);
            //MessageBox.Show(selectedClass.ToString());

            myConstructor = selectedClass.GetConstructors();
            myMethods = selectedClass.GetMethods();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (var item in myConstructor)
            {
                listBox2.Items.Add(item.ToString());
            }
            foreach (var item in myMethods)
            {
                listBox3.Items.Add(item.Name.ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            MethodInfo selectedMethod = selectedClass.GetMethod(listBox3.Text);

            myParameters = selectedMethod.GetParameters();

            foreach (var item in myParameters)
            {
                listBox4.Items.Add(item);
            }
            button2.Text = selectedMethod.Name.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Type t = selectedClass;
            object obj = Activator.CreateInstance(t);
            MethodInfo m = t.GetMethod(listBox3.Text);

            MessageBox.Show(m.Invoke(obj,new object[] {Convert.ToInt32(textBox2.Text),Convert.ToInt32(textBox3.Text) }).ToString());
        }
    }
}









