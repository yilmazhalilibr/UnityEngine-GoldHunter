using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinText;
    public UnityEngine.UI.Button baslaButonu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void altinArttir() 
    {
        altinText.text = "" + altinSayisi;
    }
    public void oyunaBasla() 
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
}
