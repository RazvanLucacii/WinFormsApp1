using NorthwindCustomersPGS.Models;
using NorthwindCustomersPGS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripPinServiceRWAirportsRL.Models;
using TripPinServiceRWAirportsRL.Services;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void btnCargarAirports_Click(object sender, EventArgs e)
        {
            ServicesTripPin service = new ServicesTripPin();
            AirportsList airports = await service.GetAirportsListAsync();
            foreach (Airport airp in airports.Airports)
            {
                this.lsbAirports.Items.Add(airp.Name + " - " + airp.Location.Address);
            }
        }
    }
}
