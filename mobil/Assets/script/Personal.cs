using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personal : MonoBehaviour
{
    Animator personaje;
    public float speedMoving = 7.0f;
    Vector3 player;
    // Start is called before the first frame update
    void Start()
    {

        personaje = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 2 * Time.deltaTime * speedMoving);
        MovePerson();
    }



    void MovePerson()
    {
        if (Input.touchCount > 0)
        {
            player = Camera.main.ScreenToWorldPoint(
                new Vector3(Input.GetTouch(0).position.x,
                Input.GetTouch(0).position.y,
                10));

            transform.position = player;

        }
    }

   
}



