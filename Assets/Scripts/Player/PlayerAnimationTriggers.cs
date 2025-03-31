using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
    private Player player => GetComponentInParent<Player>();

    private void AnimationTrigger()
    {
        player.AnimationTrigger();
    }

    private void AttackTrigger()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(player.attackCheck.position, player.attackCheckRadius); //Physics2D.OverlapCircleAll: hàm cua unity, kiem tra xem co bat ki doi tuong co Collider2D nam trong vung tron nhat dinh hay khong
                                                                                                                   //tra ve 1 mang cac doi tuong kieu Collider2D  nam trong vung kiem tra
        foreach (var hit in collider)   //duyet qua tung doi tuong trong mang collider
        {
            if (hit.GetComponent<Enemy>() != null)      //kiem tra xem doi tuong hien tai (hit) co chua component Enemy hay khong (de xac dinh co phai la ke thu hay khong)
                hit.GetComponent<Enemy>().Damage();     
        }
    }
}
