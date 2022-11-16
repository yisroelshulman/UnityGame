using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    [SerializeField] Vector3 moveTo;
 
    // Start is called before the first frame update
    void Start()
    {
        moveTo = new Vector3(0, 2 , 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 2, 0);
    }
}
