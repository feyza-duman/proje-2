using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renk_degişim : MonoBehaviour {

    public Color [] renkler;
    Color ilk_renk;
    Color ikinci_renk;
    int br_renk;
    public Material zemin_materyali;


	void Start () {
        br_renk = Random.Range(0, renkler.Length);//6 renkten birini rastgele seçmesi için
        zemin_materyali.color = renkler[br_renk];// rastgele seçilen rengin zemine uygulanması için
        Camera.main.backgroundColor = renkler [br_renk];
       // ikinci_renk = renkler[ikinci_renk_belirle()];


	}
    int ikinci_renk_belirle()
    {
        int ik_renk;
        if (renkler.Length <= 1)
        {
            ik_renk = br_renk;
            return ik_renk;
        }
        ik_renk = Random.Range(0, renkler.Length);
        while (ik_renk == br_renk)
        {
            ik_renk = Random.Range(0, renkler.Length);
        }
        return ik_renk;
            
    }      

    void Update () {
        //zemin_materyali.color = Color.Lerp(zemin_materyali.color, ikinci_renk, 0.003f);
	}
}
