using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class VergoedLabel : Form
    {
        public VergoedLabel()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, cancel the key press event
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Check if textbox1 has a valid numeric value
            if (int.TryParse(WoWeKMinput.Text, out int inputValue))
            {
                // Calculate the doubled value
                double doubledValue = inputValue * 0.23;

                // Update label1 with the doubled value
                WoWeKMouput.Text = doubledValue.ToString();
            }
            else
            {
                // If textbox1 doesn't contain a valid numeric value, display an error or handle it accordingly
                WoWeKMouput.Text = "0";
            }
        }

        private void ZaakKMinput_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(ZaakKMinput.Text, out int inputValue))
            {
                // Calculate the doubled value
                double doubledValue = inputValue * 0.3;

                // Update label1 with the doubled value
                ZaakKMoutput.Text = doubledValue.ToString();
            }
            else
            {
                // If textbox1 doesn't contain a valid numeric value, display an error or handle it accordingly
                ZaakKMoutput.Text = "0";
            }
        }

        private void ZaakKMinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, cancel the key press event
                e.Handled = true;
            }
        }

        private void BrutoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, cancel the key press event
                e.Handled = true;
            }
        }

        private void VergoedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, cancel the key press event
                e.Handled = true;
            }
        }

        private void EvergoedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, cancel the key press event
                e.Handled = true;
            }
        }

        private void NettoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BerekenBtn_Click(object sender, EventArgs e)
        {
            // Check if textbox1 has a valid numeric value
            double.TryParse(WoWeKMouput.Text, out double value1);
            double.TryParse(ZaakKMoutput.Text, out double value2);
            double.TryParse(BrutoBox.Text, out double value3);
            double.TryParse(VergoedBox.Text, out double value4);
            double.TryParse(EvergoedBox.Text, out double value5);
            {
                // Calculate the sum of values
                double sum = value1 + value2 + value3 * 0.7428 + value4 + value5 - 1.30;

                // Update textbox3 with the sum
                NettoBox.Text = sum.ToString();
            }
        }

        private int textBoxCount = 0; // Track the number of textboxes created

        private void AddButton_Click(object sender, EventArgs e)

        {
            // Check if the maximum number of textboxes has been reached
            if (textBoxCount < 9)
            {
                // Create first textbox
                CreateNewTextBox();

                // Create second textbox
                CreateNewTextBox();

                // Add delete button next to the first textbox
                AddDeleteButton();
            }
            else
            {
                MessageBox.Show("Maximaal aantal toegevoegd (5) bereikt.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Check if the maximum number of textboxes has been reached
            if (textBoxCount < 9)
            {
                // Create first textbox
                CreateNewTextBox();

                // Create second textbox
                CreateNewTextBoxOnRight();

                // Add delete button next to the first textbox
                AddDeleteButton();
            }
            else
            {
                MessageBox.Show("Maximaal aantal toegevoegd (5) bereikt.");
            }
        }

        private void CreateNewTextBox()
        {
            // Create a new System.Windows.Forms.TextBox
            System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();

            // Set properties for the new TextBox
            newTextBox.Size = new System.Drawing.Size(150, 20); // You can set the desired size

            // Calculate the Y position for the new TextBox
            int newY = groupBox2.Controls.Count * 9 + 73;

            // Set the location of the new TextBox
            newTextBox.Location = new System.Drawing.Point(13, newY);

            // Set the initial text of the new TextBox
            newTextBox.Text = "Vul hier in";

            // Add the new TextBox to groupBox2's Controls collection
            groupBox2.Controls.Add(newTextBox);

            // Increment the count of textboxes created
            textBoxCount++;
        }

        private void CreateNewTextBoxOnRight()
        {
            // Create a new System.Windows.Forms.TextBox
            System.Windows.Forms.TextBox newTextBox = new System.Windows.Forms.TextBox();

            // Set properties for the new TextBox
            newTextBox.Size = new System.Drawing.Size(100, 20); // You can set the desired size

            // Calculate the Y position for the new TextBox
            int newY = groupBox2.Controls.Count * 9 + 64;

            // Calculate the X position for the new TextBox to be to the right of the first textbox
            int newX = 15 + 209 + 10; // X position of first textbox + width of first textbox + spacing

            // Set the location of the new TextBox
            newTextBox.Location = new System.Drawing.Point(newX, newY);

            // Set the initial text of the new TextBox to "0"
            newTextBox.Text = "0";

            // Set text alignment to right
            newTextBox.TextAlign = HorizontalAlignment.Right;

            // Handle the KeyPress event to allow only numeric input
            newTextBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

            // Add the new TextBox to groupBox2's Controls collection
            groupBox2.Controls.Add(newTextBox);

            // Increment the count of textboxes created
            textBoxCount++;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric characters, Backspace, and Control modifier
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AddDeleteButton()
        {
            // Create a new delete button
            System.Windows.Forms.Button deleteButton = new System.Windows.Forms.Button();
            deleteButton.Size = new Size(20, 20);
            deleteButton.Text = "-";
            deleteButton.Click += DeleteButton_Click;

            // Calculate position for delete button
            int newY = groupBox2.Controls.Count * 9 + 56;

            // Set location for delete button next to the first textbox
            deleteButton.Location = new System.Drawing.Point(170, newY);

            // Add the delete button to groupBox2's Controls collection
            groupBox2.Controls.Add(deleteButton);

            // Make sure the delete button is visible
            deleteButton.Visible = true;
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Remove the last two textboxes and the delete button
            if (groupBox2.Controls.Count >= 3)
            {
                groupBox2.Controls.RemoveAt(groupBox2.Controls.Count - 1); // Remove delete button
                groupBox2.Controls.RemoveAt(groupBox2.Controls.Count - 1); // Remove second textbox
                groupBox2.Controls.RemoveAt(groupBox2.Controls.Count - 1); // Remove first textbox

                // Decrement the count of textboxes created
                textBoxCount -= 2;
            }
        }

    }
}
