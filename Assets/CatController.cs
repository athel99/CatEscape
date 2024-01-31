using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class CatController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private float jumpforce = 680f;
    [SerializeField] private float moveforce = 0.003f;
    [SerializeField] private CloudGamedirector gameDirector;

    private void Start()
    {
        //this.gameDirector = GameObject.Find("GameDirector").GetComponent<ClimbCloudGameDirector>();
        //this.gameDirector = GameObject.FindAnyObjectByType<ClimbCloudGameDirector>();
    }
    void Update()
    {
        
        //����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rbody.AddForce(this.transform.up * this.jumpforce);//ȸ�������� ��
            //this.rbody.AddForce(Vector3.up * this.force); //�������θ� ��
            //���� ĳ������ y������ ���ư��� �Ʒ��� ������ y��������� ���ư���.
        }
        
        

        //Ű�� ������ �ִ� ���ȿ� �¿��̵�
        int dirX =0;
        


        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            dirX = 1;
           

        }

        if (Input.GetKey(KeyCode.LeftArrow)) 
        { 
            dirX = -1; 
           

        }

        

        if (dirX!= 0)
        {
            this.transform.localScale = new Vector3(dirX, 1, 1);

        }


        // Debug.Log(dir); //����

        //�ӵ��� �������� 


        if (Mathf.Abs(this.rbody.velocity.x) < 3)
        {
            this.rbody.AddForce(this.transform.right * dirX * moveforce);
        }
             
               
        // Gamedirector
        this.gameDirector.UpdateVelocityText(this.rbody.velocity);



    }
}
