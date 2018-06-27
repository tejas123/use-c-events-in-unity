using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMotion : MonoBehaviour
{
    #region PRIVATE_VARIABLES
    private float minRange, maxRange;
    private float speed, restartSpeed;
    private Vector3 newPosition;
    #endregion

    #region UNITY_CALLBACKS
    private void OnEnable()
    {
        EventManager.onReset += Reset;
        EventManager.onReStart += Restart;
    }
    // Use this for initialization
    void Start()
    {
        minRange = 1;
        maxRange = 3;
        speed = Random.Range(minRange, maxRange);
        restartSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {

        newPosition = transform.position;
        newPosition.x = Mathf.Sin(Time.time) * speed;
        transform.position = newPosition;


    }
    private void OnDisable()
    {
        EventManager.onReset -= Reset;
        EventManager.onReStart -= Restart;
    }
    #endregion
    #region PUBLIC_FUNCTIONS

    public void Reset()
    {
        speed = 0;
    }
    public void Restart()
    {

        speed = restartSpeed;
    }
    #endregion
}
