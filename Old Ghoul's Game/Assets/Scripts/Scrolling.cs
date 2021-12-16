using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    void Update()
    {
        transform.Translate(4f * Time.deltaTime , 0, 0);
    }
}
