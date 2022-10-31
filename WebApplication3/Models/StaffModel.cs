using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Entities;

namespace WebApplication3.Models
{
    public class StaffModel
    {
        public StaffModel(Staff staffModel)
        {
            id = staffModel.id;
            name = staffModel.name;
            phone = staffModel.phone;
            email = staffModel.email;
            image = staffModel.image;


        }
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public byte[] image { get; set; }
    }
}