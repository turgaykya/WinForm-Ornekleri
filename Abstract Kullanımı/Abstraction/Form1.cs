using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction
{
    public partial class Form1 : Form
    {
        Car car;
        Truck truck;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Make = "Mercedes";
            car.Model = "A180";
            car.Engine = 1800;
            car.Color = Color.Blue;
            car.Start();
            car.Stop();

            Truck truck = new Truck();
            truck.Make = "MAN";
            truck.Model = "AS2000";
            truck.Engine = 8000;
            truck.Color = Color.Red;
            truck.LoadCapacity = 20000;
            truck.Start();
            truck.Stop();


            //Vehicle vehicle = new Vehicle();
            //vehicle.Make = "Yamaha";
            //vehicle.Model = "MT25";
            //vehicle.Engine = 250;
            //vehicle.Color = Color.Blue;
        }

        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            car = new Car();
            car.Make = "BMW";
            car.Model = "320i";
            car.Engine = 2000;
            car.Color = Color.Green;

            lblCarDetails.Text = string.Format("Marka: {0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nİsmi: {4}",
                car.Make,
                car.Model,
                car.Engine,
                car.Color,
                car.ToString());
        }

        private void btnStartCar_Click(object sender, EventArgs e)
        {
            lblCarSound.Text = car.Start();
        }

        private void btnCreateTruck_Click(object sender, EventArgs e)
        {
            truck = new Truck();
            truck.Make = "DODGE";
            truck.Model = "asd123";
            truck.Engine = 10000;
            truck.Color = Color.Blue;
            truck.LoadCapacity = 200000;

            lblTruckDetails.Text = string.Format("Marka: {0}\nModel: {1}\nMotor: {2}\nRenk: {3}\nYük Kapasitesi: {4}\nİsmi: {5}",
                truck.Make,
                truck.Model,
                truck.Engine,
                truck.Color,
                truck.LoadCapacity,
                truck.ToString()
            );
        }
        private void btnStartTruck_Click(object sender, EventArgs e)
        {
            lblTruckSound.Text = truck.Start();
        }
        private void btnCarHorn_Click(object sender, EventArgs e)
        {
            lblCarHorn.Text = car.Horn();
        }
        private void btnTruckHorn_Click(object sender, EventArgs e)
        {
            lblTruckHorn.Text = truck.Horn();

        }



        
    }
}
