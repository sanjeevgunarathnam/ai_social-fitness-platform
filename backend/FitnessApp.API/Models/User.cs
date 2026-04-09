using System;

namespace FitnessApp.API.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Username { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string Goal { get; set; }

        public string ExperienceLevel { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}