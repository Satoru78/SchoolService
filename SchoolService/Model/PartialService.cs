using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolService.Model
{
    public partial class Service
    {
        public string GetPhoto
        {
            get
            {
                return Environment.CurrentDirectory + "\\" + MainImagePath;
            }
            set
            {
                MainImagePath = value;
            }
        }
    }
}
