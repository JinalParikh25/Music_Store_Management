﻿namespace Music_Store_Management.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte unknown = 0;
        public static readonly byte payAsYouGo = 1;

    }
}
