using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //HingeJointコンポーネントを入れる
    private HingeJoint myHingeJoint;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        //HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印キーまたはAキーを押した時左フリッパーを動かす
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //右矢印キーまたはDキーを押した時右フリッパーを動かす
        else if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //下矢印キーまたはSキーを押した時左右のフリッパーを動かす
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)))
        {
            SetAngle(this.flickAngle);
        }
        //キーが離された時フリッパーを元に戻す
        else if ((Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        else if ((Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        else if ((Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S)))
        {
            SetAngle(this.defaultAngle);
        }
    }

    //フリッパーの傾きを設定
    public void SetAngle (float angle)
    {
        JointSpring jointspr = this.myHingeJoint.spring;
        jointspr.targetPosition = angle;
        this.myHingeJoint.spring = jointspr;
    }
}
