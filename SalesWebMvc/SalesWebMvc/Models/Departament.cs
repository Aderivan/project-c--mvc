using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {
        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller sr)
        {
            Sellers.Add(sr);
        }

        public double TotalSellers(DateTime dateInit, DateTime dateFinish)
        {
            return Sellers.Sum(seller => seller.TotalSales(dateInit, dateFinish));
        }

    }


}
