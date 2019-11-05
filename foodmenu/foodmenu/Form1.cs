using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foodmenu
{
    public partial class imgBackgroundMenu : Form
    {
        public imgBackgroundMenu()
        {
            InitializeComponent();          
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
       
        }

        //this function is about the Tuna when we click on it
        private void btnTuna_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before               
            lstItems.Items.Add(nmTunaSw.Value + " x " + btnTuna.Text + "       = £"+(Convert.ToDouble(nmTunaSw.Value)*1.99));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmTunaSw.Value) * 1.99);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Egg when we click on itv
        private void btnEgg_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmEggSw.Value + " x " + btnEgg.Text + "        =  £" + (Convert.ToDouble(nmEggSw.Value) * 0.99));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmEggSw.Value) * 0.99);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Meat when we click on it
        private void btnMeat_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmMeatSw.Value + " x " + btnMeat.Text + "       =  £" + (Convert.ToDouble(nmMeatSw.Value) * 3.99));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmMeatSw.Value) * 3.99);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Chicken when we click on it
        private void btnChicken_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmChickenSw.Value + " x " + btnChicken.Text + "    =  £" + (Convert.ToDouble(nmChickenSw.Value) * 3.49));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmChickenSw.Value) * 3.49);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Lettuce when we click on it
        private void btnLettuce_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmLettuceSw.Value + " x " + btnLettuce.Text + "    =  £" + (Convert.ToDouble(nmLettuceSw.Value) * 0.49));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmLettuceSw.Value) * 0.49);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Tomato when we click on it
        private void btnTomato_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmTomatoSw.Value + " x " + btnTomato.Text + "     =  £" + (Convert.ToDouble(nmTomatoSw.Value) * 0.49));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmTomatoSw.Value) * 0.49);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Onion when we click on it
        private void btnOnion_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmOnionSw.Value + " x " + btnOnion.Text + "      =  £" + (Convert.ToDouble(nmOnionSw.Value) * 0.49));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmOnionSw.Value) * 0.49);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Sweet Corn when we click on it
        private void btnSweetCorn_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmSweetCornSw.Value + " x " + btnSweetCorn.Text + " =  £" + (Convert.ToDouble(nmSweetCornSw.Value) * 0.49));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmSweetCornSw.Value) * 0.49);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Coke when we click on it
        private void btnCoke_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmCokeDr.Value + " x " + btnCoke.Text + "       =  £" + (Convert.ToDouble(nmCokeDr.Value) * 0.89));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmCokeDr.Value) * 0.89);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Pepsi when we click on it
        private void btnpepsi_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmPepsiDr.Value + " x " + btnpepsi.Text + "      =  £" + (Convert.ToDouble(nmPepsiDr.Value) * 0.99));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmPepsiDr.Value) * 0.99);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Tango Orange when we click on it
        private void btnTangoOrange_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmTangoOrangeDr.Value + " x " + btnTangoOrange.Text + "=  £" + (Convert.ToDouble(nmTangoOrangeDr.Value) * 0.79));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmTangoOrangeDr.Value) * 0.79);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        //this function is about the Water when we click on it
        private void btnWater_Click(object sender, EventArgs e)
        {
            //this first line to add the number of items wanted to the listItems times the price with the pound sign before 
            lstItems.Items.Add(nmWaterDr.Value + " x " +btnWater.Text + "      =  £" + (Convert.ToDouble(nmWaterDr.Value) * 0.59));
            //this second line to add the price of the items to the lstPrice
            lstPrice.Items.Add(Convert.ToDouble(nmWaterDr.Value) * 0.59);
            //this is a function done further down the page to add the total price of this items in the textbox txtTotalPrice
            Mtotal();
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
                  
        }

        //this function is to display the form2 when we click on this button
        private void btnTotalPrice_Click(object sender, EventArgs e)
        {    
            //mention between brackets which kind of tool we want to transfer
            Form2 frmForm = new Form2(txtTotalPrice, lstItems);  
            //this line of code is to display form2
            frmForm.ShowDialog();          
        }

        //this function is to add the total price of all price items selected in the list price to the texbox txtTotal Price
        private void Mtotal()
        {
            double total = 0;
            //for each price items selected, they are added together 
            foreach (var selectedItems in lstPrice.Items)
            {
                total += Convert.ToDouble(selectedItems);
            }
            txtTotalPrice.Text = "£" + total.ToString();

        }

        //this function is to select price in the lstPrice when is clicked on the items in lstItems
        private void lstPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstItems.SelectedIndex = lstPrice.SelectedIndex;
            
        }

        //this function is to select items in lstItems when is clicked on the price in the lstPrice
        private void lstItem_Click(object sender, EventArgs e)
        {
            lstPrice.SelectedIndex = lstItems.SelectedIndex;
        }

        //this function is to delete items or item price previously selected 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            lstItems.Items.RemoveAt(lstItems.SelectedIndex);
            lstPrice.Items.RemoveAt(lstPrice.SelectedIndex);
            // to change the total after deleting
            Mtotal();
        }

        //this function is to delete all the list items or item price without selecting them
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstPrice.Items.Clear();
            // to change the total after clearing
            Mtotal();
        }       
    }
}
