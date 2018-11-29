﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.SceneManagement;

namespace Valve.VR.InteractionSystem
{
    public class OptionsMenuHandler : MonoBehaviour
    {
        public string gameScene;
        public void ExitGame()
        {
            Application.Quit();
        }
        public void ResumeGame()
        {
            SceneManager.LoadScene(gameScene);
        }
    }
}
