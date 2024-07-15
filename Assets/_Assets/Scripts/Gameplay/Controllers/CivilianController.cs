using _Assets.Scripts.Gameplay.Models;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Controllers
{
    public class CivilianController
    {
        private Transform _transform;
        private AICivilianState _currentState;
        private CivilianModel _civilianModel;

        public CivilianController(Transform transform)
        {
            _transform = transform;
            _currentState = AICivilianState.Idle;
            _civilianModel = new CivilianModel();
        }
        
        public void UpdateModel()
        {
            _civilianModel.positionX = _transform.position.x;
            _civilianModel.positionY = _transform.position.y;
        }

        public enum AICivilianState
        {
            Idle,
            Patrol,
            Scared
        }
    }
}