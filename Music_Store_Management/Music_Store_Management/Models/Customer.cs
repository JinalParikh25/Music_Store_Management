﻿using System.ComponentModel.DataAnnotations;

namespace Music_Store_Management.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public Byte MembershipTypeId { get; set; }
    }
}