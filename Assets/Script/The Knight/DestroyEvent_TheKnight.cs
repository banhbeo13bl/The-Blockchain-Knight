using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEvent_TheKnight : MonoBehaviour 
{
    // Destroy particles when animation has finished playing. 
    // destroyEvent() is called as an event in animations.
    public void destroyEvent()
    {
        Destroy(gameObject);
    }
}
