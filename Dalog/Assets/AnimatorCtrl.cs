using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using VikingCrewTools.UI;

public class AnimatorCtrl : MonoBehaviour
{
    public InputField txtMessage;
    public Animator animator;
    public Animator animator1;

    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void AniCtrl()
    {
        string input = txtMessage.text;
        string[] parts = input.Split('#');

        if (parts.Length == 2)
        {
            string animator1 = parts[0];
            string animator2 = parts[1];

            string[] aniText1 = animator1.Split('+');
            if (aniText1.Length==2)
            {
                string animatorsubtext = aniText1[0];
                Debug.Log("A");
                PerformAction(animatorsubtext);
            }
           

            string[] aniText2 = animator2.Split('+');
            if (aniText2.Length==2)
            {
                string animatorsubtext = aniText2[0];
                Debug.Log("B");
                PerformAction1(animatorsubtext);
            }
            
        }
        else
        {

            Text.text = "请按照“动作+说话内容发送!”";
        }
    }
    void PerformAction(string action)
    {
        // 根据不同的动作执行不同的操作


        if (action == "跑")
        {
            Text.text = "";
            //    // 示例：设置角色的动画状态为跑步
            Debug.Log("开始跑！");
            animator.SetBool("Ischong", false);
            animator.SetBool("Isgun", false);
            animator.SetBool("Ispao", true);
           
        }
        else if (action == "冲")
        {
            animator.SetBool("Isgun", false);
            animator.SetBool("Ispao", false);
            animator.SetBool("Ischong", true);
        }
        else if (action == "滚")
        {
            animator.SetBool("Ischong", false);
            animator.SetBool("Ispao", false);
            animator.SetBool("Isgun", true);
        }

        // 你可以在这里添加更多动作的处理逻辑
        txtMessage.text = "";
    }
    void PerformAction1(string action)
    {
        // 根据不同的动作执行不同的操作


        if (action == "跑")
        {
            Text.text = "";
            //    // 示例：设置角色的动画状态为跑步
            Debug.Log("开始跑！");
            animator1.SetBool("Ischong", false);
            animator1.SetBool("Isgun", false);
            animator1.SetBool("Ispao", true);

        }
        else if (action == "冲")
        {
            animator1.SetBool("Isgun", false);
            animator1.SetBool("Ispao", false);
            animator1.SetBool("Ischong", true);
        }
        else if (action == "滚")
        {
            animator1.SetBool("Ischong", false);
            animator1.SetBool("Ispao", false);
            animator1.SetBool("Isgun", true);
        }

        // 你可以在这里添加更多动作的处理逻辑
        txtMessage.text = "";
    }
    public void ISpaoAni()
    {

        if (animator != null)
        {
            animator.SetBool("Ispao", true);
        }
        else
        {
            Debug.LogError("Animator has not been assigned.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
