using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 0.5f;
    float zamanSayaci= 0f;
    OyunKontrolcu okScript;
    // Start is called before the first frame update
    void Start()
    {
        okScript = this.gameObject.GetComponent<OyunKontrolcu>();
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsati = (int)(okScript.zamanSayacý / 10) - 6;
        katsati *= -1;
        if (zamanSayaci < 0 && okScript.zamanSayacý>0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(60f, 740f), -145f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D> ().AddForce(new Vector3 (0, Random.Range(7000f * katsati,55000f * katsati), 0));
            zamanSayaci = balonOlusturmaSuresi;
        }
    }
}
