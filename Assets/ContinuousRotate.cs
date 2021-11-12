using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuousRotate : MonoBehaviour
{

public float anglePerTick = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(anglePerTick,0,0,Space.Self);
    }
}
