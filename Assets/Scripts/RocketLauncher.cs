using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    Vector2 mousePos;
    public Camera cam;
    //public Rigidbody2D rbLauncher;
    public float angle;

    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - new Vector2(transform.position.x, transform.position.y);
/*        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        transform.rotation = angle;*/

        transform.LookAt(lookDir);
        transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
    }
}
