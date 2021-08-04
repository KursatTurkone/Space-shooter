using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerControl : MonoBehaviour
{
    
    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float karakterhiz,egim;
    public float minX, maxX, minZ, maxZ;
    float ateszamani = 0;
    public float atesGecensure;
    public GameObject kursun;
    public Transform kursunNeredenCiksin;
    AudioSource audio;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }


    void FixedUpdate()
    {
        Debug.Log("moving"); 
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0, vertical);
        fizik.velocity = vec*karakterhiz;

        fizik.position = new Vector3(Mathf.Clamp(fizik.position.x,minX,maxX) , 0.0f , Mathf.Clamp(fizik.position.z,minZ,maxZ));

        fizik.rotation = Quaternion.Euler(0,0,fizik.velocity.x*-egim );


    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>ateszamani) 
        {
            ateszamani = Time.time + atesGecensure;
            Instantiate (kursun, kursunNeredenCiksin.position, Quaternion.identity);
            audio.Play();
        }

    }
}
