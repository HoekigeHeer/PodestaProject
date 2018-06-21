using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;

    private void Update()
    {
  
            if (swipeControls.SwipeLeft)
        {
             Debug.Log("test");
        }
            if (swipeControls.SwipeRight)
        {
            Debug.Log("otherTest");
        }
    }
}