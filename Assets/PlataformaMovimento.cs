using UnityEngine;

public class PlataformaMovimento : MonoBehaviour {
    public Vector2 PosicaoFinal; //Primeiro lugar que a plataforma vai
    public Vector2 PosicaoInicial; //Lugar pra onde a plataforma volta

    public Vector2 Alvo;

    public bool EstaAtiva = true;

    private void Awake() {
        Alvo = PosicaoFinal;
    }

    private void Update() {
        if (EstaAtiva == false)
            return;
        if (Vector2.Distance(transform.position, Alvo) < 0.1f ) {
            if(Alvo == PosicaoFinal) {
                Alvo = PosicaoInicial;
            } else {
                Alvo = PosicaoFinal;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Alvo, Time.deltaTime * 5f);
    }









}
