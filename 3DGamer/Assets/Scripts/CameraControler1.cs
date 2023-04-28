using UnityEngine;

public class CameraControler1 : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 10.0f;
    public float zoomSpeed = 100.0f;

    private Vector3 lastMousePosition;

    void Update()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float mouseScroll = Input.mouseScrollDelta.y;

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePosition = new Vector3(mouseX, mouseY, 0);
        }
        else if (Input.GetMouseButton(0))
        {
            Vector3 delta = new Vector3(mouseX - lastMousePosition.x, mouseY - lastMousePosition.y, 0);
            transform.Translate(-delta * Time.deltaTime * moveSpeed);
            lastMousePosition = new Vector3(mouseX, mouseY, 0);
        }
        else if (Input.GetMouseButton(1))
        {
            float rotateX = Input.GetAxis("Mouse X");
            float rotateY = Input.GetAxis("Mouse Y");
            transform.RotateAround(transform.position, Vector3.up, rotateX * rotateSpeed);
            transform.RotateAround(transform.position, transform.right, -rotateY * rotateSpeed);
        }

        transform.position += transform.forward * mouseScroll * zoomSpeed * Time.deltaTime;
    }
}