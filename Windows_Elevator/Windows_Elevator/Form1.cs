namespace Windows_Elevator
{
    public partial class Form1 : Form
    {
        Function function = new Function();
        Database dt = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.delete_record();

            dt.display_records(displaytable);

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }




        //for open door button
        private void opendoor_Click(object sender, EventArgs e)
        {   // cheking conditions 
            if (Global.Door_Open == 0 && Global.Elevator_moving == false)
            {
                Global.Door_Open = 1;
                openElevatorTimer.Start();

            }

        }
        //Timer for opening door of elevator
        private void timer1_Tick(object sender, EventArgs e)
        {

            function.OpenElevatorDoor(elevatorleftdoor1, elevatorrightdoor1, openElevatorTimer, automatic_door,
                elevatorleftdoor2, elevatorrightdoor2, displaytable, displaypanel, elevatortopdisplay1, elevatortopdisplay2);



        }

        //for close door button
        private void closedoor_Click(object sender, EventArgs e)
        {
            //checking condition 
            if (Global.Door_Open == 1 && Global.Elevator_moving == false)
            {
                Global.Door_Open = 0;
                closeElevatorTimer.Start();
            }
        }

        //Timer for closing door of elevator
        private void timer2_Tick(object sender, EventArgs e)
        {
            function.CloseElevatorDoor(elevatorleftdoor1, elevatorrightdoor1, closeElevatorTimer,
                elevatorleftdoor2, elevatorrightdoor2, automatic_door, displaytable, displaypanel, elevatortopdisplay1, elevatortopdisplay2);



        }
        //for calling elevator down 
        private void downbutton_Click(object sender, EventArgs e)
        {
            if (!Global.Elevator_moving && Global.Door_Close == 0)
            {
                Global.Elevator_moving = true;
                Global.Elevator_floor = "first";



                moveElevatorTimer.Start();



            }
        }
        //Timer for moving elevator up and down 
        private void timer3_Tick(object sender, EventArgs e)
        { // calling moveElevator function


            function.MoveElevator(elevator, moveElevatorTimer, openElevatorTimer, automatic_door, displaypanel,
                    elevatortopdisplay1, elevatortopdisplay2, displaytable);



        }
        //for calling elevator up
        private void upbutton_Click(object sender, EventArgs e)
        {
            //checking condition 

            if (!Global.Elevator_moving && Global.Door_Close == 0)
            {
                Global.Elevator_moving = true;
                Global.Elevator_floor = "ground";



                moveElevatorTimer.Start();


            }
        }
        // for first floor button
        private void firstfloorbutton_Click(object sender, EventArgs e)
        {  //checking condition 
            if (!Global.Elevator_moving && Global.Door_Close == 0)
            {
                Global.Elevator_moving = true;
                Global.Elevator_floor = "first";
                moveElevatorTimer.Start();

            }

        }
        //for ground floor button
        private void groundfloorbutton_Click(object sender, EventArgs e)
        {  //checking condition 
            if (!Global.Elevator_moving && Global.Door_Close == 0)
            {
                Global.Elevator_moving = true;
                Global.Elevator_floor = "ground";

                moveElevatorTimer.Start();

            }

        }



        private void automatic_door_Tick(object sender, EventArgs e)
        {
            Global.increment++;
            if (Global.increment >= 50)
            {
                Global.Door_Open = 0;

                closeElevatorTimer.Start();


            }

        }

        private void ViewLog_Click(object sender, EventArgs e)
        {
            dt.display_records(displaytable);
        }
    }
}