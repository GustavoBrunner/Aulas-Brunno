using UnityEngine;

public class CameraController : MonoBehaviour{

    public Transform PlayerPosition;
    void Start(){
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update(){
        Vector3 newPosition = new Vector3(PlayerPosition.position.x, PlayerPosition.position.y, -10f);
        transform.position = newPosition;
    }
}
