using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cannibal_Numbers
{
    public partial class Cannibal_Numbers : Form
    {
        public Cannibal_Numbers()
        {
            InitializeComponent();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            // Declare variables
            String[] input = textBox_in.Text.Split(),
                query_in = textBox_query.Text.Split();
            String output = "Press \"Go!\" after filling out the other boxes";
            int[] query_out = new int[query_in.Length];

            // Todo: parse input and check if next number can be "eaten"
            for (int i = 0; i < input.Length; i++)
            {

            }

            // Parse query input
            // Todo: Check numbers from input after they have eaten and see if they meet the requirements
            for (int j = 0; j < query_in.Length; j++)
            {
                query_out[j] = int.Parse(query_in[j]);
            }

            // Send answer to output textbox
            output = String.Join("", input);
            textBox_out.Text = output;
        }
    }
}
