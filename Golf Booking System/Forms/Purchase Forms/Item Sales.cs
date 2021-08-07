using DatabaseTables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Global_Variables.Global_Variables_class;
using static Validation.SearchingSorting;

namespace Golf_Booking_System
{


    public partial class Item_Sales : Form
    {

        private List<float> ItemPrices = new List<float>();
        private ItemSale SelectedItems = new ItemSale();
        private float fltTotalCost = 0;
        private Item Items;

        public Item_Sales()
        {
            InitializeComponent();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Sales_Menu frmSales_Menu = new Sales_Menu();
            frmSales_Menu.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Item_Sales_Load(object sender, EventArgs e)
        {

            LoadItemsIntoComboBox();
        }

        private void LoadItemsIntoComboBox()
        {
            //Loads all the item details from database
            Items = Item.LoadItems();

            AccountForCartItems();
            
            //Adds all the items into the listbox 
            for (int ItemIndex = 0; ItemIndex < Items.strItemID.Count; ItemIndex++)
                lstItems.Items.Add(Items.strItemID[ItemIndex]);


        }


        private void AccountForCartItems()
        {
            //Loops for every item in the database
            for (int ItemIndex = 0; ItemIndex < Items.strItemID.Count; ItemIndex++)
            {
                //Adds all the items from the database into list box.

                //Loops for every item in the cart. 
                for (int CartIndex = 0; CartIndex < CartItemSales.strItemID.Count; CartIndex++)
                {
                    //Checks to see if the items id is the same as the item id of the item in the cart. 
                    if (Items.strItemID[ItemIndex] == CartItemSales.strItemID[CartIndex])
                    {
                        //It then changes the quantity of the lend or the bought depending on the sale type.
                        if (CartItemSales.strLendOrBuy[CartIndex] == "B")
                        {
                            Items.strBuyQuantity[ItemIndex] = (int.Parse(Items.strBuyQuantity[ItemIndex]) - int.Parse(CartItemSales.strQuantity[CartIndex])).ToString();
                        }
                        else
                        {
                            Items.strLendQuantity[ItemIndex] = (int.Parse(Items.strLendQuantity[ItemIndex]) - int.Parse(CartItemSales.strQuantity[CartIndex])).ToString();
                        }

                    }
                }
            }
        }

        //Every time a different item is selected then it will reload the item details to accommodate for that item specifically
        private void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadItemDetails();

        }



        private void LoadItemDetails()
        {
            int intSelectedIndex = lstItems.SelectedIndex;

            //Since the user is able to click on the list box but not click on an item it will make the selected index -1 which would mean that it will try
            //to access item details at an idex of -1 in the items data structure which will make it crash.
            if (intSelectedIndex != -1)
            {
                //This gets all the item details and displays it all in the label. 
                lblItemDetails.Text = "Item Details" + Environment.NewLine + Environment.NewLine + "Name: " + Items.strItemID[intSelectedIndex] + Environment.NewLine
                + "Buy Cost: " + Items.strBuyCost[intSelectedIndex] + Environment.NewLine + "Lend Cost: " + Items.strLendCost[intSelectedIndex] + Environment.NewLine
                + "Buy Quantity: " + Items.strBuyQuantity[intSelectedIndex] + Environment.NewLine + "Lend Quantity: " + Items.strLendQuantity[intSelectedIndex];
            }
            

        }


        private void AddToPurchase_Click(object sender, EventArgs e)
        {
            if (ValidatePurchase())
            {
                AddSelectedItem();
                LoadSelectedItems();            
            }
                
        }

