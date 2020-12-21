using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_takip : MonoBehaviour {
    public Transform taki_edilecek_nesne;
    Vector3 fark;
	void Start () {
        fark = transform.position - taki_edilecek_nesne.position;// kamera ile top arasındaki mesafeyi ayarlamak için
	}
	
	
	void Update () {
		
	}
    void LateUpdate()
    {
        if (player.düstü_mü == false)// top düştükten sonra kameranın takibi bırakması için
        {
            transform.position = taki_edilecek_nesne.position + fark;
        }
    }
}
