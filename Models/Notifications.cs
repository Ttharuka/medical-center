using System;
using System.Collections.Generic;

namespace Medcs.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Notification { get; set; }
        public string Link { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public Users User { get; set; }
    }
}
