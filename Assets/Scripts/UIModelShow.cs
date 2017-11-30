using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIModelShow : MonoBehaviour
{
    public Transform mRole;

    public Animator mAnimator;

    public UIWidget mTouch;

    public UISprite mStunBtn;

    public UISprite mDeadBtn;

    public UISprite mIdleBtn;

    #region 内置函数

    // Use this for initialization
    void Start ()
    {
        UIEventListener.Get(mTouch.gameObject).onDrag = OnTouchDrag;
        UIEventListener.Get(mStunBtn.gameObject).onClick = OnStunBtnClick;
        UIEventListener.Get(mDeadBtn.gameObject).onClick = OnDeadBtnClick;
        UIEventListener.Get(mIdleBtn.gameObject).onClick = OnIdleBtnClick;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    #endregion

    #region 回调函数

    private void OnTouchDrag(GameObject go, Vector2 delta)
    {
        float yrot = mRole.localEulerAngles.y - (delta.x * 0.5f);
        mRole.localEulerAngles = new Vector3(mRole.localEulerAngles.x , yrot, mRole.localEulerAngles.z);
    }

    private void OnStunBtnClick(GameObject go)
    {
        mAnimator.SetBool("stun", true);
    }

    private void OnDeadBtnClick(GameObject go)
    {
        mAnimator.SetBool("dead", true);
    }

    private void OnIdleBtnClick(GameObject go)
    {
        mAnimator.SetBool("stun", false);
        mAnimator.SetBool("dead", false);
    }

    #endregion
}
