using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] pos;
    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {
        for(int i =0; i< pos.Length; i++)
        {
            Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
        }
    }
}
