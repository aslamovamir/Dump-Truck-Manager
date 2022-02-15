using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_BTN_Click(object sender, EventArgs e)
        {
            //let's get all the constants we need
            //we need a total of 20 trucks
            const int TOTAL_TRUCKS = 20;
            //we need total amount of ore not exceed 496 tons
            const int TOTAL_ORE_BOUNDARY = 496;
            //the max amount of weight a loader can take is 10
            const int MAX_AMOUNT_LOADER = 10;

            //we will need Rand machine to get random weights for the loader
            //create the random object and trigger it
            Random rand = new Random();

            //this variable will keep track of the total amount of ore in all 20 trucks in tons
            int total_ore_amount = 0;
            //this variable will keep track of the total number of trucks loaded
            int trucks_counter = 0;
            //this variable will keep track of the total weight of ore currently in a truck
            int current_truck_weight = 0;
            //this variable holds the amount of ore the loader happens to be filled with
            int loader_amount = 0;

            //we will keep running the loading process until 20 trucks are successfully loaded
            for (int i = 0; i < TOTAL_TRUCKS; i++)
            {
                //status
                Status_LB.Text = "New Truck On";
                Refresh();

                //we will pause the execution of the outer loop
                Thread.Sleep(700);

                //we will keep loading each truck with ore with the help of the loader until the
                //total amount in each truck does not exceed the allowed amount for each truck
                while (true)
                {
                    //pause the program
                    Thread.Sleep(40);

                    //set the status label to "loading"
                    Status_LB.Text = "Loading Truck";
                    //set the current weight of ore in the truck in the label
                    Current_Truck_Amount_LB.Text = current_truck_weight.ToString();

                    //the loader gets a random amount of ore between 0 to 10 tons of ore
                    loader_amount = rand.Next(0, MAX_AMOUNT_LOADER + 1);
                    //now we check if the loader amount will cause the total weight of ore in the truck exceed the max
                    if (current_truck_weight + loader_amount > TOTAL_ORE_BOUNDARY)
                    {
                        Exceeded_LB.Text = "YES!";
                        break;
                    }
                    //if not, we add the loader amount onto the truck
                    current_truck_weight += loader_amount;

                    //set the loader weight in the label
                    Weight_Loader_LB.Text = loader_amount.ToString();
                    //reset the current weight of ore in the truck in the label
                    Current_Truck_Amount_LB.Text = current_truck_weight.ToString();
                    //set the label for whether the truck weight exceeded the max to default
                    Exceeded_LB.Text = "NO";
                    Refresh();
                    //pause again
                    Thread.Sleep(55);
                }
                
                //now we add the total weight of the last truck's load to the total ore amount
                total_ore_amount += current_truck_weight;
                //set the total amount of ore in the label
                Total_LB.Text = total_ore_amount.ToString();
                Refresh();
                //we reset the current truck amount variable for the next truck
                current_truck_weight = 0;
                //track the number of trucks
                trucks_counter++;
                //set the trucks number in the label
                Trucks_Counter_LB.Text = trucks_counter.ToString();
                Refresh();
            }

            //at the end, we reset the labels, except for the nuber of successfully loaded trucks
            Weight_Loader_LB.Text = " ";
            Current_Truck_Amount_LB.Text = " ";
            Exceeded_LB.Text = " ";
            Status_LB.Text = "All Trucks Loaded";
            Refresh();
        }
    }
}
