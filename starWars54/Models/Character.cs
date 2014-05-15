using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace starWars54.Models
{
    /// <summary>
    /// Character Abstract class
    /// </summary>
    public abstract class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Bio { get; set; }
        public string Pic { get; set; }
    }

    public class Jedi:Character
    {
        public string SaberColor  { get; set; }
        public string Rank { get; set; }
        public string Affiliation { get; set; }

        public Jedi() { }

        public Jedi(int id, string name, string bio, string pic, string sabercolor, string rank, string affiliation)
        {
            this.Id = id;
            this.Name = name;
            this.Bio = bio;
            this.Pic = pic;
            this.SaberColor = sabercolor;
            this.Rank = rank;
            this.Affiliation = affiliation;
        }

    }
    public class BountyHunter :Character

    {
        public string Weapon { get; set; }
        public double Price { get; set; }
        public double SuccessRate { get; set; }

        public BountyHunter() { }
        public BountyHunter(int id, string name, string bio, string pic, string weapon, double price, double successRate)
        {
            this.Id = id;
            this.Name = name;
            this.Bio = bio;
            this.Pic = pic;
            this.Weapon = weapon;
            this.Price = price;
            this.SuccessRate = successRate;
        }
    }
}