using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin_olustur : MonoBehaviour {
    public GameObject son_zemin;

	void Start () {
        for (int i = 0; i < 40; i++)// 40 tane zemin olusturur
        {

            Zemin_olustur();
        }
	}
	public void Zemin_olustur()// rastgele yönlerde zemin oluşturmak için
    {
        Vector3 yon;
        if(Random.Range (0 , 2) == 0)
        {
            yon = Vector3.right;

        }
        else
        {
            yon = Vector3.back;

        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + yon, son_zemin.transform.rotation);
        //zemin oluşturmak için
    }


	void Update () {
		
	}
}
