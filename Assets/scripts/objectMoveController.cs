using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMoveController : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;
    
    public void moveForward()
    {
        GetComponent<Rigidbody>().velocity += moveDirection; 
    }

    public void moveReverse()
    {
        GetComponent<Rigidbody>().velocity -= moveDirection; 
    }
}
