using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public float rotateSpeed = 10.0f, speed = 10.0f, zoomSpeed = 10.0f;
    private float mult = 1f;
    private void Update() {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        float rotate = 0f;
        if(Input.GetKey(KeyCode.Q))
            rotate = -1f;
        else if(Input.GetKey(KeyCode.E))
            rotate = 1f;
        
        mult = Input.GetKey(KeyCode.LeftShift) ? 2f : 1f;
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * rotate * mult, Space.World);
        transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * mult * speed, Space.Self);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 15f, 70f) , transform.position.z);
    }
}
