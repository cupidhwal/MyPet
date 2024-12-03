using UnityEngine;
using UnityEngine.AI;
using WOAT;

namespace MyPet.AI
{
    [System.Serializable]
    public class State_Sit : State<AnimalController>
    {
        // �ʵ�
        #region Variables
        private Animator animator;

        // animator parameter
        protected int isSitHash = Animator.StringToHash("IsSit");
        #endregion

        // �������̵�
        #region Override
        // �ʱ�ȭ �޼��� - ���� �� 1ȸ ����
        public override void OnInitialized()
        {
            // ����
            animator = context.GetComponent<Animator>();
        }

        // ���� ��ȯ �� State Enter�� 1ȸ ����
        public override void OnEnter()
        {
            animator.SetBool(isSitHash, true);
        }

        // ���� ��ȯ �� State Exit�� 1ȸ ����
        public override void OnExit()
        {
            animator.SetBool(isSitHash, false);
        }

        public override void Update(float deltaTime)
        {
            
        }
        #endregion
    }
}