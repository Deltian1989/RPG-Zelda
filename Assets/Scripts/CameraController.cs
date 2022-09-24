using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CharacterController2D Player;
    public float xLeftBound = -32;
    public float xRightBound = 40;
    public float yUpperBound = 6;
    public float yLowerBound = -16;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var x = Mathf.Clamp(Player.transform.position.x, xLeftBound, xRightBound);

        var y = Mathf.Clamp(Player.transform.position.y, yLowerBound, yUpperBound);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
