using _Assets.Scripts.Gameplay.Models;
using Pathfinding;
using UnityEngine;
using UnityEngine.AI;

namespace _Assets.Scripts.Gameplay.Controllers
{
    public class PlayerController
    {
        private readonly AIPath _aiPath;
        private readonly Transform _transform;
        private PlayerModel _playerModel;

        public PlayerController(AIPath aiPath, Transform transform)
        {
            _aiPath = aiPath;
            _transform = transform;
            _playerModel = new PlayerModel();
        }

        public void UpdateModel()
        {
            _playerModel.positionX = _transform.position.x;
            _playerModel.positionY = _transform.position.y;
        }
        
        public void MoveTo(Vector3 position)
        {
            //Debug.LogError("Move to");
            _aiPath.destination = position;
        }
    }
}