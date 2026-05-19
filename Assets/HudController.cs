using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour{
    public static HudController Instance;

    public Image HpBar;

    void Awake(){
        Instance = this;
    }

    private void Update(){
        
    }

    public void UpdateHp(int hp) {
        HpBar.fillAmount = hp / 100f;
    }

}
