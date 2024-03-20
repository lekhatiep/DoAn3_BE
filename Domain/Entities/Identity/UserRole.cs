﻿using Domain.Base;

namespace Domain.Entities.Identity
{
    public class UserRole : Entity<int>
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}