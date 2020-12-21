using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
    Vector3 yon;
    public float hiz;
    public zemin_olustur zemin_Olustur;
    public static bool düstü_mü;
    public float hizlanma_zorluğu;
    public int skor_artması;
    float skor;
    public Text text_skor;
    int high_skor;
	void Start () {
        high_skor = PlayerPrefs.GetInt("highskor");
        yon = Vector3.back;
	}
	
	
	void Update () {
        if (düstü_mü == true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))//farenin sol tuşuna basıldığında topun hareketini sağlamak için
        {
            if (yon.x == 0)
            {
                yon = Vector3.right;
            }
            else
            {
                yon = Vector3.back;
            }
        }
        if (transform.position.y < 0.1f)
        {
            olme();
        }


	}
    void olme()// top düştükten sonraki puanı yazdırmak için
    {
        if (high_skor < (int)skor)
        {
            high_skor = (int)skor;
            PlayerPrefs.SetInt("highskor", high_skor);
        }
        düstü_mü = true;

    }
    void FixedUpdate()
    {
        if(düstü_mü){

            return;
        }
        Vector3 hareket = yon * Time.deltaTime * hiz;// topun hızını ayarlamak için
        transform.position += hareket;
        hiz += hizlanma_zorluğu * Time.deltaTime;// oyun ilerledikçe topun hızının artması için
        skor += (skor_artması * hiz*Time.deltaTime);
        text_skor.text = ((int) skor).ToString();// puanı int değerinde  ekrana yazdırmak için
    }

    void OnCollisionExit(Collision coll)//zeminde ayrıldıkça zemin üretilmesi için
    {
        if (coll.gameObject.tag == "zemin")
        {
            StartCoroutine(Kaldir(coll.gameObject));
         zemin_Olustur.Zemin_olustur();
        }

    }

   

    IEnumerator Kaldir(GameObject kaldirilacak)//geçilen zeminlerin kaldırmak  için 
    {
        yield return new WaitForSeconds(0.15f);//0.15 saniye sonra düşmeye başlaması için
        kaldirilacak.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(1.5f);//0.15 saniye bekleyeyip kaldırmak için
        Destroy(kaldirilacak);
         }



}


