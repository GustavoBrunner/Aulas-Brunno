using UnityEngine;

public class Collectable : MonoBehaviour {


    void Start() {
        var test = 10;
    }

    void Update() {
        
    }

    public void Interact() {
        Debug.Log("Player interagiu com o coletável");
        Destroy(gameObject);
    }
}
