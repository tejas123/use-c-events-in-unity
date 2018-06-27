using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{

    #region UNITY_CALLBACKS
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            EventManager.RaiseOnReset();                    // Function call to invoke an Event
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            EventManager.RaiseOnReStart();                  // Function call to invoke an Event
        }
    }
    #endregion
}
