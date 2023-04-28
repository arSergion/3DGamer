using UnityEngine;

public class PlayerObject : MonoBehaviour
{
    public LayerMask layer;
    private void Update(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if(Physics.Raycast(ray, out hit, 1000f, layer))
        transform.position = hit.point;
    if(Input.GetMouseButtonDown(0))
        Destroy(gameObject.GetComponent<PlayerObject>());
    }
}