using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        int calories;
        int holder;
        string parses;
        //breakfast
        string[] breakfast =
        {
        "Yogurt & Honey Fruit Cups" + "\n" + "\n"+ "4-1/2 cups cut-up fresh fruit (pears, apples, bananas, grapes, etc.)" + "\n" + "3/4 cup (6 ounces) mandarin orange, vanilla or lemon yogurt" + "1 tablespoon honey" + "\n" + "1/2 teaspoon grated orange peel" + "\n" + "1/4 teaspoon almond extract" + "\n" + "\n" +"Total Calories : 97 Kcal",
        "Eggs Benedict" + "\n" +"\n" + "1 slice white bread" + "\n" + "1 egg" + "\n" + "50ml skimmed milk" + "\n" + "60g asparagus" + "\n" + "\n" + "Total Calories : 150Kcal",
        "Strawberry + Banana Chocolate Chip Oat Muffins" + "\n" + "\n" + "1 1/4 cup whole wheat pastry flour" + "\n" + "1 cup rolled oats" + "\n" + "3/4 teaspoon baking soda" + "\n" + "1/2 teaspoon baking powder" + "\n" + "1/4 teaspoon salt" + "\n" + "1 heaping cup mashed bananas (about 2 to 3 large very ripe bananas)" + "\n" + "1 tablespoon olive oil" + "\n" + "1 tablespoon honey or agave nectar" + "\n" + "1 teaspoon vanilla" + "\n" + "1 egg" + "\n" + "1 egg white" + "\n" + "1/3 cup nonfat plain greek yogurt" + "\n" + "1/2 cup unsweetened vanilla almond milk" + "\n" + "1/3 cup mini chocolate chips" + "\n" + "2/3 cup diced strawberries" + "\n" + "12 thin slices of strawberries (about 3-4 strawberries) for topping, if desired" + "\n" + "\n" +"Total Calories : 150 Kcal per muffin",
        };
        string[] breakfastlink =
        {
        "https://goo.gl/4Aryoo",
        "https://goo.gl/BhDdwR",
        "https://goo.gl/f9NVQ7"
        };
        // lunch
        string[] lunch = { };
        //dinner
        string[] dinner = { };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parses = textBox1.Text;
            if (!textBox1.Text.All(char.IsDigit) || string.IsNullOrWhiteSpace(parses))
            {
                MessageBox.Show("Please enter a valid value");
            }       
            else
            {
                calories = int.Parse(textBox1.Text);
                int selector = howmany(calories, holder);
                if (comboBox2.Text == "Yes please")
                {
                    if (comboBox1.Text == "Breakfast")
                    {
                    System.Diagnostics.Process.Start(breakfastlink[selector]);
                    }
                    if (comboBox1.Text == "Lunch")
                    {
                        MessageBox.Show(lunch[selector]);
                    }
                    if (comboBox1.Text == "Dinner")
                    {
                        MessageBox.Show(dinner[selector]);
                    }
                    
                    }
                else if (comboBox2.Text == "No thankyou")
                {
                    if (comboBox1.Text == "Breakfast")
                    {
                        MessageBox.Show(breakfast[selector]);
                    }
                    if (comboBox1.Text == "Lunch")
                    {
                        MessageBox.Show(lunch[selector]);
                    }
                    if (comboBox1.Text == "Dinner")
                    {
                        MessageBox.Show(dinner[selector]);
                    }
                }
                

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private int howmany(int transfer, int builder)
        {
           if (151> transfer)
            {
                builder = rand.Next(0,3);
            }
           else if (300 > transfer)
            {
                builder = rand.Next(0, 40);
            }
           else if (450 > transfer)
            {
                builder = rand.Next(0, 60);
            }
           else if (transfer > 451)
            {
                builder = rand.Next(0, 80);
            }
            return builder;
        }
    }
}
