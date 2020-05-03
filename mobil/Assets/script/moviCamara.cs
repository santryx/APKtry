using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moviCamara : MonoBehaviour
{

    public float speedMoving = 7.0f;
    Vector3 player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 2 * Time.deltaTime * speedMoving);
    }
}
