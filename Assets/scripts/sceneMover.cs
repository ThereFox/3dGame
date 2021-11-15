using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sceneMover : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(onClick);
    }

    // Start is called before the first frame update
    private void onClick()
    {
        SceneManager.LoadScene(0);
    }
}
