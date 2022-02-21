﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigaBike {
    public class Controller {
        public Login Login { get; }
        public Catalog Catalog { get; }
        public Order Order { get; }
        public DataBase DataBase { get; }

        public Controller() {
            this.DataBase = new DataBase();
            this.Login = new Login(this.DataBase);
            this.Catalog = new Catalog(this.DataBase);
            this.Order = new Order();
        }

        public void Init() {
            DataBase.Connect();
        }

        public void AddToOrder(Bike bike, int quantity) {
            // Add to order sequence
        }
    }
}
