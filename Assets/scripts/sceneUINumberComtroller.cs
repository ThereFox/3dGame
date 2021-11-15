using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneUINumberComtroller : MonoBehaviour
{
    [SerializeField] private Text sceneText;

        private void Start()
    {
        sceneText.text = $"level № {SceneManager.GetActiveScene().buildIndex}"; 
    }

}
