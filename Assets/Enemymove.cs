using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemymove : Enemies
{

//variables
    public int _moveSpeed;
    public int _attackDamage;
    public  int _lifePoints;
    public float _attackRadius;

    public float _moveX;


    //movement
    public float _followRadius;
    //end
    [SerializeField] Transform playerTransform;
    [SerializeField] Collider2D playerCollider;
    //[SerializeField]Animator enemyAnim;
    SpriteRenderer enemySR;


    void Start()
    {
      //get the player transform   
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
      //enemy animation and sprite renderer 
       
      //set the variables
        setMoveSpeed(_moveSpeed);
        setAttackDamage(_attackDamage);
        setLifePoints(_lifePoints);
        setAttackRadius(_attackRadius);
        setFollowRadius(_followRadius);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (checkFollowRadius(playerTransform.localPosition,transform.localPosition))
        {   
            if (!this.gameObject.GetComponent<Rigidbody2D>().IsTouching(playerCollider)){
            
            
            if (!checkAttackRadius(playerTransform.position, transform.position)){
                //if player in front of the enemies
                    /*if (playerTransform.position.x < transform.position.x)
                    {   
                        this.transform.position += new Vector3(-getMoveSpeed() * Time.deltaTime, 0f, 0f);
                    }
                    //if player is behind enemies
                    else
                    {
                        this.transform.position += new Vector3(getMoveSpeed() * Time.deltaTime, 0f, 0f);
                    }           
                    if (playerTransform.position.y < transform.position.y)
                    {
                        this.transform.position += new Vector3(0f,-getMoveSpeed() * Time.deltaTime, 0f);
                    }else{
                        this.transform.position += new Vector3(0f,getMoveSpeed() * Time.deltaTime, 0f);
                    }*/
                   

                    
                   
                    transform.Translate(getMoveX() * getMoveSpeed() * Time.deltaTime,getMoveY() * getMoveSpeed() * Time.deltaTime,0f);
                }
           }
        }
    }


    
}

