using UnityEngine;

public class EnemyController : MonoBehaviour{

    public float Speed = 3f;

    public float Fov = 10f;

    public int Health = 100;

    public int Damage = 10;

    public Transform PlayerPosition;

    private void Awake() {
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void Update(){
        if (Vector2.Distance(transform.position, PlayerPosition.position) < Fov) {
            Vector2 direction = (PlayerPosition.position - transform.position).normalized;
            transform.position += (Vector3)direction * Speed * Time.deltaTime;
        }
    }



}
