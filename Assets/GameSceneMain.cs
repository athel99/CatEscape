using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneMain : MonoBehaviour
{
    
    [SerializeField] private Text textHp;
    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject  heroprefab;
    [SerializeField] private HeroDataManager heroDataManager;

    // Start is called before the first frame update
    void Start()
    {
        this.btnLoadScene.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Village");

        });

        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.heroprefab);

       HeroController heroController= heroGo.GetComponent<HeroController>();
        heroController.onHit = () => 
        {
           Debug.LogFormat("{0}{1}", heroController.Hp,heroController.MaxHp);
            this.heroDataManager.UpdateHeroHpAndMaxHp(heroController.Hp, heroController.MaxHp);


            this.textHp.text = string.Format("{0}/{1}",heroController.Hp,heroController.MaxHp); 
        }; //람다, 매서드->  대리자 변수 

    }
}
