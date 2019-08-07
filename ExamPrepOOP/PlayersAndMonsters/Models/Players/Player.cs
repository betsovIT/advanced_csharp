using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public abstract class Player : IPlayer
    {
        private ICardRepository cardRepository;
        private string username;
        private int health;

        public Player(ICardRepository cardRepository,string username, int health)
        {
            this.cardRepository = cardRepository;
            this.Username = username;
            this.Health = health;
        }
        public ICardRepository CardRepository => this.cardRepository;

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
                }
                else
                {
                    this.username = value;
                }
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }
                else
                {
                    this.health = value;
                }
            }
        }

        public bool IsDead => this.health <= 0;

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0 )
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            if (this.health - damagePoints >= 0)
            {
                Health -= damagePoints;
            }
            else
            {
                Health = 0;
            }
        }
    }
}
