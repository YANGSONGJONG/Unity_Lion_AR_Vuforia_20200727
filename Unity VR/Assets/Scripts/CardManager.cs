
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace KID.AR.Vuforia
{
    /// <summary>
    /// �Ϥ��޲z���Ѿ�
    /// </summary>
    public class CardManager : MonoBehaviour
    {
        [SerializeField, Header("KID �Ϥ�")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�p�M�h")]
        private Animator aniKnight;
        [SerializeField, Header("�������s")]
        private Button btnAttack;
        [SerializeField, Header("�������s���D")]
        private VirtualButtonBehaviour vbbJump;

        private string parVictory = "Ĳ�o�ӧQ";
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
            print("<color=#3366dd>���D!!!</color>");
        }

        /// <summary>
        /// �Ϥ����Ѧ��\
        /// </summary>
        private void CardFound()
        {
            print("<color=yellow>���d��</color>");
            aniKnight.SetTrigger(parVictory);
            audBGM.Play();
        }
        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>
        private void CardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
            audBGM.Stop();
        }

        private void Attack()
        {
            print("<color=#9955aa>����!!!</color>");
        }
    }

}
