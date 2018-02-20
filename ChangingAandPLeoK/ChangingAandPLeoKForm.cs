/*
 * Leo Kay
 * Feb 20, 2018
 * code: ICS3U
 * this program allows the user to enter the length and width and displays the area and perimeter
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangingAandPLeoK
{
    public partial class ChangingAandPLeoKForm : Form
    {
        public ChangingAandPLeoKForm()
        {
            InitializeComponent();

            //Hiding labels
            this.lblAreaIs.Hide();
            this.lblPerimeterIs.Hide();
            this.lblAreaAnswer.Hide();
            this.lblPerimeterAnswer.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Allow these words to hold numbers
            double length, width, area, perimeter;

            //Convert the strings from the textbox into doubles
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);

            //calculate the area and perimeter
            area = length * width;
            perimeter = 2 * length + 2 * width;

            //convert the answers to strings
            this.lblAreaAnswer.Text = Convert.ToString(area) + " Squared Meters";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + " Meters";

            //display the answers
            this.lblAreaIs.Show();
            this.lblPerimeterIs.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeterAnswer.Show();
        }
    }
}
