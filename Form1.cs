﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class form : Form
    {
        public static int colNum = 10;
        public static int rowNum = 10;
        public System.Windows.Forms.Label[,] LabelGrid =  new System.Windows.Forms.Label[colNum, rowNum];
        public string[,] EnemyGrid = new string[colNum, rowNum];
        private bool initGrid = false;
        

        public form()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //For enemy ships grid
            this.buttonGrid.ColumnCount = colNum;
            this.buttonGrid.RowCount = rowNum;
            this.buttonGrid.ColumnStyles.Clear();
            this.buttonGrid.RowStyles.Clear();

            //Sets up the table for buttons
            for (int i = 0; i < colNum; i++)
            {
                this.buttonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / colNum));
            }
            for (int i = 0; i < rowNum; i++)
            {
                this.buttonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowNum));
            }

            //Sets up each button within the table
            for (int i = 0; i < rowNum; i++)
            {
                for (int j = 0; j < colNum; j++)
                {
                    //Creates new button
                    var button = new Button();

                    //Sets the text as a co-ordinate
                    button.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));

                    //Sets the name as a co-ordinate with no comma
                    button.Name = string.Format(Convert.ToString(i) + Convert.ToString(j));
                    button.Dock = DockStyle.Fill;
                    //Event handler for when a button is clicked
                    button.Click += new EventHandler(this.btnGridEvent_Click);
                    this.buttonGrid.Controls.Add(button, j, i);

                }
            }

            InitialisePlayerGrid();

            UpdateLabelText(0, 0, "F");
            if (HasThisTileBeenFiredAt(0, 0, 0) == true){
                Debug.WriteLine("This has been shot at");
            }
        }

        //Handles when the button grid is clicked
        private void btnGridEvent_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Debug.WriteLine("Button " + button.Text + " was clicked!");
        }

        //Initialises the playerships grid
        private void InitialisePlayerGrid(){
            if (initGrid == false)
            {
                //For player ships grid
                this.playerShips.ColumnCount = colNum;
                this.playerShips.RowCount = rowNum;
                this.playerShips.ColumnStyles.Clear();
                this.playerShips.RowStyles.Clear();

                //Sets up TableLayoutPanel for player ships
                for (int i = 0; i < colNum; i++)
                {
                    this.playerShips.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / colNum));
                }
                for (int i = 0; i < rowNum; i++)
                {
                    this.playerShips.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowNum));
                }

                for (int i = 0; i < rowNum; i++)
                {
                    for (int j = 0; j < colNum; j++)
                    {
                        var label = new System.Windows.Forms.Label();
                        
                        label.Text = string.Format(Convert.ToString(i) + "," + Convert.ToString(j));
                        label.Name = "label" + string.Format(Convert.ToString(i) + Convert.ToString(j));
                        label.Dock = DockStyle.Fill;
                        LabelGrid[i, j] = label;
                        this.playerShips.Controls.Add(label, j, i);
                    }
                }
                Controls.Add(playerShips);

                initGrid = true;
            }else{
                Debug.WriteLine("ERROR: GRID HAS ALREADY BEEN INITALISED");
            }

        }

        //Method to check if AI has shot there before
        private bool HasThisTileBeenFiredAt(int x, int y, int AIOrPlayer)
        {
            //If it is the AI
            if (AIOrPlayer == 0)
            {
                if (LabelGrid[x, y].Text == "F")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //If its the player
            else
            {
                if (EnemyGrid[x,y]== "F")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        private bool ValidateShipPlacement(int AIOrPlayer, int x1, int y1, int x2, int y2)
        {
            //If it is the AI
            if (AIOrPlayer == 0) {
                //Check if not in bounds of grid
                if(x1 > 10 || y1 > 10 || x2> 10 || y2 > 10) {
                    return false;
                    if(x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    //CODE NOT DONE BUT NEEDS TO CHECK FOR OVERLAP
                    return true;
                }
            }
            //If its the player
            else
            {
                //Check if not in bounds of grid
                if (x1 > 10 || y1 > 10 || x2 > 10 || y2 > 10)
                {
                    return false;
                    if (x1 < 0 || y1 < 0 || x2 < 0 || y2 < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    //CODE NOT DONE BUT NEEDS TO CHECK FOR OVERLAP
                    return true;
                }
            }

        }

        //This method updates the label grid with given x and y co-ords and a text field
        private void UpdateLabelText(int x, int y, String text)
        {
            LabelGrid[x,y].Text = text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
