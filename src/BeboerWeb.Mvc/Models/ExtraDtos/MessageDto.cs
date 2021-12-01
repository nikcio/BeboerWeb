using System.Collections.Generic;
using System;

namespace BeboerWeb.Mvc.Models.ExtraDtos
{
    public class MessageDto
    {
        public int SenderId { get; set; }
        public virtual string SenderName { get; set; }

        public virtual IEnumerable<int> ReceiverIds { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string MessageText { get; set; }

        public byte[] RowVersion { get; set; }

        public string Type { get; set; }
    }
}
