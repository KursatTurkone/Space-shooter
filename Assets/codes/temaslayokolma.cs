using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslayokolma : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerpatlama;

    GameObject oyuncontrol;
    oyunkontrol kontrol;
     void Start()
    {
        oyuncontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = oyuncontrol.GetComponent<oyunkontrol>();
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinir") {

            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(patlama,transform.position,transform.rotation);
            kontrol.ScoreArttir(10);
        }
        if (col.tag=="Player")
        {

            Instantiate(playerpatlama, col.transform.position, col.transform.rotation);
            kontrol.Oyunbitti();
        }
    }

}
