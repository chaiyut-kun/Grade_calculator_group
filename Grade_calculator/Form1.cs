using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //unknown
        private void label1_Click(object sender, EventArgs e)
        {
            //unknown
        }


        int arr_index = 0;
        string[] all_id = new string[1000];
        string[] all_name = new string[1000];
        int[] all_score = new int[1000];
        string id_student ;
        string name_student ;
        string score_student;

        int max_idx , max_value , min_value , min_idx;
        

        private void Save_button_Click(object sender, EventArgs e)
        {

            id_student = text_id_student.Text;
            name_student = text_name.Text;
            score_student = (text_point.Text);

            all_id[arr_index]    = id_student;
            all_name[arr_index]  = name_student;
            all_score[arr_index] = int.Parse(score_student);

            arr_index++;
            text_name.Text = "";
            text_id_student.Text = "";
            text_point.Text = "";

            
            
            // max value , index
            max_value = all_score.Max();
            max_idx = all_score.ToList().IndexOf(max_value);

            // show output max
            text_id_student_max.Text = $"{all_id[max_idx]}";
            text_name_max.Text = $"{all_name[max_idx]}";
            text_point_max.Text = $"{all_score[max_idx]}";

            min_value = max_value;
            //min value , index
            for (int i = 0; i < arr_index; i++)
            {
                if (all_score[i] < min_value)
                {
                    min_value = all_score[i];
                }
                
                
            }
            
            min_idx = all_score.ToList().IndexOf(min_value);


            //show output min
            text_id_student_min.Text = $"{all_id[min_idx]}";
            text_name_min.Text = $"{all_name[min_idx]}";
            text_point_min.Text = $"{all_score[min_idx]}";

            //average output 

            //double average_grade = (double)(all_score.Sum() / arr_index);
            text_avg_point.Text = $"{(double)all_score.Sum() / (double)arr_index:0.00}";



        }
        //Min result

        private void text_id_student_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_point_min_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_avg_point_TextChanged(object sender, EventArgs e)
        {

        }

        //Min result


        //Max Result
        private void text_id_student_max_TextChanged(object sender, EventArgs e)
        {

            text_id_student_max.Text = $"{all_id[max_idx]}";

        }

        private void text_name_max_TextChanged(object sender, EventArgs e)
        {

            text_name_max.Text = $"{all_name[max_idx]}";

        }

        private void text_point_max_TextChanged(object sender, EventArgs e)
        {

            //text_point_max.Text = $"{all_[max_idx]}";

        }
        //Max result

    }
}
