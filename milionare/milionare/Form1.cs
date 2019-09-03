using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using milionare.dictionaryDataSetTableAdapters;

namespace milionare
{
    public partial class Form1 : Form
    { 
        millionareTableAdapter  myTable = new millionareTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void onload(object sender, EventArgs e)
        {
            Random randomings = new Random();
            int questionNumber = randomings.Next(myTable.GetData().Count); ;
            var line = myTable.GetData()[questionNumber];
            

            label_question.Text = line.question;
            button_answer1.Text = line.answer;
            button_answer2.Text = line.answer_not1;
            button_answer3.Text = line.answer_not2;
            button_answer4.Text = line.answer_not3;
            if (myTable.correct_answer(label_question.Text, button_answer1.Text) == 1)
                MessageBox.Show("you're correct!");
            else
                MessageBox.Show("incorrect, try again");
        }
    }
}
