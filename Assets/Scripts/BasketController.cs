using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasketController : MonoBehaviour
{private GameData gameData; //게임데이터 저장소

    [SerializeField] private AudioClip appleSE;
    [SerializeField] private AudioClip bombSE;
    AudioSource audioSource;

    public float score { get; set; } //속성 ; 외부 접근 가능 ; //점수
    public float apple { get; set; } //속성 ; 외부 접근 가능 ; //사과갯수
    public float bomb { get; set; } //속성 ; 외부 접근 가능 ; //폭탄갯수 


    public System.Action onHit; //대리자 

    private void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
        this.score = 0;
        this.apple = 0;
        this.bomb = 0;

    }


    void Update()
    {
        //화면을 클릭하면 레이를 발사
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //레이 속성 
            //ray.origin 시작위치
            // ray.direction 방향

            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10);

            //레이와 콜라이더의 충돌체크 

            RaycastHit hit; // 충돌지점
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //Debug.Log("충돌함");
                //Debug.LogFormat("충돌지점={0}", hit.point);
                //this.cubeTransform.position=hit.point;
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);

                this.transform.position= new Vector3(x, 0, z);

            }

          
        }

        

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("{0}", other.gameObject.tag);
        if (other.gameObject.tag == "Apple")
        {
            this.score +=  10f;
            this.apple += 1;
            
            this.audioSource.PlayOneShot(this.appleSE);
            

        }
        else if (other.gameObject.tag == "Bomb")
        {
            
            this.score -=  10f;
            this.bomb += 1; 
            this.audioSource.PlayOneShot(this.bombSE);

        }

        this.onHit(); //대리자 호출 

        Destroy(other.gameObject);
    }

   



}
