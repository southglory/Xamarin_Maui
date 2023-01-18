using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Views
{
    public class Ch_6_FlyoutPage1FlyoutMenuItem
    {
        public Ch_6_FlyoutPage1FlyoutMenuItem()
        {
            TargetType = typeof(Ch_6_FlyoutPage1FlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}