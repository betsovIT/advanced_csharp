﻿using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private GunRepository gunRepository;

        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            gunRepository = new GunRepository();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public bool IsAlive => lifePoints > 0;

        public IRepository<IGun> GunRepository => gunRepository;

        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }
                else
                {
                    this.lifePoints = value;
                }
            }
        }

        public void TakeLifePoints(int points)
        {
            if (this.LifePoints - points < 0)
            {
                this.LifePoints = 0;
            }
            else
            {
                this.LifePoints -= points;
            }
        }
    }
}
