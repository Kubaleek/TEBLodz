using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
namespace Lekcja_03._10._2024
{
    public class Building
    {
        protected string _address;

        public string Address { get { return _address; } set { _address = value; } }

        public Building(string address)
        {
            _address = address;
        }


        public virtual int CostPerRoom(int cost)
        {
            return cost;
        }
    }

    public class House : Building
    {
        private int _rooms;

        public int Rooms { get { return _rooms; } set { _rooms = value; } }

        public House(string address, int rooms) : base(address)
        {
            _rooms = rooms;

        }
        public override int CostPerRoom(int cost)
        {
            return cost * _rooms;
        }
        public override string ToString()
        {
            return _rooms + "\t" + _address;
        }
    }

}
