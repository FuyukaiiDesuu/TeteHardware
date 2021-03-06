﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TeteHardware
{
    public partial class formAddEmployee : Form
    {
        public formEmployeeManage ReferenceToEmpManage { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public int empLevel;
        public formAddEmployee()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formAddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAddEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAddEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToEmpManage.Show(); //shows the previous form upon exiting the current form
        }

        //COMMANDS FOR THE FORM
        private void btnBack_Click(object sender, EventArgs e) 
        {
            this.Close(); //closes current form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEname.Text = "";
            txtEpass.Text = "";
            txtEuser.Text = "";
            comboElevel.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEname.Text == "" || txtEuser.Text == "" || txtEpass.Text == "" || comboElevel.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                if (comboElevel.Text == "Admin")
                    empLevel = 0;
                else if (comboElevel.Text == "Cashier")
                    empLevel = 1;
                Add();
                this.Close();
            }
        }
        private void Add()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_employee(empName, empUser, empPass, empLevel, empDateEdit) VALUES('" + txtEname.Text + "','" + txtEuser.Text + "','" + txtEpass.Text + "','" + empLevel + "', '" + DateTime.Now.ToString("d") + "')", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_employee SET empID = autoID WHERE empUser = '" + txtEuser.Text + "'", conn);
                query1.ExecuteNonQuery();
                func.ChangeLog("tbl_employee", "All", "None");
                conn.Close();
                ReferenceToEmpManage.getData();
                ReferenceToEmpManage.dataLoad();
                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (MySqlException x)
            {
                if (x.Number.ToString() == "1062")
                {
                    MessageBox.Show("Username already exists!");
                    txtEuser.Focus();
                    txtEuser.SelectAll();
                }
                else
                {
                    MessageBox.Show("Error in Add() :" + x.ToString());

                }
                conn.Close();
            }
        }
    }
}
