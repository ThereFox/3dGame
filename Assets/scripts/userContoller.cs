using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class userContoller : MonoBehaviour
{
    public objectMoveController interactionObject;
    [SerializeField] KeyCode forwardMove;
    [SerializeField] KeyCode reverseMove;
    void Update()
    {
        if (Input.GetKey(forwardMove))
        {
            interactionObject.moveForward();
        }
        if (Input.GetKey(reverseMove))
        {
            interactionObject.moveReverse();
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
