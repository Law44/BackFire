using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
//base class so it can be inherited from other scripts

    int moveSpeed;
    int attackDamage;
    int lifePoints;
    float attackRadius;

    //movement
    float followRadius;

    Vector3 distanciaVector;

    float moveX;
    float moveY;
    public void setMoveY(float move){
        this.moveY = move;
    }

    public float getMoveY(){
        return moveY;
    }

    public void setMoveX(float move){
        this.moveX = move;
    }

    public float getMoveX(){
        return moveX;
    }
    public void setMoveSpeed(int speed)
    {
        moveSpeed = speed;
    }

    public void setAttackDamage(int attdmg)
    {
        attackDamage = attdmg;
    }

    public void setLifePoints(int lp)
    {
        lifePoints = lp;
    }

    public int getMoveSpeed()
    {
        return moveSpeed;
    }

    public int getAttackDamage()
    {
        return attackDamage;
    }

    public int getLifePoints()
    {
        return lifePoints;
    }

    public Vector3 getDistanciaVector(){
        return distanciaVector;
    }

    //movement toward a player
    public void setFollowRadius(float r)
    {
        followRadius = r;
    }
    //attack radius 
    public void setAttackRadius(float r)
    {
        attackRadius = r;
    }

    //if player in radius move toward him 
    public bool checkFollowRadius(Vector3 playerPosition, Vector3 enemyPosition)
    {
       distanciaVector = Vector3.Cross(playerPosition,enemyPosition);

       if(playerPosition.x < enemyPosition.x){
            setMoveX(-1);  
        }else {
            setMoveX(1);
        }

        if(playerPosition.y < enemyPosition.y){
            setMoveY(-1);  
        }else {
            setMoveY(1);
        }

       if(followRadius > distanciaVector.magnitude){
                   return true;
        }

       return false;
    }

    //if player in radius attack him
    public bool checkAttackRadius(Vector3 playerPosition, Vector3 enemyPosition)
    {
       Vector3 distanciaVector = Vector3.Cross(playerPosition,enemyPosition);

       if(attackRadius > distanciaVector.magnitude){
                   return true;
        }

       return false;
    }

    
}