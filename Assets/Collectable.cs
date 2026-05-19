using UnityEngine;

public class Collectable : MonoBehaviour {


    void Start() {
        
    }

    void Update() {
        
    }

    public void Interact() {
        Debug.Log("Player interagiu com o coletável");
        Destroy(gameObject);
    }
}
