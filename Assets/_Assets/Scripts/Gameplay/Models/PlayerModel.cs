﻿using System;

namespace _Assets.Scripts.Gameplay.Models
{
    [Serializable]
    public struct PlayerModel
    {
        public float destinationX, destinationY;
        public float positionX, positionY;
        public int health;
        public float speed;
        
        public PlayerModel(float positionX, float positionY, int health, float speed, float destinationX, float destinationY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.health = health;
            this.speed = speed;
            this.destinationX = destinationX;
            this.destinationY = destinationY;
        }
    }
}