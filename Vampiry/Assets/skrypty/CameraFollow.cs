using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     public Transform player;
     public Vector3 offset = new Vector3(0,17.5f,37.5f);
     void Update()
     {
         transform.position = player.position - offset;
     }
     
}