        //This adds the selected item to the selected item array so that they can be added to the cart.
        private void AddSelectedItem()
        {

            
            int intSelectedIndex = lstItems.SelectedIndex;
            string chrLendOrBuy;

            //Checks to see if the user wants to buy or lend and changes the quantities accordingly 
            if (rdbBuy.Checked)
            {
                chrLendOrBuy = "B";
                Items.strBuyQuantity[intSelectedIndex] = (int.Parse(Items.strBuyQuantity[intSelectedIndex]) - int.Parse(txtQuantity.Text)).ToString();                             
            }
            else
            {
                chrLendOrBuy = "L";
                Items.strLendQuantity[intSelectedIndex] = (int.Parse(Items.strLendQuantity[intSelectedIndex]) - int.Parse(txtQuantity.Text)).ToString();
            }
                         
            //Loops for each item in the selected list
            for (int i = 0; i < SelectedItems.strItemID.Count ; i++)
            {
                //Checks to see if the item the user wants to add is already in the selected list
                if (SelectedItems.strItemID[i] == Items.strItemID[intSelectedIndex])
                {
                    if (SelectedItems.strLendOrBuy[i] == chrLendOrBuy)
                    {
                        //If it is then it will add to the total instead of having multiple sales with different quantities.
                        int intQuantity = int.Parse(SelectedItems.strQuantity[i]) + int.Parse(txtQuantity.Text);
                        SelectedItems.strQuantity[i] = intQuantity.ToString();
                        break;
                    }
                    //If it's looped for every selected item and if it hasn't already been added then it will just add the items directly
                    else if (i == SelectedItems.strItemID.Count - 1)
                    {
                        SelectedItems.strItemID.Add(Items.strItemID[intSelectedIndex]);

                        SelectedItems.strLendOrBuy.Add(chrLendOrBuy);

                        SelectedItems.strQuantity.Add(txtQuantity.Text);
                        break;
                    }
                    
                    
                }
                //if it has looked at all the item in the selected list and there is no match then the item hasn't been added before
                //Therefore it needs to just be added. 
                else if(i == SelectedItems.strItemID.Count -1)
                {
                    SelectedItems.strItemID.Add(Items.strItemID[intSelectedIndex]);

                    SelectedItems.strLendOrBuy.Add(chrLendOrBuy);

                    SelectedItems.strQuantity.Add(txtQuantity.Text);

                    break;
                }
            }

            //If the user hasn't selected anything yet then the SelectedItems.strItemID will have a length of 0 and therefore won't run the above code
            //As a result it won't add anything until a single item is added, therefore this adds the item directly if nothing else has been added since.
            if (SelectedItems.strItemID.Count == 0)
            {
                SelectedItems.strItemID.Add(Items.strItemID[intSelectedIndex]);

                SelectedItems.strLendOrBuy.Add(chrLendOrBuy);

                SelectedItems.strQuantity.Add(txtQuantity.Text);
            }

        }

        private int FindItemIndex(string ItemID)
        {
            //Loops for every item ID in the Items database
            for (int i = 0; i < Items.strItemID.Count; i++)
            {
                //If the item name is identical to the one passed to it then it will return the index of that item ID
                if (Items.strItemID[i] == ItemID)
                {
                    return i;
                }

            }
            //This will return -1 if the item hasn't been found
            return -1;

        }
        private void LoadSelectedItems()
        {
            ItemPrices.Clear();
            lstPurchases.Items.Clear();
            fltTotalCost = 0;

            //Loads all item details from database
            Items = Item.LoadItems();
            //Loops for every already selected item
            for (int i = 0; i < SelectedItems.strItemID.Count; i++)
            {
                //Gets the index of the current item 
                int itemIndex = FindItemIndex(SelectedItems.strItemID[i]);

                //This then works out which quantities need to change depending if the selected items are to be lent or sold.
                if (SelectedItems.strLendOrBuy[i] == "L")
                {
                    Items.strLendQuantity[itemIndex] = (int.Parse(Items.strLendQuantity[itemIndex]) - int.Parse(SelectedItems.strQuantity[i])).ToString();
                }
                else
                {
                    Items.strBuyQuantity[itemIndex] = (int.Parse(Items.strBuyQuantity[itemIndex]) - int.Parse(SelectedItems.strQuantity[i])).ToString();
                }

            }

            //This will then account for the items already in the purchase cart.
            AccountForCartItems();

            //Loops for every already selected item 
            for (int i = 0; i < SelectedItems.strItemID.Count; i++)
            {
                string strItemDetails = "";
                float fltPrice;
                //The strItemDetails string is used to hold all the information the user will need to know about there added items.
                //Adds the name of the item here
                strItemDetails += Environment.NewLine + SelectedItems.strItemID[i] + " - £";

                int itemIndex = FindItemIndex(SelectedItems.strItemID[i]);

                //This then works out the pricing depending if it's a lended item or a bought one and then it adds a label depending on that. 
                if (SelectedItems.strLendOrBuy[i] == "L")
                {
                    strItemDetails += Items.strLendCost[itemIndex];
                    fltPrice = float.Parse(Items.strLendCost[itemIndex]);
                    strItemDetails += "(Lend)";
                }
                else
                {
                    strItemDetails += Items.strBuyCost[itemIndex];
                    fltPrice = float.Parse(Items.strBuyCost[itemIndex]);
                    strItemDetails += "(Buy)";
                }
                //This then works out the quantity then adds it to the string.
                float fltQuantity = float.Parse(SelectedItems.strQuantity[i]);
                strItemDetails += " |Quantity - " + fltQuantity.ToString() + " |";
                //This is just to refresh the Quantity
                LoadItemDetails();

                //This adds the price of the item to a list of prices that is used to determine the total price.
                ItemPrices.Add(fltQuantity * fltPrice);
                fltTotalCost += fltQuantity * fltPrice;

                //This works out the total price for the items
                lblTotal.Text = "Total: £" + Math.Round(fltTotalCost, 2);

                //Adds the item to the listbox so that the user can see it. 
                lstPurchases.Items.Add(strItemDetails);
            }
        }
  

