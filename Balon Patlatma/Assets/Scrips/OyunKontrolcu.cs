using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrolcu : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public float zamanSayacý = 60;
    int patlayanBalon = 0;
    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayacý > 0) { 
        zamanSayacý -= Time.deltaTime;
        zamanText.text = "Süre : " + (int)zamanSayacý;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Balon");
            for (int i = 0; i < go.Length; i++)
                Destroy(go[i]);
        }
    }

    public void BalonEkle()
    {
        patlayanBalon += 1;
        balonText.text = "Balon : " + patlayanBalon;
    }
}
