using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace Windows_Elevator
{
    internal class Function
    {
        Database dt = new Database();

        public void OpenElevatorDoor(PictureBox elevatorleftdoor1,PictureBox elevatorrightdoor1 , Timer openElevatorTimer,
            Timer automatic_door, PictureBox elevatorleftdoor2, PictureBox elevatorrightdoor2, DataGridView dataGridView1, 
            PictureBox displaypanel, PictureBox elevatortopdisplay1, PictureBox elevatortopdisplay2
            )
        {
            //if elevator is in first floor , first floor door open
            if (Global.Door_Open == 1 && Global.Elevator_floor == "first")
            {
                if (Global.Door_Position < elevatorleftdoor1.Width && Global.Door_Position < elevatorrightdoor1.Width)
                {
                    elevatorrightdoor1.Left += 5;
                    elevatorleftdoor1.Left -= 5;
                    Global.Door_Position += 5;
                    Global.Door_Close = 1;
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.FloorPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources._1;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources._1;
                }
                else
                {

                    openElevatorTimer.Stop();
                    dt.insert_record("First-floor door is opened.");
                    dt.display_records(dataGridView1);

                    automatic_door.Start();

                }


            }
            //if elevator is in ground floor, groound floor door open
            else if (Global.Door_Open == 1 && Global.Elevator_floor == "ground")
            {
                if (Global.Door_Position < elevatorleftdoor2.Width && Global.Door_Position < elevatorrightdoor2.Width)
                {
                    elevatorrightdoor2.Left += 5;
                    elevatorleftdoor2.Left -= 5;
                    Global.Door_Position += 5;
                    Global.Door_Close = 1;
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.GroundPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources.G;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources.G;

                }
                else
                {

                    openElevatorTimer.Stop();
                    dt.insert_record("Ground-floor door is opened.");
                    dt.display_records(dataGridView1);

                    automatic_door.Start();

                }

            }

           



        }
        public void CloseElevatorDoor(PictureBox elevatorleftdoor1, PictureBox elevatorrightdoor1, Timer closeElevatorTimer,
            PictureBox elevatorleftdoor2, PictureBox elevatorrightdoor2, Timer automatic_door, DataGridView dataGridView1,
            PictureBox displaypanel, PictureBox elevatortopdisplay1, PictureBox elevatortopdisplay2)
        {
            //if elevator is in first floor ,first floor door close
            if (Global.Door_Open == 0 && Global.Elevator_floor == "first")
            {
                if (Global.Door_Position > 0)
                {
                    elevatorrightdoor1.Left -= 5;
                    elevatorleftdoor1.Left += 5;
                    Global.Door_Position -= 5;
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.FloorPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources._1;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources._1;



                }
                else
                {

                    closeElevatorTimer.Stop();
                    dt.insert_record("First-floor door is closed.");
                    dt.display_records(dataGridView1);
                    Global.Door_Close = 0;
                    Global.increment = 0;
                    automatic_door.Stop();


                }

            }
            //if elevator is in ground floor ,ground floor door close
            else if (Global.Door_Open == 0 && Global.Elevator_floor == "ground")
            {
                if (Global.Door_Position > 0)
                {
                    elevatorrightdoor2.Left -= 5;
                    elevatorleftdoor2.Left += 5;
                    Global.Door_Position -= 5;
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.GroundPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources.G;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources.G;





                }
                else
                {

                    closeElevatorTimer.Stop();
                    dt.insert_record("Ground-floor door is closed ");
                    dt.display_records(dataGridView1);
                    Global.Door_Close = 0;
                    Global.increment = 0;
                    automatic_door.Stop();



                }

            }
           

        }
        
        
        public void MoveElevator(PictureBox elevator, Timer moveElevatorTimer, Timer openElevatorTimer, Timer automatic_door, 
            PictureBox displaypanel,PictureBox elevatortopdisplay1, PictureBox elevatortopdisplay2, DataGridView dataGridView1)
        {
            // if elevator is in first floor at button press elevator goes to ground floor
            if (Global.Door_Open == 0 && Global.Elevator_floor == "ground")
            {
                displaypanel.Image = global::Windows_Elevator.Properties.Resources.down;
                elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources.down;
                elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources.down;
                if (Global.Elevator_Position < elevator.Height * 1.3 - 2)
                {
                    elevator.Top += 5;
                    Global.Elevator_Position += 5;
                    
                }
                else
                {

                    Global.Elevator_moving = false;
                    moveElevatorTimer.Stop();
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.GroundPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources.G;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources.G;
                    dt.insert_record(" Elevator is at ground floor");
                    dt.display_records(dataGridView1);

                    if (Global.Door_Open == 0 && !Global.automatic)
                    {
                        Global.Door_Open = 1;
                        openElevatorTimer.Start();
                        automatic_door.Start();


                    }
                }





            }
            // if elevator is in ground floor at button press elevator goes to first floor
            else if (Global.Door_Open == 0 && Global.Elevator_floor == "first")
            {
                displaypanel.Image = global::Windows_Elevator.Properties.Resources.up;
                elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources.up;
                elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources.up;
                if (Global.Elevator_Position > elevator.Height / 100)
                {

                    elevator.Top -= 5;
                    Global.Elevator_Position -= 5;
                    

                }
                else
                {

                    Global.Elevator_moving = false;
                    moveElevatorTimer.Stop();
                    displaypanel.Image = global::Windows_Elevator.Properties.Resources.FloorPic;
                    elevatortopdisplay1.Image = global::Windows_Elevator.Properties.Resources._1;
                    elevatortopdisplay2.Image = global::Windows_Elevator.Properties.Resources._1;
                    dt.insert_record(" Elevator is at first floor");
                    dt.display_records(dataGridView1);
                    if (Global.Door_Open == 0 && !Global.automatic)
                    {
                        Global.Door_Open = 1;
                        openElevatorTimer.Start();
                        automatic_door.Start();


                    }
                }






            }
           


        }
       
        
    }
}