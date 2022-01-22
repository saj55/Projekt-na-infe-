using UnityEngine;

public class zaMyszka : MonoBehaviour
{
   
    void FixedUpdate()
    {
        Camera mycam = GetComponent<Camera>();
 
        float sensitivity = 0.04f;
        Vector3 vp = mycam.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane));
        vp.x -= 0.5f;
        vp.y -= 0.5f;
        vp.x *= sensitivity;
        vp.y *= sensitivity;
        vp.x += 0.5f;
        vp.y += 0.5f;
        Vector3 sp = mycam.ViewportToScreenPoint(vp);
 
        Vector3 v = mycam.ScreenToWorldPoint(sp);
        transform.LookAt(v, Vector3.up);
    }
    

}
