using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float Velocidade = 5f;

    public float ForcaPulo = 5f;

    public bool EstaNoChao = true;

    public Rigidbody2D Rb;

    public int Health = 100;

    private void Awake() {
        
    }

    private void Update() {
        float horizontal = Input.GetAxis("Horizontal");

        Vector2 direcao = new Vector2(horizontal, 0f);

        transform.Translate(direcao * Time.deltaTime * Velocidade);

        if (Input.GetKeyUp(KeyCode.Space) && EstaNoChao ){
            Rb.AddForce(Vector2.up * ForcaPulo, ForceMode2D.Impulse);
            
        }


        //if(Input.GetKeyUp(KeyCode.Space) && EstaNoChao) {
        //    Rb.AddForce(Vector2.up * ForcaPulo, ForceMode2D.Impulse);
        //    EstaNoChao = false;
        //}
    } //UPDATE ACABA AQUI

    private void OnTriggerExit2D(Collider2D collision){
        if (collision.CompareTag("Chao")) 
            EstaNoChao = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Chao")){
            EstaNoChao = true;
        }
        else if (collision.CompareTag("Void")) {
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.TryGetComponent(out EnemyController enemy)) {
            Health -= enemy.Damage;
            HudController.Instance.UpdateHp(Health);
            if (Health <= 0){
                //Player morreu
                SceneManager.LoadScene("SampleScene");
            }
        }
        else if(collision.TryGetComponent(out Collectable collectable)){
             collectable.Interact();
        }
        else if(collision.TryGetComponent<FinishObject>(out _)){
            SceneManager.LoadScene("WinScene");
        }

    }











    //private void OnTriggerEnter2D(Collider2D collision){
    //    if (collision.GetComponent<Plataforma>()){
    //        EstaNoChao = true;
    //    }
    //}
}
