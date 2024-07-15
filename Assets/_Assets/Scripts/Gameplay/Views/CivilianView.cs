using System;
using _Assets.Scripts.Gameplay.Controllers;
using UnityEngine;

namespace _Assets.Scripts.Gameplay.Views
{
    public class CivilianView : MonoBehaviour
    {
        private CivilianController _civilianController;

        private void Awake()
        {
            _civilianController = new CivilianController(transform);
        }

        private void Update()
        {
            _civilianController.UpdateModel();
        }
    }
}