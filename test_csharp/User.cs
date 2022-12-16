using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_csharp
{
    public class User
    {
        public int Id { get; set; }
        public int IDU { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
    }
}