        private  bool ValidatePurchase()
        {
            //First checks if there is a seleceted item
            if (lstItems.SelectedIndex != -1)
            {
                //Makes sure that there is a quantity
                if (txtQuantity.Text == null)
                {
                    MessageBox.Show("Enter Quantity");
                    return false;
                }
                else
                {
                    //Makes sure that the quantity is a valid format (Whole  Positive Integer)
                    if (int.TryParse(txtQuantity.Text, out int intQuantity) && intQuantity > 0)
                    {
                        if (rdbBuy.Checked == true)
                        {
                            //This checks if there is buy enough stock after the purchase
                            if (int.Parse(Items.strBuyQuantity[lstItems.SelectedIndex]) - intQuantity >= 0)
                                return true;
                            else
                            {
                                MessageBox.Show("Stocks Are Too Low For This Purchase");
                                return false;
                            }
                        }
                        else if (rdbLend.Checked == true)
                        {
                            //Checks if there is enough lending stock after the purchase
                            if (int.Parse(Items.strLendQuantity[lstItems.SelectedIndex]) - intQuantity >= 0)
                                return true;
                            else
                            {
                                MessageBox.Show("Stocks Are Too Low For This Purchase");
                                return false;
                            }

                        }
                        //If there isn't a type of purchase seleceted then it will be invalid
                        else
                        {
                            MessageBox.Show("Please Select Either Lend Or Buy");
                            return false;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Quanity Must Be A Positive Integer");
                        return false;
                    }
                }

            }
            else
            {
                MessageBox.Show("Please Select An Item");
                return false;
            }
                   
        }


        private void Search_Click(object sender, EventArgs e)
        {
            SearchForItem();
        }




        private void SearchForItem()
        {
            string strSearchKey = txtItemName.Text;

            //Does a binary search to find an item in the items data structure.
            int intItemIndex = BinarySearch(Items.strItemID, 0, Items.strItemID.Count, strSearchKey);
            //if the binary search returns -1 then it means that that item doesn't exist in the list .
            if ((intItemIndex == -1))
            {
                MessageBox.Show("That Item Isn't In the List");
            }
            else
            {
                //Since the list box index is exactly the same as the datastructure index it means that you can use 
                //the index that the binary search returns to select the item in the lsit box aswell.
                lstItems.SelectedIndex = intItemIndex;

                LoadItemDetails();
                MessageBox.Show("Item Found");

            }

        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            RemoveItemFromPurchase();
            
        }

        private void RemoveItemFromPurchase()
        {
            int intSelectedIndex = lstPurchases.SelectedIndex;
            //Checks if there is an item selected first.
            if (intSelectedIndex != -1)
            {              
                //The item will be in the item table to be able to remove it from the purchase
                int intItemIndex = BinarySearch(Items.strItemID, 0, Items.strItemID.Count, SelectedItems.strItemID[intSelectedIndex]);


                float fltPrice;
                //Checks what type of purchase it is (buy or lend)
                if (SelectedItems.strLendOrBuy[intSelectedIndex] == "B")
                {
                    fltPrice = float.Parse(Items.strBuyCost[intItemIndex]);
                    Items.strBuyQuantity[intItemIndex] = (int.Parse(Items.strBuyQuantity[intItemIndex]) + int.Parse(SelectedItems.strQuantity[intSelectedIndex])).ToString();
                }
                else
                {
                    fltPrice = float.Parse(Items.strLendCost[intItemIndex]);
                    Items.strLendQuantity[intItemIndex] = (int.Parse(Items.strLendQuantity[intItemIndex]) + int.Parse(SelectedItems.strQuantity[intSelectedIndex])).ToString();
                }
                    

                //Get the current total price and takes the price of the removed items from the total. 
                fltTotalCost -= fltPrice * int.Parse(SelectedItems.strQuantity[intSelectedIndex]);

                //Changes the label so that it has the new total cost which is rounded as it seems to randomly have extra floats.
                lblTotal.Text = "Total: £" + Math.Round(fltTotalCost, 2);


                //Removes the item from the selected items list at the correct index meaning that the items still have the same order
                SelectedItems.strItemID.RemoveAt(intSelectedIndex);
                SelectedItems.strLendOrBuy.RemoveAt(intSelectedIndex);
                SelectedItems.strQuantity.RemoveAt(intSelectedIndex);

                //Removes the item the same way as the selected items so that it can still have the same order.
                lstPurchases.Items.RemoveAt(intSelectedIndex);
                //Aslo removes the current list of item prices as that way you don't need to work out all the prices again.
                ItemPrices.RemoveAt(intSelectedIndex);

                LoadItemDetails();
            }
                
            else
                MessageBox.Show("Select An Item First");
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            int intCartLength = CartItemSales.strItemID.Count ;
            //Loops through all the selected items and adds the item details to the cart list.
            for (int intItemIndex = 0; intItemIndex < SelectedItems.strItemID.Count; intItemIndex++)
            {
                //Checks to see if the cart item Sales isn't empty
                if (intCartLength != 0)
                {
                    //It then loops for every item in cart
                    for (int intCartIndex = 0; intCartIndex < intCartLength; intCartIndex++)
                    {
                        //Checks to see if the item name and that the sale type are identical
                        if (CartItemSales.strItemID[intCartIndex] == SelectedItems.strItemID[intItemIndex] && CartItemSales.strLendOrBuy[intCartIndex] == SelectedItems.strLendOrBuy[intItemIndex])
                        {
                            //If they are identical then it will add the quantity and the prices together instead of adding them as seperate items
                            int intCartQuantity = int.Parse(CartItemSales.strQuantity[intCartIndex]) + int.Parse(SelectedItems.strQuantity[intItemIndex]);
                            CartItemSales.strQuantity[intCartIndex] = intCartQuantity.ToString();
                            Cart_Item_Prices[intCartIndex] += (ItemPrices[intItemIndex]);
                            break;
                        }
                        else if (intCartIndex == intCartLength -1)
                        {
                            //It will be a seperate item in the purchase cart if it's looked at all the other items in the list and they are then same ID and sale type. 
                            CartItemSales.strItemID.Add(SelectedItems.strItemID[intItemIndex]);
                            CartItemSales.strLendOrBuy.Add(SelectedItems.strLendOrBuy[intItemIndex]);
                            CartItemSales.strQuantity.Add(SelectedItems.strQuantity[intItemIndex]);

                            Cart_Item_Prices.Add(ItemPrices[intItemIndex]);
                        }
                    }
                }
                else
                {
                    //If there are no items in the list intially then it will just add all the items directly as the length is checked 
                    //before the loop starts therefore it will stay 0 if there are no items until this procedure is called again.
                    CartItemSales.strItemID.Add(SelectedItems.strItemID[intItemIndex]);
                    CartItemSales.strLendOrBuy.Add(SelectedItems.strLendOrBuy[intItemIndex]);
                    CartItemSales.strQuantity.Add(SelectedItems.strQuantity[intItemIndex]);

                    Cart_Item_Prices.Add(ItemPrices[intItemIndex]);
                }
                
                
                
       
            }

            
            ResetForm();
            

            MessageBox.Show("Items Have Been Added To The Purchase Cart");

        }

        //Resets all the variables and controls to their default values. 
        private void ResetForm()
        {
            CartTotal += fltTotalCost;
            fltTotalCost = 0;

            lblTotal.Text = "Total: £0.00";
            SelectedItems.strItemID.Clear();
            SelectedItems.strLendOrBuy.Clear();
            SelectedItems.strPurchaseID.Clear();
            SelectedItems.strQuantity.Clear();

            lstPurchases.Items.Clear();
        }
        #region Moveable Form Code
        private bool mouseDown;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
