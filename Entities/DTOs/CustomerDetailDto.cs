﻿using Core.Entities;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}