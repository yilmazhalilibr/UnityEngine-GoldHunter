using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    private float hiz = 10;
    public oyunKontrol oyunK;
    public AudioClip altinS, dusmeS;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (oyunK.oyunAktif == true)
        {


            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");
            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;
            transform.Translate(x, 0f, y);
        }
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altinTag"))
        {
            GetComponent<AudioSource>().PlayOneShot(altinS,1f);
            oyunK.altinArttir();
            Destroy(c.gameObject);
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            oyunK.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(dusmeS, 1f);
        }
    }
}
