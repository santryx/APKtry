using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Obstaculoss : MonoBehaviour
{

    bool perdedor;
    public GameObject perdedor_text;
    GameObject personaje;



    // Start is called before the first frame update
    void Start()
    {
        perdedor_text.SetActive(false);
        personaje = GameObject.FindGameObjectWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {

        if (perdedor == true)

        {

            perdedor_text.SetActive(true);
            StartCoroutine("esperar");
            

        }

    }
    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            perdedor = true;

        }
    }

    public IEnumerator esperar()
    {
        yield return new WaitForSeconds(5f);
        ResetGame();

    }

    public void ResetGame()
    {

        SceneManager.LoadScene("juego");
    }
}
   
