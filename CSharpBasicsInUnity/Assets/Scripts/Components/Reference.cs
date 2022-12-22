using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Maze
{
    public sealed class Reference
    {
        private GameObject _bonusLabel;
        private GameObject _endGameLabel;
        private GameObject _restartButton;
        private Canvas _canvas;
        private Camera _mainCamera;

        public GameObject BonusLabel
        {
            get
            {
                if (_bonusLabel == null)
                {
                    GameObject bonusPrefab = Resources.Load<GameObject>("UI/Bonus");
                    _bonusLabel = Object.Instantiate(bonusPrefab, _canvas.transform);
                }
                return _bonusLabel;
            }
            set { _bonusLabel = value; }
        }

        public GameObject EndGameLabel
        {
            get
            {
                if (_endGameLabel == null)
                {
                    GameObject endGamePrefab = Resources.Load<GameObject>("UI/endGame");
                    _endGameLabel = Object.Instantiate(endGamePrefab, _canvas.transform);
                }
                return _endGameLabel;
            }
            set { _endGameLabel = value; }
        }

        public GameObject RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    GameObject Prefab = Resources.Load<GameObject>("UI/RestartButton");
                    _restartButton = Object.Instantiate(Prefab, _canvas.transform);
                }
                return _restartButton;
            }
            set { _restartButton = value; }
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }
            set { _canvas = value; }
        }

        public Camera MainCamera
        {
            get
            {
                if (!_mainCamera)
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
            set { _mainCamera = value; }
        }

    }
}