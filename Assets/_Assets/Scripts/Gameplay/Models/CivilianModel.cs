using System;
using _Assets.Scripts.Gameplay.Controllers;

namespace _Assets.Scripts.Gameplay.Models
{
    [Serializable]
    public struct CivilianModel
    {
        public float positionX, positionY;
        public CivilianController.AICivilianState aiCivilianState;

        public CivilianModel(float positionX, float positionY, CivilianController.AICivilianState aiCivilianState)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.aiCivilianState = aiCivilianState;
        }
    }
}