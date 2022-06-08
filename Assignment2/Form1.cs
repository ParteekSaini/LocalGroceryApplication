using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        List<Grocery> GroceryList = new List<Grocery>();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadGroceryDataButton_Click(object sender, EventArgs e)
        {
            GroceryList = new List<Grocery>();

            using (StreamReader myInputStream = new StreamReader("localgrocery.csv"))
            {
                try
                {
                    string eachLine, headerLine="";
                    string[] headerTitles ;
                    string[] fieldsArrey = new string[7];

                    if (!myInputStream.EndOfStream)
                    {
                        eachLine = myInputStream.ReadLine();
                        headerTitles = eachLine.Split(',');
                        headerLine += headerTitles[0].PadRight(25, ' ');
                        for(int i=1; i < headerTitles.Length; i++)
                        {
                            headerLine += headerTitles[i].PadRight(17,' ');
                        }
                        headerLine += "QtyHand".PadRight(17, ' ');
                        headerLine += "Sales".PadRight(17, ' ');
                        outputGroceryListBox.Items.Clear();
                        outputGroceryListBox.Items.Add(headerLine);

                        while (!myInputStream.EndOfStream)
                        {
                            eachLine = myInputStream.ReadLine();
                            fieldsArrey = eachLine.Split(',');
                            string itemName = fieldsArrey[0];
                            string itemCode = fieldsArrey[1];
                            float.TryParse(fieldsArrey[2], out float unitPrice);
                            int.TryParse(fieldsArrey[3], out int startingQty);
                            int.TryParse(fieldsArrey[4], out int qtyMinForRestock);
                            int.TryParse(fieldsArrey[5], out int qtySold);
                            int.TryParse(fieldsArrey[6], out int qtyRestocked);
                            Grocery eachGrocery = new Grocery(itemName, itemCode, startingQty, qtyMinForRestock,
                                                qtySold, qtyRestocked, unitPrice);
                            GroceryList.Add(eachGrocery);
                        }
                        foreach(Grocery item in GroceryList)
                        {
                            outputGroceryListBox.Items.Add(item);
                        }
                        statusLabel.Text = "Loaded " + GroceryList.Count + " items from input file";
                    }

                }
                catch(Exception ex)
                {
                    
                }
            }
        }

        private void updateSoldQtyButton_Click(object sender, EventArgs e)
        {
            int selIndex = outputGroceryListBox.SelectedIndex;
            if(outputGroceryListBox.SelectedIndex==-1|| outputGroceryListBox.SelectedIndex == 0)
            {
                statusLabel.Text = "Please Select an item from List";
            }else if(!int.TryParse(updateSoldQtyTextBox.Text,out int soldQty))
            {
                statusLabel.Text = "Please enter a valid integer";
            }else if (soldQty < 0 || soldQty > GroceryList[selIndex - 1].QuantityOnHand)
            {
                statusLabel.Text = "Sold Quantity should be can't be less than zero and greater than Quantity on hand";
            }
            else
            {
                GroceryList[selIndex - 1].QtySold += soldQty;
                //MessageBox.Show(GroceryList[selIndex - 1].QtySold.ToString());
                outputGroceryListBox.Items[selIndex] = GroceryList[selIndex - 1];
                updateSoldQtyTextBox.Clear();
                statusLabel.Text = "Incremented Qty Sold for item with code " + GroceryList[selIndex - 1].ItemCode;
            }

        }

        private void updateRestockedQtyButton_Click(object sender, EventArgs e)
        {
            int selIndex = outputGroceryListBox.SelectedIndex;
            if (outputGroceryListBox.SelectedIndex == -1 || outputGroceryListBox.SelectedIndex == 0)
            {
                statusLabel.Text = "Please Select an item from List";
            }
            else if (!int.TryParse(restockedQtyTextBox.Text, out int restockedQty))
            {
                statusLabel.Text = "Please enter a valid integer";
            }
            else if (restockedQty < 0 )
            {
                statusLabel.Text = "Restocked Quantity can't be less than zero";
            }
            else
            {
                GroceryList[selIndex - 1].QtyRestocked += restockedQty;
                //MessageBox.Show(GroceryList[selIndex - 1].QtySold.ToString());
                outputGroceryListBox.Items[selIndex] = GroceryList[selIndex - 1];
                restockedQtyTextBox.Clear();
                statusLabel.Text = "Incremented Restocked Quantity for item with item code " + GroceryList[selIndex - 1].ItemCode;
            }
        }

        private void saveGroceryDataButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter myOutputStream = new StreamWriter("updatedgrocery.csv"))
            {
                try
                {
                    string headerLine = "ItemName,ItemCode,UnitPrice,StartingQty,QtyMinForRestock,QtySold,QtyRestocked";
                    myOutputStream.WriteLine(headerLine);
                    string eachLine = "";
                    foreach(Grocery eachGrocery in GroceryList)
                    {
                        myOutputStream.WriteLine(eachGrocery.ItemName +','+ eachGrocery.ItemCode+',' +
                                                eachGrocery.UnitPrice+',' +  eachGrocery.StartingQty + ',' +
                                                eachGrocery.QtyMinForRestock + ',' + eachGrocery.QtySold + ',' +
                                                eachGrocery.QtyRestocked);
                    }
                    statusLabel.Text = "Saved " + GroceryList.Count + " records into the output inventory file";
                }
                catch
                {

                }
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            int selIndex = outputGroceryListBox.SelectedIndex;
            if (selIndex == -1 || selIndex == 0)
            {
                statusLabel.Text = "Please select an item to delete";
            }
            else
            {
                string itemCode = GroceryList[selIndex - 1].ItemCode;
                GroceryList.RemoveAt(selIndex = 1);
                outputGroceryListBox.Items.RemoveAt(selIndex);
                statusLabel.Text = "“Deleted Item with item code " + itemCode;
            }
        }

        private void saveSalesReportButton_Click(object sender, EventArgs e)
        {
            using(StreamWriter myoutputStream = new StreamWriter("grocerysales.csv"))
            {
                try
                {
                    int count = 0;
                    myoutputStream.WriteLine("ItemName,ItemCode, UnitPrice, QtySold,Sales");
                    foreach(Grocery eachGrocery in GroceryList)
                    {
                        if (eachGrocery.QtySold > 0)
                        {
                            myoutputStream.WriteLine(eachGrocery.ItemName + ',' + eachGrocery.ItemCode + ',' +
                                                 eachGrocery.UnitPrice + ',' + eachGrocery.QtySold + ',' +
                                                 eachGrocery.TotalSales);
                            count = count + 1;
                        }
                    }
                    statusLabel.Text = "Saved " + count + " record into output sales file";
                }
                catch
                {

                }
            }
        }

        private void saveRestockNeedReportsButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter myoutputStream = new StreamWriter("groceryrestocks.csv"))
            {
                try
                {
                    myoutputStream.WriteLine("ItemName,ItemCode,QtyHand,QtyMinForRestock");
                    int count = 0; 
                    foreach(Grocery eachGrocery in GroceryList)
                    {
                        if (eachGrocery.QuantityOnHand < eachGrocery.QtyMinForRestock)
                        {
                            myoutputStream.WriteLine(eachGrocery.ItemName + ',' + eachGrocery.ItemCode + ','
                                + eachGrocery.QuantityOnHand + ',' + eachGrocery.QtyMinForRestock);
                            count = count + 1;
                        }
                    }
                    statusLabel.Text = "Saved " + count + " records into the restocks needed file";
                }
                catch
                {

                }
            }
        }
    }
}
