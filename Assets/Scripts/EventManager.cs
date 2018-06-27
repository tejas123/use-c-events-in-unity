using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    #region PUBLIC_VARIABLES
    
    public delegate void OnRest();              //Declare a Delegate
    public static event OnRest onReset;         //Create an Event

    public delegate void OnReStart();           //Declare a Delegate
    public static event OnReStart onReStart;    //Create an Event

    #endregion
 
    #region PUBLIC_FUNCTION
    public static void RaiseOnReset()
    {
        if (onReset != null)
        {
            onReset();                          //Invoke an Event
        }
    }
    public static void RaiseOnReStart()
    {
        if (onReStart != null)
        {
            onReStart();                       //Invoke an Event
        }
    }
    #endregion
}
