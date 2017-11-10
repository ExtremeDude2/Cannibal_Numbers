using System;
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
            String output = "";
            int[] query_out = new int[query_in.Length];

            // Parse query input
            for (int j = 0; j < query_in.Length; j++)
            {
                query_out[j] = int.Parse(query_in[j]);

                for (int i = 0; i < input.Length; i++)
                {
                    // Parse input and check if next number can be "eaten"
                    for (int h = i; h < input.Length - 1; h++)
                    {
                        if (int.Parse(input[i]) >= int.Parse(input[h + 1]))
                        {
                            input[i] = Convert.ToString(int.Parse(input[i]) + 1);
                        }
                    }

                    // Check numbers from input after they have eaten and see if they meet the requirements
                    if ((int.Parse(input[i]) >= query_out[j]))
                    {
                        output += input[i] + " ";
                    }
                }

                // Split up queries
                if (j < query_in.Length - 1)
                {
                    output += "| ";
                }

                // Reset input for next query
                input = textBox_in.Text.Split();
            }

            // Send answer to output textbox
            textBox_out.Text = output;
        }
    }
}
