using _Assets.Scripts.Gameplay.Models;
using Pathfinding;
using UnityEngine;

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

        public void MoveToDestination()
        {
            _aiPath.isStopped = false;
            _aiPath.destination = new Vector3(_playerModel.destinationX, _playerModel.destinationY, 0);
        }

        public void Stop()
        {
            _aiPath.isStopped = true;
        }
        
        public void SetDestination(Vector2 position)
        {
            _playerModel.destinationX = position.x;
            _playerModel.destinationY = position.y;
        }
    }
}