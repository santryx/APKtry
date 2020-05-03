using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Meta : MonoBehaviour
{

    bool ganador;
    public GameObject ganador_text;
    GameObject personaje1;


    // Start is called before the first frame update
    void Start()
    {

        ganador_text.SetActive(false);
        personaje1 = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (ganador == true)

        {

            ganador_text.SetActive(true);
            StartCoroutine("esperar1");
        }

    }


    public void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);
            ganador = true;

        }
    }

    public IEnumerator esperar1()
    {
        yield return new WaitForSeconds(5f);
        ResetGame();

    }

    public void ResetGame()
    {

        SceneManager.LoadScene("juego");
    }
}
