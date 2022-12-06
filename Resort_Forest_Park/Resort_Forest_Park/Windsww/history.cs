using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Resort_Forest_Park.Entities;
using Resort_Forest_Park.Windsww;
using System.Threading.Tasks;

namespace Resort_Forest_Park.Windsww
{
    internal class history
    {
        public void ra(int i1, string i2)
        {
            Loginhistory loginhistory = new Loginhistory();
            loginhistory.id_employees = i1;
            loginhistory.Logintype = i2;
            loginhistory.Lastentrance = DateTime.Now;
            App.forestEntities.Loginhistory.Add(loginhistory);
            App.forestEntities.SaveChanges();           
        }
    }
}
