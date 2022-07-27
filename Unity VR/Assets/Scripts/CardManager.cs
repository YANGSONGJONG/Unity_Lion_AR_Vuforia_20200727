
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace KID.AR.Vuforia
{
    /// <summary>
    /// 圖片管理辨識器
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID 圖片")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("小騎士")]
        private Animator aniKnight;
        [SerializeField, Header("攻擊按鈕")]
        private Button btnAttack;
        [SerializeField, Header("虛擬按鈕跳躍")]
        private VirtualButtonBehaviour vbbJump;

        private string parVictory = "觸發勝利";
        private AudioSource audBGM;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
            btnAttack.onClick.AddListener(Attack);

            vbbJump.RegisterOnButtonPressed(OnJumpPressed);

            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnJumpPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>跳躍!!!</color>");
        }

        /// <summary>
        /// 圖片辨識成功
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>找到卡片</color>");
            aniKnight.SetTrigger(parVictory);
            audBGM.Play();
        }
        /// <summary>
        /// 圖片辨識失敗
        /// </summary>
        private void CardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
            audBGM.Stop();
        }

        private void Attack()
        {
            print("<color=#9955aa>攻擊!!!</color>");
        }
    }

}
