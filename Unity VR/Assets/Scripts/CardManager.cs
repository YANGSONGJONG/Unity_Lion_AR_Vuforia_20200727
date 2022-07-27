
using UnityEngine;

namespace KID.AR.Vuforia
{
    /// <summary>
    /// 圖片管理辨識器
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID 圖片")]
        private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(CardFound);
            observerKID.OnTargetLost.AddListener(CardLost);
        }

        /// <summary>
        /// 圖片辨識成功
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>找到卡片</color>");
        }
        /// <summary>
        /// 圖片辨識失敗
        /// </summary>
        private void CardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
        }
    }

}
