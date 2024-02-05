using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasketController : MonoBehaviour
{private GameData gameData; //���ӵ����� �����

    [SerializeField] private AudioClip appleSE;
    [SerializeField] private AudioClip bombSE;
    AudioSource audioSource;

    public float score { get; set; } //�Ӽ� ; �ܺ� ���� ���� ; //����
    public float apple { get; set; } //�Ӽ� ; �ܺ� ���� ���� ; //�������
    public float bomb { get; set; } //�Ӽ� ; �ܺ� ���� ���� ; //��ź���� 


    public System.Action onHit; //�븮�� 

    private void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
        this.score = 0;
        this.apple = 0;
        this.bomb = 0;

    }


    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���̸� �߻�
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //���� �Ӽ� 
            //ray.origin ������ġ
            // ray.direction ����

            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10);

            //���̿� �ݶ��̴��� �浹üũ 

            RaycastHit hit; // �浹����
            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //Debug.Log("�浹��");
                //Debug.LogFormat("�浹����={0}", hit.point);
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

        this.onHit(); //�븮�� ȣ�� 

        Destroy(other.gameObject);
    }

   



}
