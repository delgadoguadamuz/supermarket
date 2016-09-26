using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class supermarket : DbContext
    {
        public supermarket() : base("name=supermarket")
        {


        }
    }
}
