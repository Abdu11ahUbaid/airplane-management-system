using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirlineManagementSystem.Views;

namespace AirlineManagementSystem.DL
{
    internal class PlaneManagement
    {
        private int planeID;
        private string planeType;
        private string planeName;
        private decimal ticketPrice;
        private DateTime departureTime;
        private DateTime arrivalTime;

        public int PlaneID { get => planeID; set => planeID = value; }

        public string PlaneType { get => planeType; set => planeType = value; }

        public string PlaneName { get => planeName; set => planeName = value; }
       
        public decimal TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public DateTime DepartureTime { get => departureTime; set => departureTime = value; }
        public DateTime ArrivalTime { get => arrivalTime; set => arrivalTime = value; }



        public PlaneManagement(int planeID, string planeName, string planeType, decimal ticketPrice, DateTime departureTime, DateTime arrivalTime) { this.planeID = planeID;}



    }
}
